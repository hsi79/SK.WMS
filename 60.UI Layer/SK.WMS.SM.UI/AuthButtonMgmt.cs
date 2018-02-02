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
using C1.Win.C1FlexGrid;


namespace SK.WMS.SM.UI
{
    public partial class AuthButtonMgmt : SKUserControlBase
    {

        public AuthButtonMgmt()
        {
            InitializeComponent();

        }
        private void AuthButtonMgmt_Load(object sender, EventArgs e)
        {
        }
        public override void InitControls()
        {
            List<Authority> authList = CommonManager.GetAuthorityList();

            cmbAuth.MismatchValueErrorText = "선택한 '{0}' 역할이 아닙니다.";
            cmbAuth.DisplayMember = "AuthName";
            cmbAuth.ValueMember = "AuthId";

            cmbAuth.DataSource = authList;

            cmbAuth.SelectedValue = "";
        }
        public override void InitializeGrid()
        {
            GridHelper.DefaultGrid(fxButtonList);
            GridHelper.DefaultGrid(fxPgmList,false);

            //fxAuthLIst.Anchor = AnchorStyles.None;
            //fxPgmList.Anchor = AnchorStyles.None;
            GridHelper.InitColumn(fxButtonList, "PgmId", "프로그램", 80, false, false);
            GridHelper.InitColumnCheckBox(fxButtonList, "AuthYN", "선택", 30, false, true, true);
            GridHelper.InitColumn(fxButtonList, "ButtonId", "버튼 ID", 80);
            GridHelper.InitColumn(fxButtonList, "ButtonName", "버튼 명", 100);


            GridHelper.InitColumn(fxPgmList, "PgmId", "ID", 60);
            GridHelper.InitColumn(fxPgmList, "PgmName", "프로그램 명", 115);
            GridHelper.InitColumn(fxPgmList, "SysId", "프로그램 명", 1,false,false);
            GridHelper.InitColumn(fxPgmList, "AuthId", "프로그램 명", 1,false,false);


        }

        public override void InitializeLocalization()
        {
            base.InitializeLocalization();
        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();

                data.DataTable = (DataTable)fxButtonList.DataSource;
                if (data.DataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "알림", "저장할 자료가 없습니다", MessageBoxButtons.OK);
                    return;
                }
                CommonManager.AddAuthButton(data);
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

                GridHelper.DataBind(fxPgmList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityPgm(cmbAuth.SelectedValue.ToString())));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader1.Text = "조회 건수 : " + (fxPgmList.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }

        #region 그리드 이벤트



        private void PgmRowColchange()
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


            string auth = GridHelper.GetText(fxPgmList, current, "AuthId");
            string pgmId = GridHelper.GetText(fxPgmList, current, "PgmId");

            GridHelper.DataBind(fxButtonList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityButtonList(auth,pgmId)));
            inputGroupHeader2.Text = "조회 건수 : " + (fxButtonList.Rows.Count - 1).ToString();

        }
        private void fxPgmLIst_RowColChange(object sender, EventArgs e)
        {
            PgmRowColchange();
        }

        #endregion





    }
}
