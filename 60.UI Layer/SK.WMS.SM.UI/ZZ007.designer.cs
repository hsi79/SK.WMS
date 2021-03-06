﻿namespace SK.WMS.SM.UI
{
    partial class ZZ007
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZZ007));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.btnConfirm = new C1.Win.C1Input.C1Button();
            this.tvDept = new System.Windows.Forms.TreeView();
            this.c1InputPanel2 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.tvDept);
            this.panel1.Controls.Add(this.c1InputPanel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 438);
            this.panel1.TabIndex = 26;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(143, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 25);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(60, 403);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(77, 25);
            this.btnConfirm.TabIndex = 48;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnConfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // tvDept
            // 
            this.tvDept.BackColor = System.Drawing.Color.White;
            this.tvDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvDept.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tvDept.Location = new System.Drawing.Point(3, 29);
            this.tvDept.Name = "tvDept";
            this.tvDept.Size = new System.Drawing.Size(285, 360);
            this.tvDept.TabIndex = 32;
            this.tvDept.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrMenu_AfterSelect);
            this.tvDept.DoubleClick += new System.EventHandler(this.tvMenu_DoubleClick);
            // 
            // c1InputPanel2
            // 
            this.c1InputPanel2.BackColor = System.Drawing.Color.White;
            this.c1InputPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1InputPanel2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel2.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel2.Items.Add(this.inputLabel1);
            this.c1InputPanel2.Location = new System.Drawing.Point(-8, -2);
            this.c1InputPanel2.Name = "c1InputPanel2";
            this.c1InputPanel2.Size = new System.Drawing.Size(300, 396);
            this.c1InputPanel2.TabIndex = 49;
            this.c1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Silver;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ElementHeight = 28;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Height = 46;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "부서 검색";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "                 ";
            // 
            // ZZ007
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 462);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZZ007";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통합설비관리 시스템";
            this.Load += new System.EventHandler(this.ZZ007_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvDept;
        private C1.Win.C1Input.C1Button btnCancel;
        private C1.Win.C1Input.C1Button btnConfirm;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel2;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;

    }
}