using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NEXCORE.Utility
{
    [DataContract]
    [Serializable]
    public class ExceptionCode
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string MessageId { get; set; }
        [DataMember]
        public eCodeType CodeType { get; set; }
        [DataMember]
        public string MethodName { get; set; }
        [DataMember]
        public Type MethodBase { get; set; }
        //[DataMember]
        //public System.Diagnostics.StackFrame[] StackFrames { get; set; }
        [DataMember]
        public string[] MessageParams { get; set; }
        [DataMember]
        public string SQLIP { get; set; }
        [DataMember]
        public string ProcedureName { get; set; }
        [DataMember]
        public int LineNumber { get; set; }
        [DataMember]
        public int Severity { get; set; }
        [DataMember]
        public int State { get; set; }
        [DataMember]
        public bool ISSQLCutomError { get; set; }
 
    }

   
    public enum eCodeType
    {
        [EnumMember]
        INVALIDE_DATA = 10111,
        [EnumMember]
        VALUE_EMPTY = 10052,
        [EnumMember]
        BIZ_LAYER_CRITICAL = 10059,
        [EnumMember]
        DATA_LAYER_CRITICAL = 10049,
        [EnumMember]
        USER_FUNCTION_CRITICAL = 10050,
        [EnumMember]
        UNKNOWN = 10112,
        [EnumMember]
        DBCONNECTION_FAILED = 10113,
        [EnumMember]
        SERVICE_CONNECTION_FAILED = 10114,
        [EnumMember]
        AUTHORITY = 10074,
        [EnumMember]
        USERDEFINE = 0,
        [EnumMember]
        EXPIRE_DATE = 10115,
        [EnumMember]
        EXPIRED = 10116,
        [EnumMember]
        TIMEOUT = 10117,
        [EnumMember]
        NONE_SELECT = 10092,
        [EnumMember]
        NONE = 10118

    }
}
