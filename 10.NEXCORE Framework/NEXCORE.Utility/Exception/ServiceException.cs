using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NEXCORE.Utility
{
    [Serializable]
    public class ServiceException : Exception
    {

        private ExceptionCode _ResultCode = new ExceptionCode();

        public ExceptionCode ResultCode
        {
            get { return _ResultCode; }
            set { _ResultCode = value; }
        }

        public string Test { get; set; }
        /// <summary>
        /// Creates a new instance of ServiceException class
        /// </summary>
        public ServiceException() { }

        /// <summary>
        /// Creates a new instance of ServiceException class
        /// </summary>
        public ServiceException(string message) : base(message) { }

        /// <summary>
        /// Creates a new instance of ServiceException class
        /// </summary>
        public ServiceException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Creates a new instance of ServiceException class
        /// </summary>
        public ServiceException(Exception inner) : base(inner.Message, inner) { }

        /// <summary>
        /// Creates a new instance of ServiceException class
        /// </summary>
        protected ServiceException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            Console.WriteLine("");
        }
    }
}
