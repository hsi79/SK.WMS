using System;
using System.Collections.Generic;
using NEXCORE.Common;
using System.Windows.Forms;
using NEXCORE.Interfaces;
using System.Collections.Specialized;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Utility;

namespace SK.WMS.Launcher
{
    class ApplicationStarter : ApplicationBase
    {

        #region Member Property
        private IUserInterface _UIInterface;
        private bool bExit = false;
        #endregion

        public IUserInterface FormInterface
        {
            get
            {
                if (_UIInterface == null)
                    _UIInterface = new UIInterface();
                return this._UIInterface;
            }
            set
            {
                this._UIInterface = value;
            }
        }


        public override void ShowMainForm()
        {
            try
            {
                if (bExit)
                {
                    Application.Exit();
                }
                else
                {
                    MainForm mForm = new MainForm(this.FormInterface);
                    Application.Run(mForm);
                }
            }
            catch (Exception ex)
            {
                NEXCORE.Utility.UtilityHelper.WriteLog(ex.Message, "UI");
                CommonHelper.CallMsgPopUp("알림", "화면 실행중 오류가 발생하였습니다!!!", "", "1", ex.Message);
            }
        }

        public override bool ShowLoginForm()
        {

            LoginForm login = new LoginForm();
            login.FormInterface = this.FormInterface;

            bool loginSuccess = false;
            int loginTryCnt = 0;
            int loginCnt = 5;// Skcc.Configuration.SkccFxConfigManager.TryGetInt32("LoginCount");
            while (loginSuccess == false)
            {
                DialogResult dialog = login.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    loginSuccess = true;
                }
                else if (dialog == DialogResult.No)
                {
                    
                    break;
                }
                else if (dialog == DialogResult.Cancel)
                {
                    continue;
                }
                else if (dialog == DialogResult.Ignore)
                {
                    loginSuccess = true;
                    bExit = true;
                }
                else // DialogResult.Abort인 경우
                {
                    if (++loginTryCnt >= loginCnt)
                        break;
                }
            };
            return loginSuccess;
        }

        public override void GetQueryStringParameters()
        {
            NameValueCollection nameValueTable = new NameValueCollection();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                try
                {
                    string queryString = ApplicationDeployment.CurrentDeployment.ActivationUri.Query;
                    string[] cols = queryString.Split('?')[1].Split('&');

                    foreach (string s in cols)
                    {
                        string[] strs = s.Split('=');
                        nameValueTable.Add(strs[0], strs[1]);
                    }

                    string userId = nameValueTable.Get("UserId");
                    NEXCORE.Common.Data.User user = CommonManager.GetUser(userId);
                    user.Password1 = UtilityHelper.Decrypt(user.Password);
                    FormInterface.SetCurrentUser(user);
                    WMSVar.LoginPath = false;
                }
                catch 
                {
                    if (ShowLoginForm())
                    {
                        WMSVar.LoginPath = true;
                        ShowFlashForm();
                        ShowMainForm();
                    }
                }
            }


        }


    }
}