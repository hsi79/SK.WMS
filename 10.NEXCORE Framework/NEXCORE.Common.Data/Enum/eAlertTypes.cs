using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
    public enum eAlertTypes
    {
        None,
        Question,
        Error,
        Inforamtion,
        Stop,
        Warning,
        YesNo
    }

    public enum Theme
    {
        Theme1,
        Theme2,
        Theme3
    }

   [DataContract]
    public enum eMenuTypeList
    {
        [EnumMember]
        Depth1Menu = 1,
        [EnumMember]
        Depth2Menu = 2,
        [EnumMember]
        Depth3Menu = 3,
        [EnumMember]
        Depth4Menu = 4,
        [EnumMember]
        None = 5
    }
}
 