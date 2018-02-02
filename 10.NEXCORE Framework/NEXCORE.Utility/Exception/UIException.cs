using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Diagnostics;


namespace NEXCORE.Utility
{
    public class UIException : ApplicationException
    {
        private ExceptionCode _ResultCode = new ExceptionCode();

        public ExceptionCode ResultCode
        {
            get { return _ResultCode; }
            set { _ResultCode = value; }
        }

        public UIException()
            : base()
        {
        }

        public UIException(string message)
            : base(message)
        {
        }

        public UIException(string message, Exception exception) :
            base(message, exception)
        {
            // Stack Tracing 정보를 저장 한다.
            System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace(exception);
           // _ResultCode.StackFrames = stackTrace.GetFrames();


            if (exception is UIException)
            {
                UIException userEx = exception as UIException;

                this._ResultCode.CodeType = userEx._ResultCode.CodeType;
                this._ResultCode.MessageParams = userEx._ResultCode.MessageParams;
            }

            //Stack Tracing Logging 한다.
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UI Layer 예외 수집");
            sb.AppendLine("Message : " + exception.Message);

            int i = 0;

            foreach (StackFrame sf in stackTrace.GetFrames())
            {
                sb.AppendLine(
                    string.Format("StackTrace[{0}] : [Type:{1}],[MethodName:{2}]",
                    i.ToString(), sf.GetMethod().DeclaringType.FullName, sf.GetMethod().Name));

                i++;
            }

            UtilityHelper.WriteLog(sb.ToString(), TraceEventType.Error);


            _ResultCode.Message = "Presentation 레이어 : " + message;

        }

        protected UIException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

       
        public UIException(string exceptionMessage, eCodeType code, params string[] messageParams)
            : base(exceptionMessage)
        {
            this._ResultCode.Message = exceptionMessage;
            this._ResultCode.MessageId = exceptionMessage;
            this._ResultCode.CodeType = code;
            this._ResultCode.MessageParams = messageParams;
        }

        public UIException(string exceptionMessage, string UserMessageID, eCodeType code, params string[] messageParams)
            : base(exceptionMessage)
        {
            this._ResultCode.MessageId = UserMessageID;
            this._ResultCode.Message = exceptionMessage;
            this._ResultCode.CodeType = code;
            this._ResultCode.MessageParams = messageParams;
        }
    }
}
