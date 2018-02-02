using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Utility.GlobalVariable;


    namespace NEXCORE.Common.Helper
    {
        public partial class frmMessage : Form
        {
            public string ReturnMsg = "";

            public frmMessage()
            {
                InitializeComponent();
            }

            /// <summary>
            /// 폼로딩

            /// </summary>
            /// <param name="msgTitle">메세지제목</param>
            /// <param name="msg1">메세지1</param>
            /// <param name="msg2">메세지2</param>
            /// <param name="msgType">메세지구분(1:확인, 2:예/아니오)</param>
            /// <param name="msgDetail">메세지상세(에러등)</param>
            public frmMessage(string msgTitle, string msg1, string msg2, string msgType, string msgDetail)
            {



                InitializeComponent();

                pnlMsg.BackColor = Color.FromName(WMSVar.MSG);
                pnlDetail.BackColor = Color.FromName(WMSVar.MSG);
                txtMsgDetail.BackColor = Color.FromName(WMSVar.MSG);

                this.Text = msgTitle;
                this.lblMessage1.Text = msg1;
                this.lblMessage2.Text = msg2;
                if (msgDetail != "")
                {
                    btnMsgDetail.Visible = true;
                    txtMsgDetail.Text = msgDetail;
                    pictureBox1.Image = Properties.ImageResource._error32;
                }
                if (msgDetail == string.Empty || msg1 == msgDetail)
                {
                    btnMsgDetail.Visible = false;
                    txtMsgDetail.Text = "";
                    pictureBox1.Image = Properties.ImageResource._warning32;
                }
                if (msgType == "1")
                {
                    this.btnYes.Visible = false;
                    this.btnNo.Visible = false;
                    this.btnConfirm.Visible = true;

                }
                else if (msgType == "2")
                {
                    this.btnYes.Visible = true;
                    this.btnNo.Visible = true;
                    this.btnConfirm.Visible = false;
                    this.btnDetailClose.Visible = false;
                    this.btnMsgDetail.Visible = false;
                    pictureBox1.Image = Properties.ImageResource._information32;
                }





            }

            private void btnYes_Click(object sender, EventArgs e)
            {
                ReturnMsg = "YES";
                this.Close();
            }

            private void btnNo_Click(object sender, EventArgs e)
            {
                ReturnMsg = "NO";
                this.Close();
            }

            private void btnConfirm_Click(object sender, EventArgs e)
            {
                ReturnMsg = "OK";
                this.Close();
            }

            private void btnMsgDetail_Click(object sender, EventArgs e)
            {
                pnlDetail.Top = pnlMsg.Top;
                pnlDetail.Left = pnlMsg.Left;
                pnlDetail.Visible = true;
                pnlMsg.Visible = false;
            }

            private void btnDetailClose_Click(object sender, EventArgs e)
            {
                pnlDetail.Visible = false;
                pnlMsg.Visible = true;
            }

            private void btnDetailClose_MouseHover(object sender, EventArgs e)
            {
                ((C1.Win.C1Input.C1Button)sender).Image = Properties.Resources.sub_btn_over;
            }

            private void btnDetailClose_MouseLeave(object sender, EventArgs e)
            {
                ((C1.Win.C1Input.C1Button)sender).Image = Properties.Resources.sub_btn_up;
            }

        }
    }

