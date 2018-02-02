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

namespace SK.WMS.INV20.INB.UI
{
    public partial class INB2010 : SKUserControlBase
    {
        public INB2010()
        {
            InitializeComponent();
        }

        public override void InitControls()
        {
            base.InitControls();
        }

        public override void InitializeGrid()
        {
            //NEXCOREData data = new NEXCOREData();



            //data.Hashtable.Add("p_USER_ID", "1");

            //data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "GetT_MSG_SELECT", data);


            //GridHelper.SetGridHeader(skGridView1, data.DataSet.Tables[0]);
        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("p_USER_ID", '1');

                data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "SP_INB2010_0L_R_SHORTPROD", data);
                GridHelper.SetGridHeader(skGridView1, data.DataSet.Tables[0]);
                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                

            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);
            }

        }
    }
}
