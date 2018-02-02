using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class AuthorityButton
    {
        private string _Chk;
        private string _AuthId;
        private string _SysId;
        private string _AuthName;
        private string _PgmId;
        private string _PgmName;    
        private string _ButtonId;
        private string _ButtonName;
        private string _AuthYN;


        public AuthorityButton(Hashtable property)
        {
            _Chk = property["CHK"] is DBNull ? null : (string)property["CHK"];
            _AuthId = property["AUTH_ID"] is DBNull ? null : (string)property["AUTH_ID"];
            _AuthName = property["AUTH_NM"] is DBNull ? null : (string)property["AUTH_NM"];
            _PgmId = property["PGM_ID"] is DBNull ? null : (string)property["PGM_ID"];
            _PgmName = property["PGM_NM"] is DBNull ? null : (string)property["PGM_NM"];
            _ButtonId = property["BUTTON_ID"] is DBNull ? null : (string)property["BUTTON_ID"];
            _ButtonName = property["BUTTON_NM"] is DBNull ? null : (string)property["BUTTON_NM"];
            _AuthYN = property["AUTH_YN"] is DBNull ? null : (string)property["AUTH_YN"];
        }

        [DataMember]
        public string ButtonId
        {
            get
            {
                return _ButtonId;
            }
            set
            {
                _ButtonId = value;
            }
        }
        [DataMember]
        public string ButtonName
        {
            get
            {
                return _ButtonName;
            }
            set
            {
                _ButtonName = value;
            }
        }
        [DataMember]
        public string AuthYN
        {
            get
            {
                return _AuthYN;
            }
            set
            {
                _AuthYN = value;
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
        public string PgmId
        {
            get
            {
                return _PgmId;
            }
            set
            {
                _PgmId = value;
            }
        }
        [DataMember]
        public string PgmName
        {
            get
            {
                return _PgmName;
            }
            set
            {
                _PgmName = value;
            }
        }
        [DataMember]
        public string Chk
        {
            get
            {
                return _Chk;
            }
            set
            {
                _Chk = value;
            }
        }
    }
}
