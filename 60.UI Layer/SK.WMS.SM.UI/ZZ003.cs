using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;
using NEXCORE.Utility.GlobalVariable;

namespace SK.WMS.SM.UI
{
    public partial class ZZ003 : SKDialogBase
    {
        public ZZ003()
        {

            InitializeComponent();

            
        }

       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = null;
            string userId = null;
            string password = null;


            Cursor.Current = Cursors.WaitCursor;
            userId = txtid.Text.Trim();
            password = txtpwd.Text.Trim();
            if (userId.Length == 0)
            {
                txtid.Focus();
                msg = "아이디를 입력하세요";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;                
            }
            else if (password.Length == 0)
            {
                txtpwd.Focus();
                msg = "비밀번호를 입력하세요";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;
            }
            else if (userId.Length > 0 && password.Length > 0)
            {
                NEXCORE.Interfaces.LOGIN_RESULT_CODE retCode = CommonManager.Login(userId, password);
                if (NEXCORE.Interfaces.LOGIN_RESULT_CODE.SUCCESS == retCode)
                {
                    NEXCORE.Common.Data.User user = CommonManager.GetUser(userId);
                    user.Password1 = password;
                    FormInterface.SetCurrentUser(user);
                    DialogResult = DialogResult.Retry;
                }
                else
                {
                    msg = "아이디 혹은 비밀번호가 맞지 않습니다.";
                    MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                    return;
                }
                Cursor.Current = Cursors.Default;
            }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            

        }

        private void ZZ003_Load(object sender, EventArgs e)
        {
            txtid.Focus();
        }





    }
}