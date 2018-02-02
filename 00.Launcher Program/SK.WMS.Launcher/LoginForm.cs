using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

using System.Diagnostics;
using NEXCORE.Common;
using Skcc.Windows.Forms;
using System.Security.Cryptography;
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Common.Data;

namespace SK.WMS.Launcher
{
    public partial class LoginForm : SKFormBase
    {
        public string UserId { get; set; }
        private Microsoft.Win32.RegistryKey key ;
        public LoginForm()
        {
            base.RequireAuthority = false;
            base.RequireAuthentication = false;
            InitializeComponent();

            
        }

        public void SetUserName(string str)
        {
            this.txtUserID.Text = str;
        }

        public void SetPassword(string str)
        {
            this.txtPassword.Text = str;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string msg = null;
            string userId = null;
            string password = null;
            Cursor.Current = Cursors.WaitCursor;
            userId = txtUserID.Text.Trim();
            password = txtPassword.Text.Trim();

            if (userId.Length == 0)
            {
                txtUserID.Focus();
                msg = "Enter ID";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Cancel;                
            }
            else if (password.Length == 0)
            {
                txtPassword.Focus();
                msg = "Enter password";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Cancel;
            }
            else if (userId.Length > 0 && password.Length > 0)
            {

                NEXCORE.Interfaces.LOGIN_RESULT_CODE retCode = CommonManager.Login(userId, password);




                if (NEXCORE.Interfaces.LOGIN_RESULT_CODE.SUCCESS == retCode)
                {
                    NEXCORE.Common.Data.User user = CommonManager.GetUser(userId);
                    user.Password1 = password;
                    FormInterface.SetCurrentUser(user);

                    string regKeyPath = @"Software\SK.WMS\"; //레지스트리 키 경로
                    key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regKeyPath); //레지스트리 키 등록
                    key.SetValue("USER_ID", userId); //값등록 : 서버

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this, "아이디 혹은 비밀번호가 맞지 않습니다.", "Error Message", MessageBoxButtons.OK);
                    DialogResult = DialogResult.Cancel;
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\SK.WMS", true);
            if (key != null)
            {
                try
                {
                    string id = key.GetValue("USER_ID").ToString();         //'값등록 : 서버
                    if (id.Length > 0)
                    {
                        this.txtUserID.Text = id;
                        this.txtPassword.TabIndex = 0;
                    }

                    string strfont = key.GetValue("FONT").ToString();
                    string strfontname = key.GetValue("FONTNAME").ToString();
                    if (strfont.Length > 0)
                    {
                        WMSVar.FT = strfont;
                        WMSVar.FTNAME = strfontname;
                    }
                    string strmsg = key.GetValue("MSG").ToString();

                    if (strmsg.Length > 0)
                    {
                        WMSVar.MSG = strmsg;
                    }
                    string strth = key.GetValue("TH").ToString();


                    if (strth.Length > 0)
                    {
                        WMSVar.TH = strth;
                    }
                }
                catch { }
            }
            else
            {
                txtUserID.Focus();
                SetTabIndex();
            }

        }
        private void SetTabIndex()
        {
            if (txtUserID.Text.Length <= 0)
            {
                txtUserID.TabIndex = 0;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }



    }
}