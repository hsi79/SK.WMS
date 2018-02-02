using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;

namespace NEXCORE.Common
{
    public class ApplicationBase
    {
        public virtual void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationInitialize();


            try
            {
                string sQurey = string.Empty;
                if (ApplicationDeployment.IsNetworkDeployed)
                if (ApplicationDeployment.CurrentDeployment.ActivationUri != null)
                    sQurey = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;



                if (ApplicationDeployment.IsNetworkDeployed == true && sQurey != "")
                {
                    string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;

                    string[] cols = queryString.Split('?')[1].Split('&');

                    GetQueryStringParameters();
                    ShowMainForm();

                }
                else
                {
                    if (ShowLoginForm())
                    {
                        ShowFlashForm();
                        ShowMainForm();
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "error");
            }
        }

        public virtual void ApplicationInitialize()
        { }

        public virtual void ShowFlashForm()
        { }

        public virtual bool ShowLoginForm()
        {
            return false;
        }

        public virtual void ShowMainForm()
        { }
        public virtual void GetQueryStringParameters()
        { }

    }
}