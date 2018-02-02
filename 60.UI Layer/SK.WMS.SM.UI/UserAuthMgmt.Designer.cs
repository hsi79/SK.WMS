namespace SK.WMS.SM.UI
{
    partial class UserAuthMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAuthMgmt));
            this.c1InputPanel2 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxAuthList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.pnlSearch = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader3 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.searchUserNm = new C1.Win.C1InputPanel.InputTextBox();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxUserList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuthList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel2
            // 
            this.c1InputPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel2.BackColor = System.Drawing.Color.White;
            this.c1InputPanel2.BorderColor = System.Drawing.Color.White;
            this.c1InputPanel2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel2.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel2.Location = new System.Drawing.Point(390, 111);
            this.c1InputPanel2.Name = "c1InputPanel2";
            this.c1InputPanel2.Size = new System.Drawing.Size(366, 32);
            this.c1InputPanel2.TabIndex = 26;
            // 
            // inputGroupHeader2
            // 
            this.inputGroupHeader2.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader2.ElementHeight = 28;
            this.inputGroupHeader2.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader2.Height = 28;
            this.inputGroupHeader2.Name = "inputGroupHeader2";
            this.inputGroupHeader2.Text = "권한그룹";
            // 
            // fxAuthList
            // 
            this.fxAuthList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxAuthList.AutoClipboard = true;
            this.fxAuthList.BackColor = System.Drawing.Color.White;
            this.fxAuthList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxAuthList.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxAuthList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxAuthList.Location = new System.Drawing.Point(389, 147);
            this.fxAuthList.Name = "fxAuthList";
            this.fxAuthList.Rows.Count = 1;
            this.fxAuthList.Rows.DefaultSize = 20;
            this.fxAuthList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxAuthList.ShowCellLabels = true;
            this.fxAuthList.Size = new System.Drawing.Size(367, 503);
            this.fxAuthList.StyleInfo = resources.GetString("fxAuthList.StyleInfo");
            this.fxAuthList.TabIndex = 25;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderThickness = 1;
            this.pnlSearch.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.pnlSearch.Items.Add(this.inputGroupHeader3);
            this.pnlSearch.Items.Add(this.inputLabel1);
            this.pnlSearch.Items.Add(this.searchUserNm);
            this.pnlSearch.Location = new System.Drawing.Point(2, 46);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(754, 60);
            this.pnlSearch.TabIndex = 23;
            // 
            // inputGroupHeader3
            // 
            this.inputGroupHeader3.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader3.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader3.Name = "inputGroupHeader3";
            this.inputGroupHeader3.Text = "검색 조건";
            // 
            // inputLabel1
            // 
            this.inputLabel1.ForeColor = System.Drawing.Color.Black;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "사용자 명";
            this.inputLabel1.Width = 80;
            // 
            // searchUserNm
            // 
            this.searchUserNm.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.searchUserNm.ForeColor = System.Drawing.Color.Black;
            this.searchUserNm.Name = "searchUserNm";
            this.searchUserNm.Width = 150;
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.BackColor = System.Drawing.Color.White;
            this.c1InputPanel1.BorderColor = System.Drawing.Color.White;
            this.c1InputPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Location = new System.Drawing.Point(1, 111);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(367, 32);
            this.c1InputPanel1.TabIndex = 21;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ElementHeight = 28;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Height = 28;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "사용자";
            // 
            // fxUserList
            // 
            this.fxUserList.AutoClipboard = true;
            this.fxUserList.BackColor = System.Drawing.Color.White;
            this.fxUserList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxUserList.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxUserList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxUserList.Location = new System.Drawing.Point(0, 147);
            this.fxUserList.Name = "fxUserList";
            this.fxUserList.Rows.Count = 1;
            this.fxUserList.Rows.DefaultSize = 20;
            this.fxUserList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxUserList.ShowCellLabels = true;
            this.fxUserList.Size = new System.Drawing.Size(367, 506);
            this.fxUserList.StyleInfo = resources.GetString("fxUserList.StyleInfo");
            this.fxUserList.TabIndex = 20;
            this.fxUserList.RowColChange += new System.EventHandler(this.fxUserLIst_RowColChange);
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.Transparent;
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
            this.commonButton1.Size = new System.Drawing.Size(754, 40);
            this.commonButton1.TabIndex = 24;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            // 
            // UserAuthMgmt
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.c1InputPanel2);
            this.Controls.Add(this.fxAuthList);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.c1InputPanel1);
            this.Controls.Add(this.fxUserList);
            this.Name = "UserAuthMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.UserAuthMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuthList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel pnlSearch;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputTextBox searchUserNm;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1FlexGrid.C1FlexGrid fxUserList;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel2;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1FlexGrid.C1FlexGrid fxAuthList;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader3;
    }
}
