using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public delegate void FormActiveDeactive(object sender, NEXCORE.Common.Data.NEXCOREData e);

    public delegate void BroadCast(object sender, BroadCastEventArgs e);

    public delegate void FormClose(object sender, NEXCOREData param);

    public delegate void PreviewKeyDown(object sender, System.Windows.Input.KeyboardEventArgs e);

    public delegate void MenuClick(object sender, EventArgs e);

    public delegate void NavigatorClick(object sender, EventArgs e);

    public delegate void SendMessage(object sender, SendMessageEvetArgs e);

    public delegate void ReceiveMessage(object sender, NEXCORE.Common.Data.NEXCOREData e);

    public delegate void ToolBarEvent(object sender, ToolBarButtonTypes toolBarType);

    public delegate void ThemeChangedHandler(object sender, Theme NewTheme);

 
}
