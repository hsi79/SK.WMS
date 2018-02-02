using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public string MessageId { get; set; }
        [DataMember]
        public string MessageType { get; set; }
        [DataMember]
        public string MessageKO { get; set; }
        [DataMember]
        public string MessageEN { get; set; }
        [DataMember]
        public string MessageZH { get; set; }
        [DataMember]
        public string RegId { get; set; }
        [DataMember]
        public DateTime? RegTime { get; set; }
        [DataMember]
        public string ModId { get; set; }
        [DataMember]
        public DateTime? ModTime { get; set; }



        public Message(Hashtable ht)
        {
            MessageId= (string)ht["MESSAGE_ID"];
            MessageType = (string)ht["MESSAGE_TYPE"];
            MessageKO = (string)ht["MESSAGE_KO"];
            MessageEN = (string)ht["MESSAGE_EN"];
            MessageZH = (string)ht["MESSAGE_ZH"];
            RegId = (string)ht["REG_ID"];
            RegTime = SKConvert.GetDateTime(ht["REG_TIME"]);// is DBNull ? null : (DateTime?)DateTime.Parse(ht["REG_TIME"].ToString()); 
            ModId = (string)ht["MOD_ID"];
            ModTime = SKConvert.GetDateTime(ht["MOD_TIME"]);// is DBNull ? null : (DateTime?)DateTime.Parse(ht["MOD_TIME"].ToString()); 

        }
    }
}
