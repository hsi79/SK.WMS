using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class AuthorityPgm
    {
        private string _Chk;
        private string _AuthId;
        private string _SysId;
        private string _AuthName;
        private string _PgmId;
        private string _PgmName;    
        private string _c;
        private string _r;
        private string _d;
        private string _e;
        private string _p;

        public AuthorityPgm(Hashtable property)
        {
            _Chk = property["CHK"] is DBNull ? null : (string)property["CHK"];
            _AuthId = property["AUTH_ID"] is DBNull ? null : (string)property["AUTH_ID"];
            _AuthName = property["AUTH_NM"] is DBNull ? null : (string)property["AUTH_NM"];
            _PgmId = property["PGM_ID"] is DBNull ? null : (string)property["PGM_ID"];
            _PgmName = property["PGM_NM"] is DBNull ? null : (string)property["PGM_NM"];
            _c = property["SAVE_AUTH"] is DBNull ? null : (string)property["SAVE_AUTH"];
            _r = property["READ_AUTH"] is DBNull ? null : (string)property["READ_AUTH"];
            _d = property["DEL_AUTH"] is DBNull ? null : (string)property["DEL_AUTH"];
            _e = property["EXCEL_AUTH"] is DBNull ? null : (string)property["EXCEL_AUTH"];
            _p = property["PRINT_AUTH"] is DBNull ? null : (string)property["PRINT_AUTH"];
        }

        [DataMember]
        public string C
        {
            get
            {
                return _c;
            }
            set
            {
                _c = value;
            }
        }
        [DataMember]
        public string R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }
        [DataMember]
        public string D
        {
            get
            {
                return _d;
            }
            set
            {
                _d = value;
            }
        }
        [DataMember]
        public string E
        {
            get
            {
                return _e;
            }
            set
            {
                _e = value;
            }
        }
        [DataMember]
        public string P
        {
            get
            {
                return _p;
            }
            set
            {
                _p = value;
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
