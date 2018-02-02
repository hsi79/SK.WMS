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
    public partial class ZZ002 : SKDialogBase
    {

        public ZZ002()
        {

            InitializeComponent();

            
        }

       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = null;
            string tel = null;
            string mobile = null;
            string email = null;


            Cursor.Current = Cursors.WaitCursor;
            tel = txttel.Text.Trim();
            mobile = txtmobile.Text.Trim();
            email = txtemail.Text.Trim();
            if (tel.Length == 0 && mobile.Length == 0 && email.Length == 0)
            {
                msg = "사용자정보가 입력되지 않았습니다.";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;

            }
            NEXCOREData data = new NEXCOREData();
            data.Hashtable.Add("USER_ID", FormInterface.GetCurrentUser().UserId);
            data.Hashtable.Add("TEL_WORK",tel);
            data.Hashtable.Add("TEL_MOBILE", mobile);
            data.Hashtable.Add("EMAIL", email);

            bool ret = CommonManager.EtcUpdateUser(data);

            if (ret)
            {
                User user = FormInterface.GetCurrentUser();
                msg = "정상적으로 변경되었습니다.";
                MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
                DialogResult = DialogResult.OK;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                msg = "사용자정보 변경중 오류가 발생하였습니다.관리자에게 연락바랍니다.";
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

        private void ZZ002_Load(object sender, EventArgs e)
        {
            txttel.Focus();
            txttel.Text = FormInterface.GetCurrentUser().Tel;
            txtmobile.Text = FormInterface.GetCurrentUser().Mobile;
            txtemail.Text = FormInterface.GetCurrentUser().Email;
        }





    }
}