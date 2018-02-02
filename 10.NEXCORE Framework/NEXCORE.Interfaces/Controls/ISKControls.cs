using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NEXCORE.Common.Data;
using System.ComponentModel;

namespace NEXCORE.Interfaces
{
    public interface ISKControls
    {


        bool IsNull(ref NEXCOREData param);

        eSKControlType GetTypeName();


    }
}
