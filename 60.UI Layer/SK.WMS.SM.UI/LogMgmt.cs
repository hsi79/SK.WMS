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


namespace SK.WMS.SM.UI
{
    public partial class LogMgmt : SKUserControlBase
    {


        public LogMgmt()
        {
            InitializeComponent();
        }

        private void LogMgmt_Load(object sender, EventArgs e)
        {

            
        }

        public override void InitControls()
        {
            Sdate.Text = DateTime.Now.ToShortDateString();
            eDate.Text = DateTime.Now.ToShortDateString();

            cmbType.SelectedIndex = 0;
            base.InitControls();
        }

        #region 조회






        #endregion

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {

                string sType = "L";
                string start = string.Empty;
                string end = string.Empty;

                switch (cmbType.Text)
                {
                    case "로그인":
                        sType = "L";
                        break;
                    case "프로그램":
                        sType = "P";
                        break;
                    case "버튼":
                        sType = "B";
                        break;

                    default:
                        break;
                }
                start = Sdate.Text;
                end = eDate.Text;

                NEXCOREData data = new NEXCOREData();
                data = CommonManager.GetLogList(sType, start, end);
                GridHelper.DataBind(fxLogList,data.DataSet) ;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
                inputGroupHeader2.Text = "조회 건수 : " + (fxLogList.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }



    }
}
