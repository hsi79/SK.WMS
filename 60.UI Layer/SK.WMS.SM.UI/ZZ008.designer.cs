namespace SK.WMS.SM.UI
{
    partial class ZZ008
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZZ008));
            this.btnConfirm = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.cmbFont = new C1.Win.C1InputPanel.InputComboBox();
            this.inputOption1 = new C1.Win.C1InputPanel.InputOption();
            this.inputOption2 = new C1.Win.C1InputPanel.InputOption();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoControl = new System.Windows.Forms.RadioButton();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.c1Label4 = new C1.Win.C1Input.C1Label();
            this.c1InputPanel2 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.Location = new System.Drawing.Point(62, 192);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(77, 25);
            this.btnConfirm.TabIndex = 32;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnConfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(143, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 25);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "닫기";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c1InputPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1InputPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Items.Add(this.inputLabel1);
            this.c1InputPanel1.Items.Add(this.cmbFont);
            this.c1InputPanel1.Location = new System.Drawing.Point(-1, -2);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(293, 86);
            this.c1InputPanel1.TabIndex = 34;
            this.c1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Silver;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ElementHeight = 28;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Height = 46;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "폰트 설정";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "              폰트   ";
            // 
            // cmbFont
            // 
            this.cmbFont.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDownList;
            this.cmbFont.Items.Add(this.inputOption1);
            this.cmbFont.Items.Add(this.inputOption2);
            this.cmbFont.Name = "cmbFont";
            // 
            // inputOption1
            // 
            this.inputOption1.Name = "inputOption1";
            this.inputOption1.Text = "맑은고딕";
            // 
            // inputOption2
            // 
            this.inputOption2.Name = "inputOption2";
            this.inputOption2.Text = "돋움체";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.c1InputPanel2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.c1InputPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 235);
            this.panel1.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rdoControl);
            this.groupBox2.Controls.Add(this.rdoWhite);
            this.groupBox2.Controls.Add(this.c1Label3);
            this.groupBox2.Controls.Add(this.c1Label4);
            this.groupBox2.Location = new System.Drawing.Point(14, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 44);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(48, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "색상";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // rdoControl
            // 
            this.rdoControl.AutoSize = true;
            this.rdoControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdoControl.Location = new System.Drawing.Point(157, 18);
            this.rdoControl.Name = "rdoControl";
            this.rdoControl.Size = new System.Drawing.Size(14, 13);
            this.rdoControl.TabIndex = 52;
            this.rdoControl.TabStop = true;
            this.rdoControl.UseVisualStyleBackColor = false;
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdoWhite.Location = new System.Drawing.Point(98, 18);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(14, 13);
            this.rdoWhite.TabIndex = 51;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.UseVisualStyleBackColor = false;
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BackColor = System.Drawing.Color.Silver;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Location = new System.Drawing.Point(179, 18);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(17, 12);
            this.c1Label3.TabIndex = 50;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "   ";
            this.c1Label3.TextDetached = true;
            // 
            // c1Label4
            // 
            this.c1Label4.AutoSize = true;
            this.c1Label4.BackColor = System.Drawing.Color.White;
            this.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label4.Location = new System.Drawing.Point(119, 18);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(17, 12);
            this.c1Label4.TabIndex = 49;
            this.c1Label4.Tag = " ";
            this.c1Label4.Text = "   ";
            this.c1Label4.TextDetached = true;
            // 
            // c1InputPanel2
            // 
            this.c1InputPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c1InputPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1InputPanel2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel2.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel2.Location = new System.Drawing.Point(-1, 88);
            this.c1InputPanel2.Name = "c1InputPanel2";
            this.c1InputPanel2.Size = new System.Drawing.Size(293, 86);
            this.c1InputPanel2.TabIndex = 35;
            this.c1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Silver;
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader2.ElementHeight = 28;
            this.inputGroupHeader2.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader2.Height = 46;
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "메세지 박스 배경색 설정";
            // 
            // ZZ008
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 342);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZZ008";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통합설비관리 시스템";
            this.Load += new System.EventHandler(this.ZZ008_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button btnConfirm;
        private C1.Win.C1Input.C1Button btnCancel;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1InputPanel.InputComboBox cmbFont;
        private C1.Win.C1InputPanel.InputOption inputOption1;
        private C1.Win.C1InputPanel.InputOption inputOption2;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel2;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoControl;
        private System.Windows.Forms.RadioButton rdoWhite;
        private C1.Win.C1Input.C1Label c1Label3;
        private C1.Win.C1Input.C1Label c1Label4;


    }
}