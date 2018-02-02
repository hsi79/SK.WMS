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
    public partial class ButtonMgmt : SKUserControlBase
    {

        public ButtonMgmt()
        {
            InitializeComponent();


        }

        private void ButtonMgmt_Load(object sender, EventArgs e)
        {
           

        }

        public override void InitControls()
        {

            List<Program> programList = CommonManager.GetProgramList();
            Program item = new Program();
            item.PgmId = "";
            item.PgmName = "선택";
            programList.Insert(0, item);
            cmbProgram.MismatchValueErrorText = "선택한 '{0}' 프로그램이 아닙니다.";
            cmbProgram.DisplayMember = "PgmName";
            cmbProgram.ValueMember = "PgmId";

            cmbProgram.DataSource = programList;

            cmbProgram.SelectedValue = "";
        }


        public override void InitializeGrid()
        {
            GridHelper.DefaultGrid(fxButton,false);
            GridHelper.InitColumn(fxButton, "PgmId", "프로그램", 150);
            GridHelper.InitColumn(fxButton, "ButtonID", "버튼 ID", 80);
            GridHelper.InitColumn(fxButton, "ButtonName", "버튼 명", 100);
            GridHelper.InitColumn(fxButton, "ButtonDescription", "버튼 상세", 120);

        }

        public override void InitializeLocalization()
        {
            base.InitializeLocalization();
        }


        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(CommonManager.GetMessage("M10005"), "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
                ManagedButton button = new ManagedButton();

                button.PgmId = cmbProgram.SelectedValue.ToString();
                button.ButtonID = txtButtonID.Text;
                button.ButtonName = txtButtonNm.Text;
                button.ButtonDescription = txtButtonDesc.Text;
                button.RegId = FormInterface.GetCurrentUser().UserId;
                button.ModId = FormInterface.GetCurrentUser().UserId;
                CommonManager.DeleteButton(button);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10002"));
                InitClear();
                OnSearch();
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
            txtButtonID.Enabled = true;
            cmbProgram.Enabled = true;

            InitClear();
        }

        private void InitClear()
        {
            txtButtonDesc.Text = "";
            txtButtonID.Text = "";
            txtButtonNm.Text = "";
            cmbProgram.Text = "";
            cmbProgram.SelectedValue = "";
        }

        private void commonButton1_OnPrintClick(object sender, EventArgs e)
        {

        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                ManagedButton button = new ManagedButton();

                button.PgmId = cmbProgram.SelectedValue.ToString();
                button.ButtonID = txtButtonID.Text;
                button.ButtonName = txtButtonNm.Text;
                button.ButtonDescription = txtButtonDesc.Text;
                button.RegId = FormInterface.GetCurrentUser().UserId;
                button.ModId  = FormInterface.GetCurrentUser().UserId;


                if (txtButtonID.Enabled)
                {
                    if (!CheckDup(cmbProgram.SelectedValue.ToString() + "," + txtButtonID.Text)) return;
                    CommonManager.AddButton(button);
                }
                else
                {
                    CommonManager.UpdateButton(button);
                }

                txtButtonID.Enabled = false;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
                OnSearch();
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
            OnSearch();



        }

        private void OnSearch()
        {
            try
            {
                DataSet ds = UtilityHelper.ToDataSet(CommonManager.GetButtonListAll());

                GridHelper.DataBind(fxButton, ds);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader1.Text = "조회 건수 : " + (fxButton.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }

        private void fxButton_RowColChange(object sender, EventArgs e)
        {
            RowColchange();
        }

        private void RowColchange()
        {


            int current = (fxButton.Row > 0) ? fxButton.Rows[fxButton.Row].DataIndex : -1;

            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;

            txtButtonID.Text = GridHelper.GetText(fxButton, current, "ButtonId");
            txtButtonNm.Text = GridHelper.GetText(fxButton, current, "ButtonName");
            txtButtonDesc.Text = GridHelper.GetText(fxButton, current, "ButtonDescription");
            cmbProgram.SelectedValue = GridHelper.GetText(fxButton, current, "PgmId");

            txtButtonID.Enabled = false;
            cmbProgram.Enabled = false;

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
 
                if (CommonManager.DupCheck("BUTTON", value) > 0)
                {
                    MessageBox.Show(this, string.Format(CommonManager.GetMessage("M10008"),value),"오류",MessageBoxButtons.OK); //메세지 등록
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
                if (cmbProgram.Text.Trim().Length == 0)
                {
                    cmbProgram.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "프로그램");
                    returnValue = false;
                }
                else
                {
                    cmbProgram.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtButtonID.Text.Trim().Length == 0)
                {
                    txtButtonID.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "버튼 ID");
                    returnValue = false;
                }
                else
                {
                    txtButtonID.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtButtonNm.Text.Trim().Length == 0)
                {
                    txtButtonNm.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "버튼명");
                    returnValue = false;
                }
                else
                {
                    txtButtonNm.ErrorText = string.Empty;
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
