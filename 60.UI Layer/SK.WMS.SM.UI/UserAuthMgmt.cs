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
    public partial class UserAuthMgmt : SKUserControlBase
    {

        public UserAuthMgmt()
        {
            InitializeComponent();

        }
        private void UserAuthMgmt_Load(object sender, EventArgs e)
        {

            GridHelper.DataBind(fxUserList, UtilityHelper.ToDataSet(CommonManager.GetUsers(searchUserNm.Text)));
            inputGroupHeader1.Text = "조회 건수 : " + (fxUserList.Rows.Count - 1).ToString();
        }
        public override void InitControls()
        {

        }
        public override void InitializeGrid()
        {
            GridHelper.DefaultGrid(fxUserList,false);
            GridHelper.DefaultGrid(fxAuthList);


            GridHelper.InitColumn(fxUserList, "UserId", "사용자 ID", 100);
            GridHelper.InitColumn(fxUserList, "UserName", "사용자 명", 100);
            GridHelper.InitColumn(fxUserList, "DeptNm", "부서", 100);

            GridHelper.InitColumnCheckBox(fxAuthList, "Chk", "선택", 50, false, true, true);
            GridHelper.InitColumn(fxAuthList, "AuthId", "역할 ID", 100);
            GridHelper.InitColumn(fxAuthList, "AuthName", "역할 명", 150);
            GridHelper.InitColumn(fxAuthList, "UserId", "역할 명", 150,false,false);
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

                data.DataTable = (DataTable)fxAuthList.DataSource;
                if (data.DataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "알림", "저장할 자료가 없습니다", MessageBoxButtons.OK);
                    return;
                }
                CommonManager.AddUserAuth(data);
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

                GridHelper.DataBind(fxUserList, UtilityHelper.ToDataSet(CommonManager.GetUsers(searchUserNm.Text)));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader1.Text = "조회 건수 : " + (fxUserList.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }

        private void fxUserLIst_RowColChange(object sender, EventArgs e)
        {
            RowColchange();
        }

        private void RowColchange()
        {
            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (fxUserList.Row > 0) ? fxUserList.Rows[fxUserList.Row].DataIndex : -1;
            int col = fxUserList.Col;


            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;


            string user = GridHelper.GetText(fxUserList, current, 1);

            GridHelper.DataBind(fxAuthList, UtilityHelper.ToDataSet( CommonManager.GetUserAuthorityList(user)));
            inputGroupHeader2.Text = "조회 건수 : " + (fxAuthList.Rows.Count - 1).ToString();
        }


    }
}
