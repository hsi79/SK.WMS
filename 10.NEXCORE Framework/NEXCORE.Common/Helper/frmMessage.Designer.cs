namespace NEXCORE.Common.Helper
{
    partial class frmMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMsgDetail = new C1.Win.C1Input.C1Button();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.btnDetailClose = new C1.Win.C1Input.C1Button();
            this.txtMsgDetail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYes = new C1.Win.C1Input.C1Button();
            this.btnConfirm = new C1.Win.C1Input.C1Button();
            this.btnNo = new C1.Win.C1Input.C1Button();
            this.pnlMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMsg
            // 
            this.pnlMsg.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMsg.Controls.Add(this.pictureBox1);
            this.pnlMsg.Controls.Add(this.btnMsgDetail);
            this.pnlMsg.Controls.Add(this.lblMessage2);
            this.pnlMsg.Controls.Add(this.lblMessage1);
            this.pnlMsg.Location = new System.Drawing.Point(9, 9);
            this.pnlMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(370, 60);
            this.pnlMsg.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btnMsgDetail
            // 
            this.btnMsgDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMsgDetail.BackColor = System.Drawing.Color.White;
            this.btnMsgDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMsgDetail.BackgroundImage")));
            this.btnMsgDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMsgDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMsgDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnMsgDetail.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnMsgDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnMsgDetail.Image")));
            this.btnMsgDetail.Location = new System.Drawing.Point(312, 4);
            this.btnMsgDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMsgDetail.Name = "btnMsgDetail";
            this.btnMsgDetail.Size = new System.Drawing.Size(55, 23);
            this.btnMsgDetail.TabIndex = 55;
            this.btnMsgDetail.Text = "상세";
            this.btnMsgDetail.UseVisualStyleBackColor = false;
            this.btnMsgDetail.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.btnMsgDetail.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.btnMsgDetail.Click += new System.EventHandler(this.btnMsgDetail_Click);
            this.btnMsgDetail.MouseLeave += new System.EventHandler(this.btnDetailClose_MouseLeave);
            this.btnMsgDetail.MouseHover += new System.EventHandler(this.btnDetailClose_MouseHover);
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage2.Location = new System.Drawing.Point(40, 39);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(235, 15);
            this.lblMessage2.TabIndex = 2;
            this.lblMessage2.Text = "나ㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏ";
            // 
            // lblMessage1
            // 
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage1.Location = new System.Drawing.Point(40, 10);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(235, 15);
            this.lblMessage1.TabIndex = 1;
            this.lblMessage1.Text = "나ㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏㅏ";
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDetail.Controls.Add(this.btnDetailClose);
            this.pnlDetail.Controls.Add(this.txtMsgDetail);
            this.pnlDetail.Location = new System.Drawing.Point(9, 276);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(370, 60);
            this.pnlDetail.TabIndex = 5;
            // 
            // btnDetailClose
            // 
            this.btnDetailClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetailClose.BackColor = System.Drawing.Color.White;
            this.btnDetailClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDetailClose.BackgroundImage")));
            this.btnDetailClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDetailClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnDetailClose.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnDetailClose.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailClose.Image")));
            this.btnDetailClose.Location = new System.Drawing.Point(312, 4);
            this.btnDetailClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetailClose.Name = "btnDetailClose";
            this.btnDetailClose.Size = new System.Drawing.Size(55, 23);
            this.btnDetailClose.TabIndex = 56;
            this.btnDetailClose.Text = "닫기";
            this.btnDetailClose.UseVisualStyleBackColor = false;
            this.btnDetailClose.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.btnDetailClose.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Silver;
            this.btnDetailClose.Click += new System.EventHandler(this.btnDetailClose_Click);
            this.btnDetailClose.MouseLeave += new System.EventHandler(this.btnDetailClose_MouseLeave);
            this.btnDetailClose.MouseHover += new System.EventHandler(this.btnDetailClose_MouseHover);
            // 
            // txtMsgDetail
            // 
            this.txtMsgDetail.BackColor = System.Drawing.SystemColors.Control;
            this.txtMsgDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgDetail.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.txtMsgDetail.Location = new System.Drawing.Point(2, 36);
            this.txtMsgDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMsgDetail.Multiline = true;
            this.txtMsgDetail.Name = "txtMsgDetail";
            this.txtMsgDetail.ReadOnly = true;
            this.txtMsgDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsgDetail.Size = new System.Drawing.Size(369, 50);
            this.txtMsgDetail.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 102);
            this.panel1.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnYes
            // 
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.Location = new System.Drawing.Point(227, 81);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(77, 25);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "예";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(306, 81);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(77, 25);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnNo
            // 
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.Location = new System.Drawing.Point(306, 81);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(77, 25);
            this.btnNo.TabIndex = 53;
            this.btnNo.Text = "아니오";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // frmMessage
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(390, 110);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlMsg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정보";
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.TextBox txtMsgDetail;
        private C1.Win.C1Input.C1Button btnYes;
        private C1.Win.C1Input.C1Button btnConfirm;
        private C1.Win.C1Input.C1Button btnDetailClose;
        private C1.Win.C1Input.C1Button btnMsgDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.C1Input.C1Button btnNo;
    }
}