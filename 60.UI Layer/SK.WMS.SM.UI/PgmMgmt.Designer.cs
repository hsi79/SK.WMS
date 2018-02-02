namespace SK.WMS.SM.UI
{
    partial class PgmMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PgmMgmt));
            this.pnlSearch = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader3 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel5 = new C1.Win.C1InputPanel.InputLabel();
            this.searchProgram = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.searchProgramNm = new C1.Win.C1InputPanel.InputTextBox();
            this.InPanel = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel6 = new C1.Win.C1InputPanel.InputLabel();
            this.txtProgramID = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel7 = new C1.Win.C1InputPanel.InputLabel();
            this.txtProgramNm = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel8 = new C1.Win.C1InputPanel.InputLabel();
            this.txtAssembly = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel9 = new C1.Win.C1InputPanel.InputLabel();
            this.txtClass = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel10 = new C1.Win.C1InputPanel.InputLabel();
            this.cmbType = new C1.Win.C1InputPanel.InputComboBox();
            this.inputOption1 = new C1.Win.C1InputPanel.InputOption();
            this.inputOption2 = new C1.Win.C1InputPanel.InputOption();
            this.inputLabel11 = new C1.Win.C1InputPanel.InputLabel();
            this.txtProgramDesc = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel2 = new C1.Win.C1InputPanel.InputLabel();
            this.chkAuth = new C1.Win.C1InputPanel.InputCheckBox();
            this.fxPgmList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader4 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxPgmList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.pnlSearch.Items.Add(this.inputGroupHeader3);
            this.pnlSearch.Items.Add(this.inputLabel5);
            this.pnlSearch.Items.Add(this.searchProgram);
            this.pnlSearch.Items.Add(this.inputLabel1);
            this.pnlSearch.Items.Add(this.searchProgramNm);
            this.pnlSearch.Location = new System.Drawing.Point(2, 45);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(754, 60);
            this.pnlSearch.TabIndex = 23;
            // 
            // inputGroupHeader3
            // 
            this.inputGroupHeader3.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader3.ElementHeight = 28;
            this.inputGroupHeader3.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader3.Name = "inputGroupHeader3";
            this.inputGroupHeader3.Text = "검색 조건";
            // 
            // inputLabel5
            // 
            this.inputLabel5.ForeColor = System.Drawing.Color.Black;
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Text = "프로그램 ID";
            this.inputLabel5.Width = 80;
            // 
            // searchProgram
            // 
            this.searchProgram.Break = C1.Win.C1InputPanel.BreakType.None;
            this.searchProgram.ForeColor = System.Drawing.Color.Black;
            this.searchProgram.Name = "searchProgram";
            this.searchProgram.Width = 150;
            // 
            // inputLabel1
            // 
            this.inputLabel1.ForeColor = System.Drawing.Color.Black;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inputLabel1.Text = "프로그램 명";
            this.inputLabel1.Width = 100;
            // 
            // searchProgramNm
            // 
            this.searchProgramNm.Break = C1.Win.C1InputPanel.BreakType.None;
            this.searchProgramNm.Name = "searchProgramNm";
            this.searchProgramNm.Width = 200;
            // 
            // InPanel
            // 
            this.InPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InPanel.BackColor = System.Drawing.Color.White;
            this.InPanel.BorderThickness = 1;
            this.InPanel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.InPanel.Items.Add(this.inputGroupHeader2);
            this.InPanel.Items.Add(this.inputLabel6);
            this.InPanel.Items.Add(this.txtProgramID);
            this.InPanel.Items.Add(this.inputLabel7);
            this.InPanel.Items.Add(this.txtProgramNm);
            this.InPanel.Items.Add(this.inputLabel8);
            this.InPanel.Items.Add(this.txtAssembly);
            this.InPanel.Items.Add(this.inputLabel9);
            this.InPanel.Items.Add(this.txtClass);
            this.InPanel.Items.Add(this.inputLabel10);
            this.InPanel.Items.Add(this.cmbType);
            this.InPanel.Items.Add(this.inputLabel11);
            this.InPanel.Items.Add(this.txtProgramDesc);
            this.InPanel.Items.Add(this.inputLabel2);
            this.InPanel.Items.Add(this.chkAuth);
            this.InPanel.Location = new System.Drawing.Point(2, 109);
            this.InPanel.Name = "InPanel";
            this.InPanel.Size = new System.Drawing.Size(754, 214);
            this.InPanel.TabIndex = 22;
            this.InPanel.ToolTipSettings.Images.Add(new C1.Win.C1InputPanel.ImageEntry("topBgBlue2.png", ((System.Drawing.Image)(resources.GetObject("InPanel.ToolTipSettings.Images")))));
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader2.ElementHeight = 28;
            this.inputGroupHeader2.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader2.Height = 28;
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "입력 항목";
            // 
            // inputLabel6
            // 
            this.inputLabel6.ForeColor = System.Drawing.Color.Black;
            this.inputLabel6.Name = "inputLabel6";
            this.inputLabel6.Text = "프로그램 ID";
            this.inputLabel6.Width = 80;
            // 
            // txtProgramID
            // 
            this.txtProgramID.Enabled = false;
            this.txtProgramID.MaxLength = 10;
            this.txtProgramID.Name = "txtProgramID";
            this.txtProgramID.Width = 150;
            // 
            // inputLabel7
            // 
            this.inputLabel7.ForeColor = System.Drawing.Color.Black;
            this.inputLabel7.Name = "inputLabel7";
            this.inputLabel7.Text = "프로그램 명";
            this.inputLabel7.Width = 80;
            // 
            // txtProgramNm
            // 
            this.txtProgramNm.MaxLength = 100;
            this.txtProgramNm.Name = "txtProgramNm";
            this.txtProgramNm.Width = 250;
            // 
            // inputLabel8
            // 
            this.inputLabel8.ForeColor = System.Drawing.Color.Black;
            this.inputLabel8.Name = "inputLabel8";
            this.inputLabel8.Text = "Assembly명";
            this.inputLabel8.Width = 80;
            // 
            // txtAssembly
            // 
            this.txtAssembly.Name = "txtAssembly";
            this.txtAssembly.Width = 250;
            // 
            // inputLabel9
            // 
            this.inputLabel9.ForeColor = System.Drawing.Color.Black;
            this.inputLabel9.Name = "inputLabel9";
            this.inputLabel9.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inputLabel9.Text = "Class 명";
            this.inputLabel9.Width = 80;
            // 
            // txtClass
            // 
            this.txtClass.Name = "txtClass";
            this.txtClass.Width = 150;
            // 
            // inputLabel10
            // 
            this.inputLabel10.ForeColor = System.Drawing.Color.Black;
            this.inputLabel10.Name = "inputLabel10";
            this.inputLabel10.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.inputLabel10.Text = "타입";
            this.inputLabel10.Width = 80;
            // 
            // cmbType
            // 
            this.cmbType.Items.Add(this.inputOption1);
            this.cmbType.Items.Add(this.inputOption2);
            this.cmbType.Name = "cmbType";
            // 
            // inputOption1
            // 
            this.inputOption1.Name = "inputOption1";
            this.inputOption1.Text = "CONTENT";
            // 
            // inputOption2
            // 
            this.inputOption2.Name = "inputOption2";
            this.inputOption2.Text = "POPUP";
            // 
            // inputLabel11
            // 
            this.inputLabel11.ForeColor = System.Drawing.Color.Black;
            this.inputLabel11.Name = "inputLabel11";
            this.inputLabel11.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.inputLabel11.Text = "설명";
            this.inputLabel11.Width = 80;
            // 
            // txtProgramDesc
            // 
            this.txtProgramDesc.Name = "txtProgramDesc";
            this.txtProgramDesc.Width = 500;
            // 
            // inputLabel2
            // 
            this.inputLabel2.ForeColor = System.Drawing.Color.Black;
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.inputLabel2.Text = "권한 설정";
            this.inputLabel2.Width = 80;
            // 
            // chkAuth
            // 
            this.chkAuth.Name = "chkAuth";
            // 
            // fxPgmList
            // 
            this.fxPgmList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
            this.fxPgmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxPgmList.AutoClipboard = true;
            this.fxPgmList.BackColor = System.Drawing.Color.White;
            this.fxPgmList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxPgmList.ColumnInfo = "5,1,0,0,0,100,Columns:4{StyleFixed:\"BackColor:Control;ForeColor:Black;Margins:1, " +
    "0, 0, 0;TextEffect:Flat;TextDirection:Normal;Trimming:None;\";}\t";
            this.fxPgmList.EditOptions = C1.Win.C1FlexGrid.EditFlags.None;
            this.fxPgmList.ForeColor = System.Drawing.Color.Black;
            this.fxPgmList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxPgmList.Location = new System.Drawing.Point(2, 358);
            this.fxPgmList.Name = "fxPgmList";
            this.fxPgmList.NewRowWatermark = "*";
            this.fxPgmList.Rows.Count = 1;
            this.fxPgmList.Rows.DefaultSize = 20;
            this.fxPgmList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxPgmList.Size = new System.Drawing.Size(754, 276);
            this.fxPgmList.StyleInfo = resources.GetString("fxPgmList.StyleInfo");
            this.fxPgmList.TabIndex = 20;
            this.fxPgmList.RowColChange += new System.EventHandler(this.fxPgmList_RowColChange);
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ElementHeight = 28;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "메세지 리스트";
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.BackColor = System.Drawing.Color.White;
            this.c1InputPanel1.BorderThickness = 1;
            this.c1InputPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader4);
            this.c1InputPanel1.Location = new System.Drawing.Point(2, 327);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(755, 34);
            this.c1InputPanel1.TabIndex = 41;
            // 
            // inputGroupHeader4
            // 
            this.inputGroupHeader4.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader4.ElementHeight = 28;
            this.inputGroupHeader4.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader4.Name = "inputGroupHeader4";
            this.inputGroupHeader4.Text = "프로그램 리스트";
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.Transparent;
            this.commonButton1.BindingGrid = false;
            this.commonButton1.BindingGridControl = null;
            this.commonButton1.DelCol = 0;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(2, 5);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(754, 40);
            this.commonButton1.TabIndex = 29;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            this.commonButton1.OnDeleteClick += new System.EventHandler(this.commonButton1_OnDeleteClick);
            this.commonButton1.OnNewClick += new System.EventHandler(this.commonButton1_OnNewClick);
            // 
            // PgmMgmt
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.c1InputPanel1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.InPanel);
            this.Controls.Add(this.fxPgmList);
            this.Name = "PgmMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.PgmMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxPgmList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel pnlSearch;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputTextBox searchProgram;
        private C1.Win.C1InputPanel.InputLabel inputLabel5;
        private C1.Win.C1InputPanel.InputTextBox searchProgramNm;
        private C1.Win.C1InputPanel.C1InputPanel InPanel;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputLabel inputLabel6;
        private C1.Win.C1InputPanel.InputTextBox txtProgramID;
        private C1.Win.C1InputPanel.InputLabel inputLabel7;
        private C1.Win.C1InputPanel.InputTextBox txtProgramNm;
        private C1.Win.C1InputPanel.InputLabel inputLabel8;
        private C1.Win.C1InputPanel.InputTextBox txtAssembly;
        private C1.Win.C1InputPanel.InputLabel inputLabel9;
        private C1.Win.C1InputPanel.InputTextBox txtClass;
        private C1.Win.C1InputPanel.InputLabel inputLabel10;
        private C1.Win.C1InputPanel.InputComboBox cmbType;
        private C1.Win.C1InputPanel.InputOption inputOption1;
        private C1.Win.C1InputPanel.InputOption inputOption2;
        private C1.Win.C1InputPanel.InputLabel inputLabel11;
        private C1.Win.C1InputPanel.InputTextBox txtProgramDesc;
        private C1.Win.C1FlexGrid.C1FlexGrid fxPgmList;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1InputPanel.InputLabel inputLabel2;
        private C1.Win.C1InputPanel.InputCheckBox chkAuth;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader3;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader4;

    }
}
