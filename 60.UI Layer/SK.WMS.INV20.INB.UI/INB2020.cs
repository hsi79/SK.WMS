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
using C1.Win.C1Input;

namespace SK.WMS.INV20.INB.UI
{
    public partial class INB2020 : SKUserControlBase
    {
        public INB2020()
        {
            InitializeComponent();
        }

        private void c1Button1_MouseHover(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.조회_1_over;
        }

        private void c1Button1_MouseLeave(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.조회_1_normal;
        }

        private void c1Button2_MouseHover(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.신규_1_over;
        }

        private void c1Button2_MouseLeave(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.신규_1_normal;
        }

        private void c1Button3_MouseHover(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.저장_1_over;
        }

        private void c1Button3_MouseLeave(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.저장_1_normal;
        }

        private void c1Button4_MouseHover(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.삭제_1_over;
        }

        private void c1Button4_MouseLeave(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.삭제_1_normal;
        }

        private void c1Button5_MouseHover(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.엑셀_1_over;
        }

        private void c1Button5_MouseLeave(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.엑셀_1_normal;
        }

        private void c1Button6_MouseHover(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.인쇄_1_over;
        }

        private void c1Button6_MouseLeave(object sender, EventArgs e)
        {
            ((C1Button)sender).Image = Properties.Resources.인쇄_1_normal;
        }
    }
}
