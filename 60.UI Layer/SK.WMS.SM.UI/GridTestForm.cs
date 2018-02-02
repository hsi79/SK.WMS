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
    public partial class GridTestForm : SKUserControlBase
    {

        public CellStyle cschk = null;
        public CellStyle csunchk = null;
        public GridTestForm()
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
            GridHelper.DefaultGrid(fxPgmList);
            GridHelper.InitColumnCheckBox(fxPgmList, "Chk", "", 40, false, true, true);
            GridHelper.InitColumn(fxPgmList, "PgmId", "프로그램ID", 80, false, true,false,C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmAssembly", "DLL 명", 120, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmClass", "FORM 명", 100, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmName", "프로그램 명", 120, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmType", "프로그램 타입", 80, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "AuthYN", "권한여부", 60, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            GridHelper.InitColumn(fxPgmList, "PgmDescription", "상세 설명", 100, false, true, false, C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter);
            

            cschk = fxPgmList.Styles.Add("chkcolor");
            cschk.BackColor = Color.MistyRose;
            csunchk = fxPgmList.Styles.Add("unchkcolor");
            csunchk.BackColor = Color.White;

            fxPgmList.HighLight = HighLightEnum.Never;
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

                Program program = new Program();

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
            GridHelper.AddRow(fxPgmList);
            GridHelper.SetText(fxPgmList, fxPgmList.Rows.Count - 1, 1, "True");
        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
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
            finally
            {

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

        private void fxPgmList_AfterEdit(object sender, RowColEventArgs e)
        {
            int col = fxPgmList.Col;
            int row = fxPgmList.Row;

            if (row < 0) return;

            if (col == 1)
            {
                if (GridHelper.GetText(fxPgmList, row, 1) == "True")
                {
                    GridHelper.required(fxPgmList, row, true, 2, 3, 4);
                    GridHelper.allowediting(fxPgmList, row,1, true);
                    GridHelper.setrowbackcolor(fxPgmList, row, true);



                }
                else
                {
                    GridHelper.required(fxPgmList, row, false, 2, 3, 4);
                    GridHelper.allowediting(fxPgmList, row,1, false);
                    GridHelper.setrowbackcolor(fxPgmList, row, false);

                }
            }
            else
            {
                GridHelper.allowediting(fxPgmList, row,1, false);

            }
        }

        private void fxPgmList_BeforeEdit(object sender, RowColEventArgs e)
        {
            int col = fxPgmList.Col;
            int row = fxPgmList.Row;
            if (row < 0) return;
            if (col != 1) GridHelper.allowediting(fxPgmList, row,1, false);
        }

        private void fxPgmList_Click(object sender, EventArgs e)
        {
            int col = fxPgmList.Col;
            int row = fxPgmList.Row;

            if (row < 0) return;
            if (col != 1) GridHelper.allowediting(fxPgmList, row, 1,false);
        }
    }
}
