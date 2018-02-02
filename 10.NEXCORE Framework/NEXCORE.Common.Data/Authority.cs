using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class Authority
    {
        private string _AuthId;
        private string _SysId;
        private string _AuthName;
        private string _UseYN;
        private string _RegId;
        private DateTime? _RegTime;
        private string _ModId;
        private DateTime? _ModTime;
        private string _authDesc;

        public Authority(Hashtable property)
        {

            _AuthId = property["AUTH_ID"] is DBNull ? null : (string)property["AUTH_ID"];
            _authDesc = property["AUTH_DESC"] is DBNull ? null : (string)property["AUTH_DESC"];
            _AuthName = property["AUTH_NM"] is DBNull ? null : (string)property["AUTH_NM"];
            _RegId = property["REG_ID"] is DBNull ? null : (string)property["REG_ID"];
            _RegTime = SKConvert.GetDateTime(property["REG_TIME"]);// is DBNull ? null : (DateTime?)property["REG_TIME"]; 
            _ModId = property["MOD_ID"] is DBNull ? null : (string)property["MOD_ID"];
            _ModTime = SKConvert.GetDateTime(property["MOD_TIME"]);// is DBNull ? null : (DateTime?)property["MOD_TIME"]; 
        }

        [DataMember]
        public string AuthDescription
        {
            get
            {
                return _authDesc;
            }
            set
            {
                _authDesc = value;
            }
        }
        [DataMember]
        public string AuthId
        {
            get
            {
                return _AuthId;
            }
            set
            {
                _AuthId = value;
            }
        }
        [DataMember]
        public string SysId
        {
            get
            {
                return _SysId;
            }
            set
            {
                _SysId = value;
            }
        }
        [DataMember]
        public string AuthName
        {
            get
            {
                return _AuthName;
            }
            set
            {
                _AuthName = value;
            }
        }
        [DataMember]
        public string UseYN
        {
            get
            {
                return _UseYN;
            }
            set
            {
                _UseYN = value;
            }
        }
        [DataMember]
        public string RegId
        {
            get
            {
                return _RegId;
            }
            set
            {
                _RegId = value;
            }
        }
        [DataMember]
        public DateTime? RegTime
        {
            get
            {
                return _RegTime;
            }
            set
            {
                _RegTime = value;
            }
        }
        [DataMember]
        public string ModId
        {
            get
            {
                return _ModId;
            }
            set
            {
                _ModId = value;
            }
        }
        [DataMember]
        public DateTime? ModTime
        {
            get
            {
                return _ModTime;
            }
            set
            {
                _ModTime = value;
            }
        }
    }
}
