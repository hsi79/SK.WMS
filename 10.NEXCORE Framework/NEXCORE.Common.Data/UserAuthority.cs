﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Collections;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class UserAuthority
    {
        private string _Chk;
        private string _AuthId;
        private string _SysId;
        private string _UserId;
        private string _AuthName;


        public UserAuthority(Hashtable property)
        {
            _Chk = property["CHK"] is DBNull ? null : (string)property["CHK"];
            _AuthId = property["AUTH_ID"] is DBNull ? null : (string)property["AUTH_ID"];
            _AuthName = property["AUTH_NM"] is DBNull ? null : (string)property["AUTH_NM"];
            _UserId = property["USER_ID"] is DBNull ? null : (string)property["USER_ID"];
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

    }
}
