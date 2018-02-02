using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class AuthorityUser
    {
        private string _Chk;
        private string _AuthId;
        private string _SysId;
        private string _UserId;
        private string _UserName;
        private string _DeptName;

        public AuthorityUser(Hashtable property)
        {
            _Chk = property["CHK"] is DBNull ? null : (string)property["CHK"];
            _AuthId = property["AUTH_ID"] is DBNull ? null : (string)property["AUTH_ID"];
            _UserName = property["USER_NM"] is DBNull ? null : (string)property["USER_NM"];
            _UserId = property["USER_ID"] is DBNull ? null : (string)property["USER_ID"];
            _DeptName = property["DEPT_NM"] is DBNull ? null : (string)property["DEPT_NM"];
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
        public string UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                _UserId = value;
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
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        [DataMember]
        public string DeptName
        {
            get
            {
                return _DeptName;
            }
            set
            {
                _DeptName = value;
            }
        }
    }
}
