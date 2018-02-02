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
    public partial class ZZ005 : SKDialogBase
    {
            NEXCORE.Common.Data.Program pgm = new Program();

        public ZZ005()
        {

            InitializeComponent();

            
        }

       
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = null;
            string myMenu = null;

            
            Cursor.Current = Cursors.WaitCursor;
            myMenu = txtMyMenu.Text.Trim();
            if (myMenu.Length == 0 )
            {
                msg = "나만의 메뉴명이 입력되지 않았습니다.";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                Cursor.Current = Cursors.Default;

            }
            if (!CheckDup(FormInterface.GetCurrentUser().UserId + "," + pgm.PgmId)) return;
            NEXCORE.Common.Data.Menu menu = new NEXCORE.Common.Data.Menu();
            menu.UserId = FormInterface.GetCurrentUser().UserId;
            menu.PgmId = pgm.PgmId;
            menu.MenuKorea = myMenu;
            menu.SORT = 0;

           bool ret =  CommonManager.AddMyMenu(menu);

            if (ret)
            {
                User user = FormInterface.GetCurrentUser();
                msg = "정상적으로 추가되었습니다.";
                MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
                DialogResult = DialogResult.Retry;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                msg = "즐겨찾기 추가중 오류가 발생하였습니다.관리자에게 연락바랍니다.";
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

        private void ZZ005_Load(object sender, EventArgs e)
        {
            string msg = null;

            pgm = (Program)this.Tag;
            txtMyMenu.Focus();

            txtMyMenu.Text = pgm.PgmName;

            if (pgm.PgmId == null)
            {

                msg = "현재 선택된 메뉴가 없습니다.";
                MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;

            }
        }

        #region Validation Check
        /// <summary>
        /// 프로그램ID 중복 체크
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckDup(string value)
        {
            bool returnValue = true;

            try
            {

                if (CommonManager.DupCheck("MYMENU", value) > 0)
                {
                    MessageBox.Show(this, string.Format(CommonManager.GetMessage("M10008"), value), "오류", MessageBoxButtons.OK); //메세지 등록
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                returnValue = false;
            }

            return returnValue;
        }
        /// <summary>
        /// 입력값 체크
        /// </summary>
        /// <returns></returns>
        private bool CheckValue()
        {
            bool returnValue = true;

            try
            {
                
                
                if (txtMyMenu.Text.Trim().Length == 0)
                {
                    MessageBox.Show( string.Format(CommonManager.GetMessage("M10009"), "나의 메뉴"));
                    returnValue = false;
                }
                else
                {
                    
                    returnValue = true;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                returnValue = false;
            }

            return returnValue;
        }
        #endregion



    }
}