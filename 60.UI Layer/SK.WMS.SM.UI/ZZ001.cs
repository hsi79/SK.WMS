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

namespace SK.WMS.SM.UI
{
    public partial class ZZ001 : SKDialogBase
    {

        public ZZ001()
        {

            InitializeComponent();

            
        }

       
        private void btnComfirm_Click(object sender, EventArgs e)
        {
            string msg = null;
            string bpwd = null;
            string npwd = null;
            string cpwd = null;


            bpwd = beforepwd.Text.Trim();
            npwd = newpwd.Text.Trim();
            cpwd = pwdconfirm.Text.Trim();

            if (bpwd.Length == 0)
            {
                beforepwd.Focus();
                msg = "기존 비밀번호를 입력하세요";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;                
            }
            else if (npwd.Length < 4)
            {
                newpwd.Focus();
                msg = "변경할 비밀번호는 (4~8) 자리를 입력하세요";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;
            }

            if (bpwd != FormInterface.GetCurrentUser().Password1)
            {
                beforepwd.Focus();
                msg = "기존 비밀번호가 일치하지 않습니다.";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;
            }
            if (npwd != cpwd)
            {
                pwdconfirm.Focus();
                msg = "변경할 비밀번호를 다시한번 입력하세요";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;
            }

            if (bpwd == npwd)
            {
                newpwd.Focus();
                msg = "변경할 비밀번호가 기존비밀번호와 같습니다. 다시한번 입력하세요";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;

            bool ret = CommonManager.ChangePassword(FormInterface.GetCurrentUser().UserId, NEXCORE.Utility.UtilityHelper.Encrypt(npwd));
            if (ret)
            {
                User user = FormInterface.GetCurrentUser();
                user.Password1 = npwd;
                msg = "정상적으로 변경되었습니다.";
                MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                msg = "비밀번호 변경중 오류가 발생하였습니다.관리자에게 연락바랍니다.";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;
                return;
            }
                Cursor.Current = Cursors.Default;
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            

        }

        private void ZZ001_Load(object sender, EventArgs e)
        {
            beforepwd.Focus();
        }





    }
}