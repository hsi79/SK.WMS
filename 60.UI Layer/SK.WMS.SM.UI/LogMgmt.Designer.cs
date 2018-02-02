namespace SK.WMS.SM.UI
{
    partial class LogMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogMgmt));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.pnlSearch = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.cmbType = new C1.Win.C1InputPanel.InputComboBox();
            this.inputOption1 = new C1.Win.C1InputPanel.InputOption();
            this.inputOption2 = new C1.Win.C1InputPanel.InputOption();
            this.inputOption3 = new C1.Win.C1InputPanel.InputOption();
            this.inputLabel5 = new C1.Win.C1InputPanel.InputLabel();
            this.Sdate = new C1.Win.C1InputPanel.InputDatePicker();
            this.inputLabel2 = new C1.Win.C1InputPanel.InputLabel();
            this.eDate = new C1.Win.C1InputPanel.InputDatePicker();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxLogList = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxLogList)).BeginInit();
            this.SuspendLayout();
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.White;
            this.commonButton1.BindingGrid = false;
            this.commonButton1.BindingGridControl = null;
            this.commonButton1.DelCol = 0;
            this.commonButton1.DeleteEnable = false;
            this.commonButton1.ExcelEnable = false;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(2, 4);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewEnable = false;
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintEnable = false;
            this.commonButton1.PrintName = "Print";
            this.commonButton1.SaveEnable = false;
            this.commonButton1.Size = new System.Drawing.Size(754, 33);
            this.commonButton1.TabIndex = 30;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.pnlSearch.Items.Add(this.inputGroupHeader2);
            this.pnlSearch.Items.Add(this.inputLabel1);
            this.pnlSearch.Items.Add(this.cmbType);
            this.pnlSearch.Items.Add(this.inputLabel5);
            this.pnlSearch.Items.Add(this.Sdate);
            this.pnlSearch.Items.Add(this.inputLabel2);
            this.pnlSearch.Items.Add(this.eDate);
            this.pnlSearch.Location = new System.Drawing.Point(2, 44);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(754, 90);
            this.pnlSearch.TabIndex = 23;
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader2.ElementHeight = 28;
            this.inputGroupHeader2.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "검색 조건";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "타입";
            this.inputLabel1.Width = 80;
            // 
            // cmbType
            // 
            this.cmbType.Items.Add(this.inputOption1);
            this.cmbType.Items.Add(this.inputOption2);
            this.cmbType.Items.Add(this.inputOption3);
            this.cmbType.Name = "cmbType";
            // 
            // inputOption1
            // 
            this.inputOption1.Name = "inputOption1";
            this.inputOption1.Text = "로그인";
            // 
            // inputOption2
            // 
            this.inputOption2.Name = "inputOption2";
            this.inputOption2.Text = "프로그램";
            // 
            // inputOption3
            // 
            this.inputOption3.Name = "inputOption3";
            this.inputOption3.Text = "버튼";
            // 
            // inputLabel5
            // 
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Text = "일자";
            this.inputLabel5.Width = 80;
            // 
            // Sdate
            // 
            this.Sdate.Break = C1.Win.C1InputPanel.BreakType.None;
            this.Sdate.Name = "Sdate";
            this.Sdate.Width = 120;
            // 
            // inputLabel2
            // 
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Text = "~";
            // 
            // eDate
            // 
            this.eDate.Name = "eDate";
            this.eDate.Width = 120;
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.BackColor = System.Drawing.Color.White;
            this.c1InputPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Location = new System.Drawing.Point(2, 136);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(754, 32);
            this.c1InputPanel1.TabIndex = 21;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ElementHeight = 28;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "로그 리스트";
            // 
            // fxLogList
            // 
            this.fxLogList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxLogList.AutoClipboard = true;
            this.fxLogList.BackColor = System.Drawing.Color.White;
            this.fxLogList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxLogList.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxLogList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxLogList.Location = new System.Drawing.Point(2, 170);
            this.fxLogList.Name = "fxLogList";
            this.fxLogList.Rows.Count = 1;
            this.fxLogList.Rows.DefaultSize = 20;
            this.fxLogList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxLogList.ShowCellLabels = true;
            this.fxLogList.Size = new System.Drawing.Size(754, 498);
            this.fxLogList.StyleInfo = resources.GetString("fxLogList.StyleInfo");
            this.fxLogList.TabIndex = 20;
            // 
            // LogMgmt
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.c1InputPanel1);
            this.Controls.Add(this.fxLogList);
            this.Name = "LogMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.LogMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxLogList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel pnlSearch;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputLabel inputLabel5;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1FlexGrid.C1FlexGrid fxLogList;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1InputPanel.InputComboBox cmbType;
        private C1.Win.C1InputPanel.InputDatePicker Sdate;
        private C1.Win.C1InputPanel.InputLabel inputLabel2;
        private C1.Win.C1InputPanel.InputDatePicker eDate;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputOption inputOption1;
        private C1.Win.C1InputPanel.InputOption inputOption2;
        private C1.Win.C1InputPanel.InputOption inputOption3;
    }
}
