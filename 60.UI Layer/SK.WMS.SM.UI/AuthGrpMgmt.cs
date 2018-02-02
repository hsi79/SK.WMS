using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Utility;


namespace SK.WMS.SM.UI
{
    public partial class AuthGrpMgmt : SKUserControlBase
    {

        public AuthGrpMgmt()
        {
            InitializeComponent();


        }

        private void AuthGrpMgmt_Load(object sender, EventArgs e)
        {
        }

        public override void InitControls()
        {
            base.InitControls();

        }


        public override void InitializeGrid()
        {
            GridHelper.DefaultGrid(fxAuth, false);
            GridHelper.InitColumn(fxAuth, "AuthId", "권한그룹 ID", 120);
            GridHelper.InitColumn(fxAuth, "AuthName", "권한그룹 명", 100);
            GridHelper.InitColumn(fxAuth, "AuthDescription", "권한그룹 상세", 120);

        }

        public override void InitializeLocalization()
        {
            base.InitializeLocalization();
        }


        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                if (MessageBox.Show(CommonManager.GetMessage("M10005"), "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("ROLE_ID", txtAuthID.Text);
                data.Hashtable.Add("ROLE_NM", txtAuthNm.Text);
                data.Hashtable.Add("ROLE_DESC", txtAuthDesc.Text);
                data.Hashtable.Add("USE_YN", txtAuthDesc.Text);
                data.Hashtable.Add("REG_ID", FormInterface.GetCurrentUser().LoginId);
                CommonManager.DeleteAuth(data);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10002"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);

            }

        }

        private void commonButton1_OnExcelClick(object sender, EventArgs e)
        {

        }

        private void commonButton1_OnNewClick(object sender, EventArgs e)
        {
            txtAuthID.Enabled = true;

            txtAuthDesc.Text = "";
            txtAuthID.Text = "";
            txtAuthNm.Text = "";

        }

        private void commonButton1_OnPrintClick(object sender, EventArgs e)
        {

        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("ROLE_ID", txtAuthID.Text);
                data.Hashtable.Add("ROLE_NM", txtAuthNm.Text);
                data.Hashtable.Add("ROLE_DESC", txtAuthDesc.Text);
                data.Hashtable.Add("USE_YN", "Y");
                data.Hashtable.Add("REG_ID", FormInterface.GetCurrentUser().LoginId);

                if (txtAuthID.Enabled)
                {
                    if (!CheckDup(txtAuthID.Text)) return;
                    CommonManager.AddAuth(data);
                }
                else
                {
                    CommonManager.UpdateAuth(data);
                }

                txtAuthID.Enabled = false;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }
            finally
            {

            }

        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {


                GridHelper.DataBind(fxAuth, UtilityHelper.ToDataSet(CommonManager.GetAuthorityList()));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader1.Text = "조회 건수 : " + (fxAuth.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }



        }

        private void fxAuth_RowColChange(object sender, EventArgs e)
        {
            RowColchange();
        }

        private void RowColchange()
        {


            int current = (fxAuth.Row > 0) ? fxAuth.Rows[fxAuth.Row].DataIndex : -1;

            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;

            txtAuthID.Text = GridHelper.GetText(fxAuth, current, "AuthId");
            txtAuthNm.Text = GridHelper.GetText(fxAuth, current, "AuthName");
            txtAuthDesc.Text = GridHelper.GetText(fxAuth, current, "AuthDescription");

            txtAuthID.Enabled = false;

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

                if (CommonManager.DupCheck("ROLE", value) > 0)
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
                if (txtAuthID.Text.Trim().Length == 0)
                {
                    txtAuthID.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "권한그룹 ID");
                    returnValue = false;
                }
                else
                {
                    txtAuthID.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtAuthNm.Text.Trim().Length == 0)
                {
                    txtAuthNm.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "권한그룹명");
                    returnValue = false;
                }
                else
                {
                    txtAuthNm.ErrorText = string.Empty;
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

        private void inputLabel7_DoubleClick(object sender, EventArgs e)
        {

        }


    }
}
