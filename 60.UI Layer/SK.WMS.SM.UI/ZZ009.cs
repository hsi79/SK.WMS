using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;
using NEXCORE.Utility.GlobalVariable;
using System.Collections;
using System.Reflection;

namespace SK.WMS.SM.UI
{
    public partial class ZZ009 : SKDialogBase
    {
        public string colName = string.Empty;
        public ZZ009()
        {

            InitializeComponent();

            
        }


        private void btnComfirm_Click(object sender, EventArgs e)
        {

            

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            

        }



        private void ZZ009_Load(object sender, EventArgs e)
        {
            ArrayList ColorList = new ArrayList();
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cmbCtrl.Items.Add(c.Name);
            }

        }



        private void cmbCtrl_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1) 
            { 
                e.DrawBackground();
                e.Graphics.FillRectangle(GetCurrentBrush(cmbCtrl.Items[e.Index].ToString()), e.Bounds);
                Font f = cmbCtrl.Font; e.Graphics.DrawString(cmbCtrl.Items[e.Index].ToString(), f, Brushes.Black, e.Bounds, StringFormat.GenericDefault); 
                e.DrawFocusRectangle(); 
            }
        }

        private Brush GetCurrentBrush(string colorName) 
        {
            colName = colorName;
            return new SolidBrush(Color.FromName(colorName)); 
        }

    }
}