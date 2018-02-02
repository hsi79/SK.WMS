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
    public partial class ZZ008 : SKDialogBase
    {
        private Microsoft.Win32.RegistryKey key;
        public ZZ008()
        {

            InitializeComponent();

            
        }


        private void btnComfirm_Click(object sender, EventArgs e)
        {

           string font = string.Empty;
           string msg = string.Empty;
           string theme = string.Empty;

           if (cmbFont.Text == "")
           {
               MessageBox.Show("폰트를 선택하세요.");
               return;
           }
           if (cmbFont.Text == "돋움체")
           {
               font = "DotumChe";
           }
           else
           {
               font = "Malgun Gothic";
           }

           if (rdoControl.Checked)
           {
               msg = "Control";
           }
           else
           {
               msg = "White";
           }

            string regKeyPath = @"Software\SK.WMS\"; //레지스트리 키 경로
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(regKeyPath); //레지스트리 키 등록
            key.SetValue("FONT", font); //값등록 : 서버
            key.SetValue("FONTNAME", cmbFont.Text); //값등록 : 서버
            key.SetValue("MSG", msg); //값등록 : 서버
            key.SetValue("TH", theme); //값등록 : 서버


            MessageBox.Show("다음 로그인부터 변경된 폰트 및 메세지 배경색이 적용이 됩니다.");

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            

        }

        private void ZZ008_Load(object sender, EventArgs e)
        {
            cmbFont.Text = WMSVar.FTNAME;
            if (WMSVar.MSG == "Control")
            {
                rdoControl.Checked = true;
            }
            else
            {
                rdoWhite.Checked = true;
            }

 
        }







    }
}