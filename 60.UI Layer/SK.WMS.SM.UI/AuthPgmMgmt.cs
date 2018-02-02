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
    public partial class AuthPgmMgmt : SKUserControlBase
    {

        public AuthPgmMgmt()
        {
            InitializeComponent();

        }
        private void AuthPgmMgmt_Load(object sender, EventArgs e)
        {
            GridHelper.DataBind(fxAuthList, UtilityHelper.ToDataSet( CommonManager.GetAuthorityList()));
            inputGroupHeader1.Text = "조회 건수 : " + (fxAuthList.Rows.Count - 1).ToString();
        }
        public override void InitControls()
        {

        }
        public override void InitializeGrid()
        {
            GridHelper.DefaultGrid(fxAuthList,false);
            GridHelper.DefaultGrid(fxPgmList);

            //fxAuthLIst.Anchor = AnchorStyles.None;
            //fxPgmList.Anchor = AnchorStyles.None;
            GridHelper.InitColumn(fxAuthList, "AuthId", "역할 ID", 80);
            GridHelper.InitColumn(fxAuthList, "AuthName", "역할 명", 100);


            GridHelper.InitColumnCheckBox(fxPgmList, "Chk", "선택", 30,false,true,true);
            GridHelper.InitColumn(fxPgmList, "PgmId", "ID", 60);
            GridHelper.InitColumn(fxPgmList, "PgmName", "프로그램 명", 115);
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

                data.DataTable = (DataTable)fxPgmList.DataSource;
                if (data.DataTable.Rows.Count == 0)
                {
                    MessageBox.Show(this, "알림", "저장할 자료가 없습니다", MessageBoxButtons.OK);
                    return;
                }
                CommonManager.AddAuthPgm(data);
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

                GridHelper.DataBind(fxAuthList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityList()));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader1.Text = "조회 건수 : " + (fxAuthList.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }

        #region 그리드 이벤트



        private void AuthRowColchange()
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


            string auth = GridHelper.GetText(fxAuthList, current, 1);


            GridHelper.DataBind(fxPgmList, UtilityHelper.ToDataSet(CommonManager.GetAuthorityPgmList(auth,"ALL")));
            inputGroupHeader2.Text = "조회 건수 : " + (fxPgmList.Rows.Count - 1).ToString();

        }
        private void fxAuthList_RowColChange(object sender, EventArgs e)
        {
            AuthRowColchange();
        }

        #endregion




    }
}
