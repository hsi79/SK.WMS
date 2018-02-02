using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using System.Collections;

namespace SK.WMS.INV10.MST.UI
{
    public partial class MST1010 : SKUserControlBase
    {
        public MST1010()
        {
            InitializeComponent();
        }
        public override void InitControls()
        {
            base.InitControls();
        }
        public override void InitializeGrid()
        {
            NEXCOREData data = new NEXCOREData();

            data.Hashtable.Add("p_USER_ID", "1");

            data = FormInterface.InvokeService("SK.WMS.INV10.MST.Biz.MST1010Biz", "SP_MST1010_0_R_SKUSELECT", data);

            GridHelper.SetGridHeader(skGridView1, data.DataSet);

        }
        public override void InitializeLocalization()
        {
            base.InitializeLocalization();
        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("p_USER_ID", "1");

                data = FormInterface.InvokeService("SK.WMS.INV10.MST.Biz.MST1010Biz", "SP_MST1010_0_R_SKUSELECT", data);

                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);

                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));

                skGridView1.EnableEdit(true);
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);
            }
        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();

                DataTable dt = ((DataTable)skGridView1.DataSource).Clone();
                
                foreach (DataRow dr in ((DataTable)skGridView1.DataSource).Rows)
                {
                    if (dr.RowState == DataRowState.Modified)
                    {
                        dt.Rows.Add(dr.ItemArray);
                    }
                }
                
                data.Hashtable.Add("P_IN", dt);

                data = FormInterface.InvokeService("SK.WMS.INV10.MST.Biz.MST1010Biz", "SP_MST1010_0_S_SKUSAVE", data);

                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);
                
                FormInterface.WriteStatusBar(this, data.intCnt+"건 "+CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }
        }

        private void commonButton1_OnNewClick(object sender, EventArgs e)
        {
            GridHelper.AddRow(skGridView1);
            
        }

        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();

                DataTable dt = ((DataTable)skGridView1.DataSource).Clone();

                foreach (DataRow dr in ((DataTable)skGridView1.DataSource).Rows)
                {
                    if (dr["CHK"].ToString() == "1")
                    {
                        dt.Rows.Add(dr.ItemArray);
                    }
                }
                if (CommonHelper.CallMsgPopUp("알림", dt.Rows.Count + "건 " + CommonManager.GetMessage("M10005"), "", "2", "") == "예")
                {

                    data.Hashtable.Add("P_IN", dt);

                    data = FormInterface.InvokeService("SK.WMS.INV10.MST.Biz.MST1010Biz", "SP_MST1010_0_D_SKUDELETE", data);

                    FormInterface.WriteStatusBar(this, data.intCnt + "건 " + CommonManager.GetMessage("M10001"));
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10004"), "", "1", ex.Message);
            }
        }

        

    }
}
