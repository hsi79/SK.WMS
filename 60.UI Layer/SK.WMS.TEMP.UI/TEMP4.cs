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

namespace SK.WMS.TEMP.UI
{
    public partial class Temp4 : SKUserControlBase
    {
        public Temp4()
        {
            InitializeComponent();
        }

        public override void InitializeGrid()
        {
            NEXCOREData data = new NEXCOREData();

            data.Hashtable.Add("p_USER_ID", "NONE");

            data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "GetT_SELECT", data);

            GridHelper.SetGridHeader(skGridView1, data.DataSet.Tables[0]);
        }

        private void Temp4_Load(object sender, EventArgs e)
        {
            skGridView1.AllowEditing = true;
        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("p_ID", skTextBox1.Text.Trim());

                data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "SelectTemp4", data);

                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
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

                data.Hashtable.Add("p_Type", "U");
                data.Hashtable.Add("p_ID", FormInterface.GetCurrentUser().UserId);
                data.DataTable = dt;

                data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "UpdateTemp4", data);

                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }
        }
    }
}
