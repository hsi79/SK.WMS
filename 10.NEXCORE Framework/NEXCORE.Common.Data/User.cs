using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Data;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class User
    {
        #region private member
        [DataMember]
        private string _userId;
        [DataMember]
        private string _loginId;
        [DataMember]
        private string _sysId;
        [DataMember]
        private string _authId;
        [DataMember]
        private string _deptcd;
        [DataMember]
        private string _deptnm;
        [DataMember]
        private string _userName;
        [DataMember]
        private string _userNameEn;
        [DataMember]
        private string _password;
        [DataMember]
        private string _password1;
        [DataMember]
        private string _userType;
        [DataMember]
        private string _isLock;
        [DataMember]
        private string _tel;
        [DataMember]
        private string _mobile;
        [DataMember]
        private string _email;
        [DataMember]
        private DateTime? _startDate;
        [DataMember]
        private DateTime? _endDate;
        [DataMember]
        private string _regId;
        [DataMember]
        private DateTime? _regTime;
        [DataMember]
        private string _modId;
        [DataMember]
        private DateTime? _modeTime;

        
        #endregion

        public User(DataRow row)
        {
            this.UserId = row["UserId"].ToString();
            this.DeptNm = row["DeptNm"].ToString();
            this.Password = row["Password"].ToString();
            this.UserName = row["UserName"].ToString();
            this.IsLock = row["LockYN"].ToString() == "Y" ? "Y" : "N";
            this.SysId = row["SysId"].ToString();
            this.LoginId = row["LoginId"].ToString();
            this.DeptCd = row["DeptCd"].ToString();
            this.Tel = row["Tel"].ToString();
            this.Mobile = row["Mobile"].ToString();
            this.Email = row["Email"].ToString();

            
        }
        public User()
        {
        }
        #region IUser 멤버
        [DataMember]
        public string LoginId
        {
            get
            {
                return _loginId;
            }
            set
            {
                _loginId = value;
            }
        }
        [DataMember]
        public string UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
        [DataMember]
        public string SysId
        {
            get
            {
                return _sysId;
            }
            set
            {
                _sysId = value;
            }
        }
        [DataMember]
        public string DeptCd
        {
            get
            {
                return _deptcd;
            }
            set
            {
                _deptcd = value;
            }
        }
        [DataMember]
        public string DeptNm
        {
            get
            {
                return _deptnm;
            }
            set
            {
                _deptnm = value;
            }
        }
        [DataMember]
        public string AuthId
        {
            get
            {
                return _authId;
            }
            set
            {
                _authId = value;
            }
        }
        [DataMember]
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        [DataMember]
        public string UserNameEn
        {
            get
            {
                return _userNameEn;
            }
            set
            {
                _userNameEn = value;
            }
        }
        [DataMember]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        [DataMember]
        public string Password1
        {
            get
            {
                return _password1;
            }
            set
            {
                _password1 = value;
            }
        }
        [DataMember]
        public string UserType
        {
            get
            {
                return _userType;
            }
            set
            {
                _userType = value;
            }
        }
        [DataMember]
        public string IsLock
        {
            get
            {
                return _isLock;
            }
            set
            {
                _isLock = value;
            }
        }
        [DataMember]
        public string Tel
        {
            get
            {
                return _tel;
            }
            set
            {
                _tel = value;
            }
        }
        [DataMember]
        public string Mobile
        {
            get
            {
                return _mobile;
            }
            set
            {
                _mobile = value;
            }
        }
        [DataMember]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        [DataMember]
        public DateTime? StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
            }
        }
        [DataMember]
        public DateTime? EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
            }
        }
        [DataMember]
        public string RegId
        {
            get
            {
                return _regId;
            }
            set
            {
                _regId = value;
            }
        }
        [DataMember]
        public DateTime? RegTime
        {
            get
            {
                return _regTime;
            }
            set
            {
                _regTime = value;
            }
        }
        [DataMember]
        public string ModId
        {
            get
            {
                return _modId;
            }
            set
            {
                _modId = value;
            }
        }
        [DataMember]
        public DateTime? ModTime
        {
            get
            {
                return _modeTime;
            }
            set
            {
                _modeTime = value;
            }
        }
        
        #endregion
    }
}