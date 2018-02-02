using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common.Data;
using System.Drawing.Drawing2D;
using NEXCORE.Interfaces;
using C1.Win.C1Input;


namespace SK.WMS.WinControls
{


    public partial class SKButton :  C1Button
    {


        public SKButton()
        {

            this.AutoSize = false;
            this.BackColor = Color.White;
            this.ForeColor = DefaultForeColor;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Size = new System.Drawing.Size(77, 25);
            this.Image = Properties.Resources.공백_2_normal;
            this.UseVisualStyleBackColor = false;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.MouseHover += new EventHandler(SKButton_MouseHover);
            this.MouseLeave += new EventHandler(SKButton_MouseLeave);
        }




        protected override void OnPaint(PaintEventArgs pe)
        {


            base.OnPaint(pe);

            this.Height = 25;
        }

        private void SKButton_MouseLeave(object sender, EventArgs e)
        {
            ((C1.Win.C1Input.C1Button)sender).Image = Properties.Resources.공백_2_normal;
        }
        private void SKButton_MouseHover(object sender, EventArgs e)
        {
            ((C1.Win.C1Input.C1Button)sender).Image = Properties.Resources.공백_2_over;

        }
        public string GetText()
        {
            return string.Empty;
        }
        public object GetValue()
        {
            return null;
        }
        public bool FocusedState()
        {
            return this.Focused;
        }



 
        private void SKButton_Layout(object sender, LayoutEventArgs e)
        {

            
        }
    }
}
