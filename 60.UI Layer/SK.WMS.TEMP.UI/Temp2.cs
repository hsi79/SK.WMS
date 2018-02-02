using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Common.Data;

namespace SK.WMS.TEMP.UI
{
    public partial class Temp2 : SKUserControlBase
    {
        public Temp2()
        {
            InitializeComponent();

            
        }

        public override void InitControls()
        {
            base.InitControls();
        }

        public override void InitializeGrid()
        {
            ////SELECT '<TAG COL-WIDTH=10% /TAG>H_SERIALKEY', '<TAG ROWMERGE_ID=0 /TAG>H_WHSEID', '<TAG ROWMERGE_ID=1 /TAG>H_SUSR2', '<TAG ROWMERGE_ID=2 /TAG>H_MANUFACTURERSKU', 'H_SUSR3', '<TAG FROZEN=COL, COL-WIDTH=20%, COL-ALIGN=CENTER, COL_FONTSIZE=10, COL_TYPE = COMBOBOX /TAG>H_SKUGROUP', 'H_DESCR', 'H_SUSR1', 'H_STDNETWGT', 'H_SUSR9' FROM DUAL
            ////UNION ALL
            ////SELECT 'H_SERIALKEY', 'H_WHSEID', 'H_SUSR2', 'H_MANUFACTURERSKU', 'H_SUSR3', 'H_SKUGROUP', 'H_DESCR', 'H_SUSR1', 'H_STDNETWGT', 'H_SUSR9' FROM DUAL
            ////UNION ALL
            ////SELECT 'H_SERIALKEY', 'H_WHSEID', 'H_SUSR2', 'H_MANUFACTURERSKU', 'H_SUSR3', 'H_SKUGROUP', 'H_DESCR', 'H_SUSR1', 'H_STDNETWGT', 'H_SUSR9' FROM DUAL;

            //DataTable dt = new DataTable();

            //dt.Columns.Add("a");
            //dt.Columns.Add("b");
            //dt.Columns.Add("c");
            //dt.Columns.Add("d");
            //dt.Columns.Add("e");
            //dt.Columns.Add("f");
            //dt.Columns.Add("g");

            //dt.Rows.Add("<TAG FROZEN=COL,COL-WIDTH=50% /TAG>H_SERIALKEY,한글", "<TAG ROWMERGE_ID=0 /TAG>H_WHSEID,한글1", "<TAG ROWMERGE_ID=1 /TAG>H_SUSR2,한글2", "<TAG ROWMERGE_ID=2 /TAG>H_MANUFACTURERSKU,한글3", "<TAG  COL-WIDTH=20%, COL-ALIGN=CENTER, COL-FONTSIZE=10, COL-TYPE = COMBOBOX /TAG>H_SKUGROUP,한글4", "<TAG COL-WIDTH=20%, COL-ALIGN=CENTER, COL-FONTSIZE=10, COL-TYPE = CHECKBOX /TAG>H_DESCR,한글5", "@@H_SUSR1,한글6");
            ////dt.Rows.Add("한글", "한글111", "한글211", "한글311", "한글411", "한글511", "한글611");
            ////dt.Rows.Add("한글", "한글11", "한글11", "한글33", "한글44", "한글55", "한글66");

            NEXCOREData data = new NEXCOREData();



            data.Hashtable.Add("p_USER_ID", "1");

            data = FormInterface.InvokeService("SK.WMS.Common.Biz.CommonBiz", "GetT_SELECT", data);


            GridHelper.SetGridHeader(skGridView1, data.DataSet.Tables[0]);
        }
        private void Temp2_Load(object sender, EventArgs e)
        {
            
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


            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);
            }

        }


    }
}
