using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class ManagedButton
    {
        private string _buttonid;
        private string _buttonname;
        private string _buttondescription;
        private string _RegId;
        private DateTime? _RegTime;
        private string _ModId;
        private DateTime? _ModTime;
        private string _pgmid;
        [DataMember]
        public string ButtonID
        {
            get
            {
                return _buttonid;
            }
            set
            {
                _buttonid = value;
            }
        }
        [DataMember]
        public string ButtonName
        {
            get
            {
                return _buttonname;
            }
            set
            {
                _buttonname = value;
            }
        }
        [DataMember]
        public string ButtonDescription
        {
            get
            {
                return _buttondescription;
            }
            set
            {
                _buttondescription = value;
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
        [DataMember]
        public string PgmId
        {
            get
            {
                return _pgmid;
            }
            set
            {
                _pgmid = value;
            }
        }

        public ManagedButton(Hashtable htBtnAuth)
        {
            _pgmid = (string)htBtnAuth["PGM_ID"];
            _buttonid = (string)htBtnAuth["BUTTON_ID"];
            _buttonname = (string)htBtnAuth["BUTTON_NM"];
            _buttondescription = (string)htBtnAuth["BUTTON_DESC"];
            _RegId = (string)htBtnAuth["REG_ID"];
            _RegTime = SKConvert.GetDateTime(htBtnAuth["REG_TIME"]);
            _ModId = (string)htBtnAuth["MOD_ID"];
            _ModTime = SKConvert.GetDateTime(htBtnAuth["MOD_TIME"]);
        }

        public ManagedButton()
        {
        }

    }
}
