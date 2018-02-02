namespace SK.WMS.SM.UI
{
    partial class MenuMgmt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputLabel4 = new C1.Win.C1InputPanel.InputLabel();
            this.inputCheckBox1 = new C1.Win.C1InputPanel.InputCheckBox();
            this.inputTextBox1 = new C1.Win.C1InputPanel.InputTextBox();
            this.lblColor = new C1.Win.C1Input.C1Label();
            this.btnUpMenu = new C1.Win.C1Input.C1Button();
            this.c1Label6 = new C1.Win.C1Input.C1Label();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.InPanel = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.lblMenuID = new C1.Win.C1InputPanel.InputLabel();
            this.txtMenu = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel7 = new C1.Win.C1InputPanel.InputLabel();
            this.txtMenuKor = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel8 = new C1.Win.C1InputPanel.InputLabel();
            this.cmbProgram = new C1.Win.C1InputPanel.InputComboBox();
            this.inputLabel9 = new C1.Win.C1InputPanel.InputLabel();
            this.txtUpMenu = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel11 = new C1.Win.C1InputPanel.InputLabel();
            this.txtOrder = new C1.Win.C1InputPanel.InputNumericBox();
            this.inputLabel3 = new C1.Win.C1InputPanel.InputLabel();
            this.chkUse = new C1.Win.C1InputPanel.InputCheckBox();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.txtDesc = new C1.Win.C1InputPanel.InputTextBox();
            this.txtMenuEng = new C1.Win.C1InputPanel.InputTextBox();
            this.txtUpMenuId = new C1.Win.C1InputPanel.InputTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLabel4
            // 
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Text = "조회 메뉴";
            this.inputLabel4.Width = 100;
            // 
            // inputCheckBox1
            // 
            this.inputCheckBox1.Break = C1.Win.C1InputPanel.BreakType.None;
            this.inputCheckBox1.Name = "inputCheckBox1";
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.MaxLength = 12;
            this.inputTextBox1.Name = "inputTextBox1";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.White;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblColor.Font = new System.Drawing.Font("굴림", 14F);
            this.lblColor.Location = new System.Drawing.Point(471, 386);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(87, 19);
            this.lblColor.TabIndex = 51;
            this.lblColor.Tag = null;
            this.lblColor.Text = "             ";
            this.lblColor.TextDetached = true;
            // 
            // btnUpMenu
            // 
            this.btnUpMenu.Location = new System.Drawing.Point(623, 159);
            this.btnUpMenu.Name = "btnUpMenu";
            this.btnUpMenu.Size = new System.Drawing.Size(23, 23);
            this.btnUpMenu.TabIndex = 48;
            this.btnUpMenu.Text = "..";
            this.btnUpMenu.UseVisualStyleBackColor = true;
            this.btnUpMenu.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnUpMenu.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnUpMenu.Click += new System.EventHandler(this.btnUpMenu_Click);
            // 
            // c1Label6
            // 
            this.c1Label6.AutoSize = true;
            this.c1Label6.BackColor = System.Drawing.Color.White;
            this.c1Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c1Label6.Location = new System.Drawing.Point(394, 276);
            this.c1Label6.Name = "c1Label6";
            this.c1Label6.Size = new System.Drawing.Size(0, 15);
            this.c1Label6.TabIndex = 45;
            this.c1Label6.Tag = null;
            this.c1Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c1Label6.TextDetached = true;
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.White;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvMenu.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tvMenu.Location = new System.Drawing.Point(2, 48);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(348, 583);
            this.tvMenu.TabIndex = 31;
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrMenu_AfterSelect);
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.White;
            this.commonButton1.BindingGrid = true;
            this.commonButton1.BindingGridControl = null;
            this.commonButton1.DelCol = 0;
            this.commonButton1.ExcelEnable = false;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(2, 5);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintEnable = false;
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(754, 36);
            this.commonButton1.TabIndex = 30;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            this.commonButton1.OnDeleteClick += new System.EventHandler(this.commonButton1_OnDeleteClick);
            this.commonButton1.OnNewClick += new System.EventHandler(this.commonButton1_OnNewClick);
            // 
            // InPanel
            // 
            this.InPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InPanel.BackColor = System.Drawing.Color.White;
            this.InPanel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.InPanel.Items.Add(this.inputGroupHeader2);
            this.InPanel.Items.Add(this.lblMenuID);
            this.InPanel.Items.Add(this.txtMenu);
            this.InPanel.Items.Add(this.inputLabel7);
            this.InPanel.Items.Add(this.txtMenuKor);
            this.InPanel.Items.Add(this.inputLabel8);
            this.InPanel.Items.Add(this.cmbProgram);
            this.InPanel.Items.Add(this.inputLabel9);
            this.InPanel.Items.Add(this.txtUpMenu);
            this.InPanel.Items.Add(this.inputLabel11);
            this.InPanel.Items.Add(this.txtOrder);
            this.InPanel.Items.Add(this.inputLabel3);
            this.InPanel.Items.Add(this.chkUse);
            this.InPanel.Items.Add(this.inputLabel1);
            this.InPanel.Items.Add(this.txtDesc);
            this.InPanel.Items.Add(this.txtMenuEng);
            this.InPanel.Items.Add(this.txtUpMenuId);
            this.InPanel.Location = new System.Drawing.Point(356, 48);
            this.InPanel.Name = "InPanel";
            this.InPanel.Size = new System.Drawing.Size(400, 583);
            this.InPanel.TabIndex = 22;
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader2.ElementHeight = 28;
            this.inputGroupHeader2.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "입력 항목";
            // 
            // lblMenuID
            // 
            this.lblMenuID.ForeColor = System.Drawing.Color.Black;
            this.lblMenuID.Name = "lblMenuID";
            this.lblMenuID.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblMenuID.Text = "메뉴 ID";
            this.lblMenuID.Width = 100;
            // 
            // txtMenu
            // 
            this.txtMenu.Enabled = false;
            this.txtMenu.MaxLength = 10;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Width = 150;
            // 
            // inputLabel7
            // 
            this.inputLabel7.ForeColor = System.Drawing.Color.Black;
            this.inputLabel7.Name = "inputLabel7";
            this.inputLabel7.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.inputLabel7.Text = "메뉴 명";
            this.inputLabel7.Width = 100;
            // 
            // txtMenuKor
            // 
            this.txtMenuKor.MaxLength = 100;
            this.txtMenuKor.Name = "txtMenuKor";
            this.txtMenuKor.Width = 250;
            // 
            // inputLabel8
            // 
            this.inputLabel8.ForeColor = System.Drawing.Color.Black;
            this.inputLabel8.Name = "inputLabel8";
            this.inputLabel8.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.inputLabel8.Text = "프로그램";
            this.inputLabel8.Width = 100;
            // 
            // cmbProgram
            // 
            this.cmbProgram.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest;
            this.cmbProgram.Name = "cmbProgram";
            this.cmbProgram.Width = 200;
            // 
            // inputLabel9
            // 
            this.inputLabel9.ForeColor = System.Drawing.Color.Black;
            this.inputLabel9.Name = "inputLabel9";
            this.inputLabel9.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.inputLabel9.Text = "상위 메뉴명";
            this.inputLabel9.Width = 100;
            // 
            // txtUpMenu
            // 
            this.txtUpMenu.Name = "txtUpMenu";
            this.txtUpMenu.ReadOnly = true;
            this.txtUpMenu.ToolTipText = "최상위 메뉴를 입력하시려면 ROOT 로 입력하십시요.";
            this.txtUpMenu.Width = 150;
            // 
            // inputLabel11
            // 
            this.inputLabel11.ForeColor = System.Drawing.Color.Black;
            this.inputLabel11.Name = "inputLabel11";
            this.inputLabel11.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.inputLabel11.Text = "정렬순서";
            this.inputLabel11.Width = 100;
            // 
            // txtOrder
            // 
            this.txtOrder.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtOrder.Name = "txtOrder";
            // 
            // inputLabel3
            // 
            this.inputLabel3.ForeColor = System.Drawing.Color.Black;
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.inputLabel3.Text = "사용여부";
            this.inputLabel3.Width = 100;
            // 
            // chkUse
            // 
            this.chkUse.Name = "chkUse";
            this.chkUse.Padding = new System.Windows.Forms.Padding(2, 6, 2, 6);
            // 
            // inputLabel1
            // 
            this.inputLabel1.ForeColor = System.Drawing.Color.Black;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.inputLabel1.Text = "메뉴설명";
            this.inputLabel1.Width = 100;
            // 
            // txtDesc
            // 
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Width = 250;
            // 
            // txtMenuEng
            // 
            this.txtMenuEng.MaxLength = 100;
            this.txtMenuEng.Name = "txtMenuEng";
            this.txtMenuEng.Visibility = C1.Win.C1InputPanel.Visibility.Hidden;
            this.txtMenuEng.Width = 250;
            // 
            // txtUpMenuId
            // 
            this.txtUpMenuId.Name = "txtUpMenuId";
            this.txtUpMenuId.Visibility = C1.Win.C1InputPanel.Visibility.Hidden;
            // 
            // MenuMgmt
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnUpMenu);
            this.Controls.Add(this.c1Label6);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.InPanel);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MenuMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.MenuMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel InPanel;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputLabel lblMenuID;
        private C1.Win.C1InputPanel.InputTextBox txtMenu;
        private C1.Win.C1InputPanel.InputLabel inputLabel7;
        private C1.Win.C1InputPanel.InputTextBox txtMenuKor;
        private C1.Win.C1InputPanel.InputLabel inputLabel8;
        private C1.Win.C1InputPanel.InputLabel inputLabel9;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1InputPanel.InputLabel inputLabel11;
        private C1.Win.C1InputPanel.InputNumericBox txtOrder;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputTextBox txtDesc;
        private System.Windows.Forms.TreeView tvMenu;
        private C1.Win.C1InputPanel.InputTextBox txtMenuEng;
        private C1.Win.C1InputPanel.InputLabel inputLabel3;
        private C1.Win.C1InputPanel.InputCheckBox chkUse;
        private C1.Win.C1InputPanel.InputLabel inputLabel4;
        private C1.Win.C1InputPanel.InputCheckBox inputCheckBox1;
        private C1.Win.C1InputPanel.InputTextBox inputTextBox1;
        private C1.Win.C1Input.C1Label c1Label6;
        private C1.Win.C1InputPanel.InputComboBox cmbProgram;
        private C1.Win.C1Input.C1Button btnUpMenu;
        public C1.Win.C1InputPanel.InputTextBox txtUpMenuId;
        public C1.Win.C1InputPanel.InputTextBox txtUpMenu;
        private C1.Win.C1Input.C1Label lblColor;
    }
}
