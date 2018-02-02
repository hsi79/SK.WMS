using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class Program
    {
        [DataMember]
        public bool Chk { get; set; }
        [DataMember]
        public string PgmId { get; set; }
        [DataMember]
        public string PgmPath { get; set; }
        [DataMember]
        public string PgmAssembly { get; set; }
        [DataMember]
        public string PgmClass { get; set; }
        [DataMember]
        public string PgmName { get; set; }
        [DataMember]
        public string PgmType { get; set; }
        [DataMember]
        public string PgmDescription { get; set; }
        [DataMember]
        public string AuthYN { get; set; }
        [DataMember]
        public string RegId { get; set; }
        [DataMember]
        public DateTime? RegTime { get; set; }
        [DataMember]
        public string ModId { get; set; }
        [DataMember]
        public DateTime? ModTime { get; set; }
        [DataMember]
        public Dictionary<string, string> ButtonAuthority { get; set; }
       
        public Program(Hashtable ht)
        {
            PgmId = (string)ht["PGM_ID"];
            PgmAssembly = (string)ht["PGM_ASSEMBLY"];
            PgmClass = (string)ht["PGM_CLASS"];
            PgmName = (string)ht["PGM_NM_KR"];
            PgmType = (string)ht["PGM_TYPE"];
            PgmDescription = (string)ht["PGM_DESC"];
            AuthYN = (string)ht["AUTH_YN"];
            RegId = (string)ht["REG_ID"];
            RegTime = SKConvert.GetDateTime(ht["REG_TIME"]);// is DBNull ? null : (DateTime?)ht["REG_TIME"]; 
            ModId = (string)ht["MOD_ID"];
            ModTime = SKConvert.GetDateTime(ht["MOD_TIME"]);// is DBNull ? null : (DateTime?)ht["MOD_TIME"];
            Chk = false;
        }

        public Program()
        {
        }
    }
}
