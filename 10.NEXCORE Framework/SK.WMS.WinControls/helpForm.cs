using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using NEXCORE.Common.Data;
using NEXCORE.Common;

namespace SK.WMS.WinControls
{
    public partial class helpForm : Form
    {
        public delegate void ChildEventHandler(string str);
        public event ChildEventHandler GetTextEvent;
        public string pakageName = string.Empty;
        public string displayName = string.Empty;
        public string valueName = string.Empty;
        public string inParm ;

        public helpForm()
        {
            InitializeComponent();
            
        }

        private void helpForm_Load(object sender, EventArgs e)
        {

            NEXCOREData data = new NEXCOREData();


            data.Name = pakageName;

            data.Hashtable.Add(inParm, "&&&");
           data = CommonManager.GetHelpWindow(data);


            GridHelper.SetGridHeader(skGridView1, data.DataSet);

            
        }

        private void skGridView1_DoubleClick(object sender, EventArgs e)
        {
            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (skGridView1.Row > 0) ? skGridView1.Rows[skGridView1.Row].DataIndex : -1;

            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;
            string dName = GridHelper.GetText(skGridView1, current, displayName);
            string vName = GridHelper.GetText(skGridView1, current, valueName);
            GetTextEvent(dName + "," + vName);

            this.Close();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                NEXCOREData data = new NEXCOREData();



                data.Name = pakageName;

                data.Hashtable.Add(inParm, txtSearch.Text);


                data = CommonManager.GetHelpWindow(data);

                GridHelper.DataBind(skGridView1, data.DataSet.Tables[1]);


            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);
            }
        }

        
         
    }
}
