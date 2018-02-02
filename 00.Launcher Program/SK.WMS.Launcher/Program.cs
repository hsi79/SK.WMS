using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Principal;
using System.Deployment.Application;
//using Microsoft.IdentityModel.Claims;



namespace SK.WMS.Launcher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsAdministrator() == false && ApplicationDeployment.IsNetworkDeployed == true)
            {
                ProcessStartInfo procInfo = new ProcessStartInfo();
                procInfo.UseShellExecute = true;
                procInfo.FileName = Application.ExecutablePath;
                procInfo.WorkingDirectory = Environment.CurrentDirectory;
                procInfo.Verb = "runas";
                if (ApplicationDeployment.IsNetworkDeployed == true)
                {
                    if (ApplicationDeployment.IsNetworkDeployed)
                        if (ApplicationDeployment.CurrentDeployment.ActivationUri != null)
                            
                    procInfo.Arguments = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                }
                Process.Start(procInfo);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            


            ApplicationStarter appStarter = new ApplicationStarter();
            appStarter.Start();
            
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (null != identity)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return false;
        }
    }
}