using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
    [DataContract]
    public class ButtonAuthority
    {
        private string _PgmId;
        private string _c;
        private string _r;
        private string _d;
        private string _e;
        private string _p;

        public ButtonAuthority(Hashtable property)
        {
            _PgmId = property["PGM_ID"] is DBNull ? null : (string)property["PGM_ID"];
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
    }
}
