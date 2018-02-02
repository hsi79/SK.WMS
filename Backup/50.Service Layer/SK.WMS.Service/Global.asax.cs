using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace NEXCORE.Service
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            string msg = string.Format("Web server is started at {0}", DateTime.Now.ToString());
            NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Start);

            NEXCORE.Components.ComponentManager.ComponentManager compMgr = NEXCORE.Components.ComponentManager.AppDomainMgr.GetComponentMgr();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            string msg = string.Format("A session in the web server is started : Session ID : {0}, User Host Address : {1}",
                                       Session.SessionID, Request.UserHostAddress);
            NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Start);
        }

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{

        //}

        protected void Application_Error(object sender, EventArgs e)
        {
            NEXCORE.Utility.UtilityHelper.WriteLog(string.Format("Application_Error : {0}", DateTime.Now.ToString()),
                                                   NEXCORE.Utility.UtilityHelper.eLogCategory.Framework,
                                                   System.Diagnostics.TraceEventType.Error);
        }

        protected void Session_End(object sender, EventArgs e)
        {
            string msg = string.Format("A session in the web server is stopped : Session ID : {0}, User Host Address : {1}",
                                       Session.SessionID, Request.UserHostAddress);
            NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Stop);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            string msg = string.Format("Web Server is stopped at {0}", DateTime.Now.ToString());
            NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, System.Diagnostics.TraceEventType.Stop);
        }
    }
}