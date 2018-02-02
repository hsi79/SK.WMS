using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NEXCORE.Utility
{
    public class DataException : ApplicationException
    {
        private ExceptionCode _ResultCode = new ExceptionCode();

        public ExceptionCode ResultCode
        {
            get { return _ResultCode; }
            set { _ResultCode = value; }
        }

        public DataException()
            : base()
        {

        }

        public DataException(string message)
            : base(message)
        {

        }

        public DataException(string message, System.Exception exception) :
            base(message, exception)
        {
            _ResultCode.Message = "데이터베이스 레이어 : " + exception.Message;

        }

        protected DataException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {

        }
    }
}
