using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization;
using NEXCORE.Utility;
using System.Data.SqlClient;

namespace NEXCORE.Utility
{
    [Serializable]
    public class BusinessException : ApplicationException
    {
        private ExceptionCode _ResultCode = new ExceptionCode();

        public ExceptionCode ResultCode
        {
            get { return _ResultCode; }
            set { _ResultCode = value; }
        }

        public BusinessException()
            : base()
        {
        }

        public BusinessException(string message)
            : base(message)
        {
        }

        public BusinessException(string message, Exception exception) :
            base(message, exception)
        {

            // Stack Tracing 정보를 저장 한다.
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(exception);
            // _ResultCode.StackFrames = stackTrace.GetFrames();


            if (exception.GetType() == typeof(DataException))
            {
                // DataException 처리를 한 경우
                _ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
            }
            else if (exception.GetType() == typeof(BusinessException))
            {
                BusinessException userEx = exception as BusinessException;

                this._ResultCode.CodeType = userEx._ResultCode.CodeType;
                this._ResultCode.MessageId = userEx._ResultCode.MessageId;
                this._ResultCode.MessageParams = userEx._ResultCode.MessageParams;
            }
            else if (exception.GetType().Equals(typeof(SqlException)))
            {
                //SQL 관련 에러 일 경우

                SqlException sqlEx = exception as SqlException;

                //1.개발자가 Raiserror를 통해서 작성 한 경우
                // errorMsg는 5자의 숫자
                int msgId = 0;

                string[] msgList = sqlEx.Message.Split(';');

                if (msgList != null && msgList[0].Length == 5 && Int32.TryParse(msgList[0], out msgId))
                {
                    if (msgList.Count() > 1)
                    {
                        this._ResultCode.ISSQLCutomError = true;
                        this._ResultCode.MessageId = msgList[0];
                        this._ResultCode.MethodName = sqlEx.Message;
                        try
                        {
                            this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                        }
                        catch { }
                        this._ResultCode.SQLIP = sqlEx.Server;
                        this._ResultCode.ProcedureName = sqlEx.Procedure;
                        this._ResultCode.LineNumber = sqlEx.LineNumber;

                        string[] paraList = new string[msgList.Length - 1];

                        for (int j = 1; j < msgList.Length; j++)
                        {
                            paraList[j - 1] = msgList[j];
                        }
                        this._ResultCode.MessageParams = paraList;
                    }
                    else if (msgList.Count() == 1)
                    {
                        this._ResultCode.ISSQLCutomError = true;
                        this._ResultCode.MessageId = sqlEx.Message;
                        try
                        {
                            this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                        }
                        catch { }
                        this._ResultCode.SQLIP = sqlEx.Server;
                        this._ResultCode.ProcedureName = sqlEx.Procedure;
                        this._ResultCode.LineNumber = sqlEx.LineNumber;
                    }
                }
                else if (sqlEx.Number == 2627)
                {
                    //사용자가 지정하지 않는
                    //Duplicate Error (Primary Key Contraint)

                    this._ResultCode.ISSQLCutomError = true;
                    this._ResultCode.MessageId = "19025";
                    this._ResultCode.MethodName = sqlEx.Message;
                    try
                    {
                        this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                    }
                    catch { }
                    this._ResultCode.SQLIP = sqlEx.Server;
                    this._ResultCode.ProcedureName = sqlEx.Procedure;
                    this._ResultCode.LineNumber = sqlEx.LineNumber;
                    string strTemp = @"'";

                    
                    string[] paraList = new string[1];

                    paraList[0] = sqlEx.Message;

                    try
                    {
                        string[] tempList = sqlEx.Message.Split(strTemp.ToCharArray()[0]);
                        if (tempList.Count() == 5 && String.IsNullOrEmpty(tempList[3]) == false)
                        {
                            paraList[0] = tempList[3];
                        }
                    }
                    catch { }


                    //for (int j = 1; j < msgList.Length; j++)
                    //{
                    //    paraList[j - 1] = msgList[j];
                    //}
                    this._ResultCode.MessageParams = paraList;

                }
                else
                {
                    // DB에서 발생 된 모르는 Error
                    this._ResultCode.ISSQLCutomError = false;
                    this._ResultCode.Message = sqlEx.Message;
                    this._ResultCode.SQLIP = sqlEx.Server;
                    this._ResultCode.ProcedureName = sqlEx.Procedure;
                    this._ResultCode.LineNumber = sqlEx.LineNumber;
                    this._ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
                    try
                    {
                        this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                    }
                    catch { }
                }
                //this._ResultCode.MessageId = sqlEx.
            }
            else
            {
                // DataLayer에서 Exception 처리를 하지 않았거나,
                // BizLayer 내부에서 발생 한 Exception
                Type targetType = exception.TargetSite.DeclaringType;

                if (targetType.BaseType.FullName.ToLower() == "SK.WMS.common.sksdacbase")
                {
                    //Dac에서 발생 된 Error
                    _ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
                }
                else if (targetType.BaseType.FullName.ToLower() == "SK.WMS.common.sksbizbase")
                {
                    //Biz에서 발생 된 Error
                    _ResultCode.CodeType = eCodeType.BIZ_LAYER_CRITICAL;
                }
                else
                {
                    //Biz, Dac가 아닌 다른 타입에서 발생 된 에러
                    //DataAccessWrapper 등.
                    _ResultCode.CodeType = eCodeType.UNKNOWN;

                }
            }

            //Stack Tracing Logging 한다.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Business Layer 예외 수집");
            sb.AppendLine("Message : " + exception.Message);
            if (string.IsNullOrEmpty(_ResultCode.Message))
                _ResultCode.Message = exception.Message;
            int i = 0;

            foreach (StackFrame sf in stackTrace.GetFrames())
            {
                sb.AppendLine(
                    string.Format("StackTrace[{0}] : [Type:{1}],[MethodName:{2}]",
                    i.ToString(), sf.GetMethod().DeclaringType.FullName, sf.GetMethod().Name));

                i++;
            }

            // CommonHelper.WriteLog(sb.ToString(), TraceEventType.Error);

        }


