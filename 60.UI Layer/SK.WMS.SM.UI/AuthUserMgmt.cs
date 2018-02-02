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
    public partial class AuthUserMgmt : SKUserControlBase
    {

        public AuthUserMgmt()
        {
            InitializeComponent();

        }
        private void AuthUserMgmt_Load(object sender, EventArgs e)
        {

            SearchList();
        }
        public override void InitControls()
        {

        }
        public override void InitializeGrid()
        {
            GridHelper.DefaultGrid(fxUserList);
            GridHelper.DefaultGrid(fxAuthList,false);
            GridHelper.DefaultGrid(fxAuthPgmList, false);

            GridHelper.InitColumnCheckBox(fxUserList, "Chk", "선택", 40, false, true, true);
           GridHelper.InitColumn(fxUserList, "UserId", "사용자 ID", 80);
            GridHelper.InitColumn(fxUserList, "UserName", "사용자 명", 80);
            GridHelper.InitColumn(fxUserList, "DeptName", "부서", 100);
            GridHelper.InitColumn(fxUserList, "AuthId", "역할 ID", 100,false,false);

            GridHelper.InitColumn(fxAuthList, "AuthId", "역할 ID", 100);
            GridHelper.InitColumn(fxAuthList, "AuthName", "역할 명", 150);
            GridHelper.InitColumn(fxAuthList, "UserId", "역할 명", 150,false,false);

            GridHelper.InitColumn(fxAuthPgmList, "PgmId", "ID", 90);
            GridHelper.InitColumn(fxAuthPgmList, "PgmName", "프로그램 명", 350);

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

                data.DataTable = (DataTable)fxUserList.DataSource;
                if (data.DataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "알림", "저장할 자료가 없습니다", MessageBoxButtons.OK);
                    return;
                }
                CommonManager.AddAuthUser(data);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);

            }
        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            SearchList();
        }

        private void SearchList()
        {
            try
            {

                GridHelper.DataBind(fxAuthList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityList()));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader2.Text = "조회 건수 : " + (fxAuthList.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }

        private void fxAuthList_RowColChange(object sender, EventArgs e)
        {
            RowColchange();
        }

        private void RowColchange()
        {
            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (fxAuthList.Row > 0) ? fxAuthList.Rows[fxAuthList.Row].DataIndex : -1;
            int col = fxAuthList.Col;


            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;


            string role = GridHelper.GetText(fxAuthList, current, "AuthId");

            GridHelper.DataBind(fxUserList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityUserList(role,"","")));
            inputGroupHeader1.Text = "조회 건수 : " + (fxUserList.Rows.Count - 1).ToString();

            GridHelper.DataBind(fxAuthPgmList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityPgm(role)));
            inputGroupHeader3.Text = GridHelper.GetText(fxAuthList, current, "AuthName");
        }


    }
}
