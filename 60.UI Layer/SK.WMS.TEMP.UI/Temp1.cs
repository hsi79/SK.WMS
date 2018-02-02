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
using C1.Win.C1FlexGrid;

namespace SK.WMS.TEMP.UI
{
    public partial class Temp1 : SKUserControlBase
    {

        public Hashtable ht = new Hashtable();
        public Temp1()
        {
            InitializeComponent();
        }

        public override void InitControls()
        {
            base.InitControls();

            helpWindow1.InParam = "p_USER_ID";

            NEXCOREData data = new NEXCOREData();



            data.Hashtable.Add("p_USER_ID", "1");

            data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "GetT_SELECT", data);


            GridHelper.SetGridHeader(skGridView1, data.DataSet);
        }
        private void Temp1_Load(object sender, EventArgs e)
        {

        }

        private void skButton1_Click(object sender, EventArgs e)
        {
            string ret = string.Empty;
            NEXCOREData nexData = new NEXCOREData();
            nexData.Name = "123";
            FormInterface.SendMessage("SM002", nexData);
            FormInterface.LoadForm(this, "SM002", ref ret);


        }

        private void skButton2_Click(object sender, EventArgs e)
        {


            CommonHelper.CallMsgPopUp("타이틀", helpWindow1.helpValue, "메세지2", "1", "상세");
            
        }

        private void skButton3_Click(object sender, EventArgs e)
        {
            CommonHelper.CallMsgPopUp("타이틀", "저장하시겠습니까?", "메세지2", "2", "상세");
        }

        private void skButton4_Click(object sender, EventArgs e)
        {
            FormInterface.WriteStatusBar(this, "메세지 입니다.");
            MessageBox.Show(helpWindow1.helpDisplay);
            MessageBox.Show(helpWindow1.helpValue);
        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();



                data.Hashtable.Add("p_USER_ID", '1');

                data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "GetT_SELECT", data);

                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));

                skGridView1.EnableEdit(true);
                
            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);
            }
        }

        private void skGridView1_AfterEdit(object sender, RowColEventArgs e, WinControls.SKGridView.SKExtendEventArgs ex)
        {
            MessageBox.Show(ex.AfterData.ToString() + "   " + ex.BeforeData.ToString() + "    " + ex.Change.ToString());
        }
    }
}