        private void ExceptionHandleFromCrossApp(string message, Exception exception)
        {
            // Stack Tracing 정보를 저장 한다.
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(exception);
            // _ResultCode.StackFrames = stackTrace.GetFrames();


            if (exception.GetType() == typeof(DataException))
            {
                // DataException 처리를 한 경우
                _ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
            }
            else if (exception.GetType() == typeof(BusinessException))
            {
                BusinessException userEx = exception as BusinessException;

                this._ResultCode.CodeType = userEx._ResultCode.CodeType;
                this._ResultCode.MessageId = userEx._ResultCode.MessageId;
                this._ResultCode.MessageParams = userEx._ResultCode.MessageParams;
            }
            else if (exception.GetType().Equals(typeof(SqlException)))
            {
                //SQL 관련 에러 일 경우

                SqlException sqlEx = exception as SqlException;

                //1.개발자가 Raiserror를 통해서 작성 한 경우
                // errorMsg는 5자의 숫자
                int msgId = 0;

                string[] msgList = sqlEx.Message.Split(';');

                if (msgList != null && msgList[0].Length == 5 && Int32.TryParse(msgList[0], out msgId))
                {
                    if (msgList.Count() > 1)
                    {
                        this._ResultCode.ISSQLCutomError = true;
                        this._ResultCode.MessageId = msgList[0];
                        this._ResultCode.MethodName = sqlEx.Message;
                        try
                        {
                            this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                        }
                        catch { }
                        this._ResultCode.SQLIP = sqlEx.Server;
                        this._ResultCode.ProcedureName = sqlEx.Procedure;
                        this._ResultCode.LineNumber = sqlEx.LineNumber;

                        string[] paraList = new string[msgList.Length - 1];

                        for (int j = 1; j < msgList.Length; j++)
                        {
                            paraList[j - 1] = msgList[j];
                        }
                        this._ResultCode.MessageParams = paraList;
                    }
                    else if (msgList.Count() == 1)
                    {
                        this._ResultCode.ISSQLCutomError = true;
                        this._ResultCode.MessageId = sqlEx.Message;
                        try
                        {
                            this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                        }
                        catch { }
                        this._ResultCode.SQLIP = sqlEx.Server;
                        this._ResultCode.ProcedureName = sqlEx.Procedure;
                        this._ResultCode.LineNumber = sqlEx.LineNumber;
                    }
                }

                else if (sqlEx.Number == 2627)
                {
                    //사용자가 지정하지 않는
                    //Duplicate Error (Primary Key Contraint)

                    this._ResultCode.ISSQLCutomError = true;
                    this._ResultCode.MessageId = "19025";
                    this._ResultCode.MethodName = sqlEx.Message;
                    try
                    {
                        this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                    }
                    catch { }
                    this._ResultCode.SQLIP = sqlEx.Server;
                    this._ResultCode.ProcedureName = sqlEx.Procedure;
                    this._ResultCode.LineNumber = sqlEx.LineNumber;

                    string[] paraList = new string[1];
                    paraList[0] = sqlEx.Message;

                    //for (int j = 1; j < msgList.Length; j++)
                    //{
                    //    paraList[j - 1] = msgList[j];
                    //}
                    this._ResultCode.MessageParams = paraList;

                }
                else
                {
                    // DB에서 발생 된 모르는 Error
                    this._ResultCode.ISSQLCutomError = false;
                    this._ResultCode.Message = sqlEx.Message;
                    this._ResultCode.SQLIP = sqlEx.Server;
                    this._ResultCode.ProcedureName = sqlEx.Procedure;
                    this._ResultCode.LineNumber = sqlEx.LineNumber;
                    this._ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
                    try
                    {
                        this._ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                    }
                    catch { }
                }
                //this._ResultCode.MessageId = sqlEx.
            }
            else
            {
                // DataLayer에서 Exception 처리를 하지 않았거나,
                // BizLayer 내부에서 발생 한 Exception
                Type targetType = null;
                if (exception.TargetSite != null)
                {
                    targetType = exception.TargetSite.DeclaringType;

                    if (targetType.BaseType.FullName.ToLower() == "SK.WMS.common.sksdacbase")
                    {
                        //Dac에서 발생 된 Error
                        _ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
                    }
                    else if (targetType.BaseType.FullName.ToLower() == "SK.WMS.common.sksbizbase")
                    {
                        //Biz에서 발생 된 Error
                        _ResultCode.CodeType = eCodeType.BIZ_LAYER_CRITICAL;
                    }
                    else
                    {
                        //Biz, Dac가 아닌 다른 타입에서 발생 된 에러
                        //DataAccessWrapper 등.
                        _ResultCode.CodeType = eCodeType.UNKNOWN;

                    }
                }
                else
                    _ResultCode.CodeType = eCodeType.UNKNOWN;
            }

            //Stack Tracing Logging 한다.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Business Layer 예외 수집");
            sb.AppendLine("Message : " + exception.Message);
            if (string.IsNullOrEmpty(_ResultCode.Message))
                _ResultCode.Message = exception.Message;
            int i = 0;

            if (stackTrace.FrameCount > 0)
            {
                foreach (StackFrame sf in stackTrace.GetFrames())
                {
                    sb.AppendLine(
                        string.Format("StackTrace[{0}] : [Type:{1}],[MethodName:{2}]",
                        i.ToString(), sf.GetMethod().DeclaringType.FullName, sf.GetMethod().Name));

                    i++;
                }
            }
        }

        protected BusinessException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
            try
            {
                Exception ex = (Exception)info.GetValue("InnerException", typeof(Exception));

                ExceptionHandleFromCrossApp(string.Empty, ex);
            }
            catch (Exception ee)
            {
                Debug.WriteLine(ee.Message);
            }
        }


        public BusinessException(string exceptionMessage, eCodeType code, params string[] messageParams)
            : base(exceptionMessage)
        {
            this._ResultCode.Message = exceptionMessage;
            this._ResultCode.MessageId = exceptionMessage;
            this._ResultCode.CodeType = code;
            this._ResultCode.MessageParams = messageParams;
        }

        public BusinessException(string exceptionMessage, string UserMessageID, eCodeType code, params string[] messageParams)
            : base(exceptionMessage)
        {
            this._ResultCode.MessageId = UserMessageID;
            this._ResultCode.Message = exceptionMessage;
            this._ResultCode.CodeType = code;
            this._ResultCode.MessageParams = messageParams;
        }
    }
}
