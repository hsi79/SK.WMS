using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using NEXCORE.Common.Data;
using System.ServiceModel;
using System.Diagnostics;
using System.Data.SqlClient;

namespace NEXCORE.Utility
{
    public class SKExceptionPolicy
    {
        public static bool HandleException(Exception exceptionToHandle,eSKExceptionPolicy policy)
        {
            return ExceptionPolicy.HandleException(exceptionToHandle, policy.ToString());
        }

        public static FaultException<ServiceExceptionData> HandleServiceException(Exception exception)
        {
            ServiceExceptionData exceptionData = new ServiceExceptionData();

            
            // Stack Tracing 정보를 저장 한다.
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(exception);
            StackFrame[] stfList  = stackTrace.GetFrames();


            if (exception.GetType() == typeof(DataException))
            {
                // DataException 처리를 한 경우
                exceptionData.ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
            }
            else if (exception.GetType() == typeof(BusinessException))
            {
                BusinessException userEx = exception as BusinessException;

                exceptionData.ResultCode= userEx.ResultCode;
 
            }
            else if (exception.GetType().Equals(typeof(SqlException)))
            {
                //SQL 관련 에러 일 경우

                SqlException sqlEx = exception as SqlException;

                //1.개발자가 Raiserror를 통해서 작성 한 경우
                // errorMsg는 5자의 숫자
                int msgId = 0;

                if (sqlEx.Message.Length == 5 && Int32.TryParse(sqlEx.Message, out msgId))
                {
                    // SKS Raiserror 일경우
                    exceptionData.ResultCode.ISSQLCutomError = true;
                    exceptionData.ResultCode.MessageId = sqlEx.Message;
                    try
                    {
                        exceptionData.ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
                    }
                    catch { }
                    exceptionData.ResultCode.SQLIP = sqlEx.Server;
                    exceptionData.ResultCode.ProcedureName = sqlEx.Procedure;
                    exceptionData.ResultCode.LineNumber = sqlEx.LineNumber;

                }
                else
                {
                    // DB에서 발생 된 모르는 Error
                    exceptionData.ResultCode.ISSQLCutomError = false;
                    exceptionData.ResultCode.Message = sqlEx.Message;
                    exceptionData.ResultCode.SQLIP = sqlEx.Server;
                    exceptionData.ResultCode.ProcedureName = sqlEx.Procedure;
                    exceptionData.ResultCode.LineNumber = sqlEx.LineNumber;
                    try
                    {
                        exceptionData.ResultCode.Severity = Convert.ToInt32(sqlEx.Class);
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
                    exceptionData.ResultCode.CodeType = eCodeType.DATA_LAYER_CRITICAL;
                }
                else if (targetType.BaseType.FullName.ToLower() == "SK.WMS.common.sksbizbase")
                {
                    //Biz에서 발생 된 Error
                    exceptionData.ResultCode.CodeType = eCodeType.BIZ_LAYER_CRITICAL;
                }
                else
                {
                    //Biz, Dac가 아닌 다른 타입에서 발생 된 에러
                    //DataAccessWrapper 등.
                    exceptionData.ResultCode.CodeType = eCodeType.UNKNOWN;

                }
            }

            //Stack Tracing Logging 한다.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Business Layer 예외 수집");
            sb.AppendLine("Message : " + exception.Message);
            if (string.IsNullOrEmpty(exceptionData.ResultCode.Message))
                exceptionData.ResultCode.Message = exception.Message;
            int i = 0;

            exceptionData.MethodNameList = new List<string>();
            exceptionData.DeclaringTypeList = new List<string>();

            foreach (StackFrame sf in stackTrace.GetFrames())
            {
                sb.AppendLine(
                    string.Format("StackTrace[{0}] : [Type:{1}],[MethodName:{2}]",
                    i.ToString(), sf.GetMethod().DeclaringType.FullName, sf.GetMethod().Name));

                i++;

                exceptionData.MethodNameList.Add(sf.GetMethod().Name);
                exceptionData.DeclaringTypeList.Add(sf.GetMethod().DeclaringType.FullName);
            }

            UtilityHelper.WriteLog(sb.ToString(), TraceEventType.Error);


            return new FaultException<ServiceExceptionData>(exceptionData);
            //exceptionData.ResultCode.Message = "데이터베이스 레이어 : " + message;


        }
    }
}
