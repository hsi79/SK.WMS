using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NEXCORE.Utility
{
    [DataContract]
    public class ServiceExceptionData
    {
        private ExceptionCode _ResultCode = new ExceptionCode();

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public ExceptionCode ResultCode
        {
            get { return _ResultCode; }
            set { _ResultCode = value; }
        }

        [DataMember]
        public List<string> MethodNameList { get; set; }

        [DataMember]
        public List<string> DeclaringTypeList { get; set; }


   }
}
