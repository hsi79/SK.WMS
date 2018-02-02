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
using NEXCORE.Utility;
using C1.Win.C1FlexGrid;


namespace SK.WMS.SM.UI
{
    /// <summary>
    /// 프로그램명 ID : PgmMgmt.cs
    /// 프로그램명    : 프로그램관리
    /// 설명          : 개발된 프로그램을 등록하는 관리하는 화면
    /// 작성자       : Jeon
    /// 최조작성일    : 2012.7.3
    /// 변경일
    /// </summary>
    public partial class PgmMgmt : SKUserControlBase
    {

        public CellStyle cschk = null;
        public CellStyle csunchk = null;
        public PgmMgmt()
        {
            InitializeComponent();



        }

        private void PgmMgmt_Load(object sender, EventArgs e)
        {

             
        }

        public override void InitControls()
        {
            base.InitControls();


        }
        public override void InitializeGrid()
        {
            base.InitializeGrid();
            GridHelper.DefaultGrid(fxPgmList,false);
            GridHelper.InitColumn(fxPgmList, "PgmId", "프로그램ID", 80, false, true,false,C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmAssembly", "DLL 명", 120, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmClass", "FORM 명", 100, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmName", "프로그램 명", 120, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmType", "프로그램 타입", 80, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "AuthYN", "권한여부", 60, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmDescription", "상세 설명", 100, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);

        }
        public override void InitializeLocalization()
        {
            base.InitializeLocalization();
        }










        #region 그리드 이벤트



        private void RowColchange()
        {
            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (fxPgmList.Row > 0) ? fxPgmList.Rows[fxPgmList.Row].DataIndex : -1;
            int col = fxPgmList.Col;


            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;


            txtAssembly.Text = GridHelper.GetText(fxPgmList, current, "PgmAssembly");
            txtClass.Text = GridHelper.GetText(fxPgmList, current, "PgmClass");
            cmbType.Text = GridHelper.GetText(fxPgmList, current, "PgmType");
            txtProgramID.Text = GridHelper.GetText(fxPgmList, current, "PgmId");
            txtProgramNm.Text = GridHelper.GetText(fxPgmList, current, "PgmName");
            txtProgramDesc.Text = GridHelper.GetText(fxPgmList, current, "PgmDescription");
            chkAuth.Checked = GridHelper.GetText(fxPgmList, current, "AuthYN") == "Y" ? true : false;
            txtProgramID.Enabled = false;

        }
        private void fxPgmList_RowColChange(object sender, EventArgs e)
        {
            RowColchange();
        }

        #endregion

        #region 버튼클릭 이벤트
        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {


                    return;

                }

                Program program = new Program();
                program.PgmId = txtProgramID.Text;
                program.PgmName = txtProgramNm.Text;
                program.PgmAssembly = txtAssembly.Text.ToUpper();
                program.PgmClass = txtClass.Text;
                program.PgmDescription = txtProgramDesc.Text;
                program.AuthYN = chkAuth.Checked == true ? "Y" : "N";
                program.PgmType = cmbType.Text;
                CommonManager.DeleteProgram(program);
                CommonManager.ReloadProgram();
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10002"));
            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }
            finally
            {

            }
        }

        private void commonButton1_OnNewClick(object sender, EventArgs e)
        {
            txtProgramID.Enabled = true;
            txtProgramID.Text = "";
            txtProgramNm.Text = "";
            txtAssembly.Text = "";
            txtClass.Text = "";
            txtProgramDesc.Text = "";

        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                Program program = new Program();

                program.PgmId = txtProgramID.Text;
                program.PgmName = txtProgramNm.Text;
                program.PgmAssembly = txtAssembly.Text.ToUpper();
                program.PgmClass = txtClass.Text;
                program.PgmDescription = txtProgramDesc.Text;
                program.AuthYN = chkAuth.Checked == true ? "Y" : "N";
                program.PgmType = cmbType.Text;

                if (txtProgramID.Enabled)
                {
                    if (!CheckDup(program.PgmId)) return;
                    CommonManager.AddProgram(program);
                }
                else
                {
                    CommonManager.UpdateProgram(program);
                }

                CommonManager.ReloadProgram();
                txtProgramID.Enabled = false;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }


        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {


                GridHelper.DataBind(fxPgmList, UtilityHelper.ToDataSet(CommonManager.GetProgramList(searchProgram.Text)));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader1.Text = "조회 건수 : " + (fxPgmList.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }

        #endregion

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
                if (CommonManager.DupCheck("PGM", value) > 0)
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

                if (txtProgramID.Text.Trim().Length == 0)
                {
                    txtProgramID.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "프로그램 ID");
                    returnValue = false;
                }
                else
                {
                    txtProgramID.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtProgramNm.Text.Trim().Length == 0)
                {
                    txtProgramNm.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "프로그램 명");
                    returnValue = false;
                }
                else
                {
                    txtProgramNm.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtAssembly.Text.Trim().Length == 0)
                {
                    txtAssembly.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "Assembly 명");
                    returnValue = false;
                }
                else
                {
                    txtAssembly.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtClass.Text.Trim().Length == 0)
                {
                    txtClass.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "Class 명");
                    returnValue = false;
                }
                else
                {
                    txtClass.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (cmbType.Text.Trim().Length == 0)
                {
                    cmbType.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "Type 명");
                    returnValue = false;
                }
                else
                {
                    cmbType.ErrorText = string.Empty;
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

        private void skSaveButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("123");
        }
    }
}
