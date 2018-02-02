namespace SK.WMS.SM.UI
{
    partial class AuthUserMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthUserMgmt));
            this.c1InputPanel3 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader3 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxAuthPgmList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1InputPanel2 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxAuthList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxUserList = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuthPgmList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuthList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel3
            // 
            this.c1InputPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel3.BackColor = System.Drawing.Color.White;
            this.c1InputPanel3.BorderColor = System.Drawing.Color.White;
            this.c1InputPanel3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel3.Items.Add(this.inputGroupHeader3);
            this.c1InputPanel3.Location = new System.Drawing.Point(2, 309);
            this.c1InputPanel3.Name = "c1InputPanel3";
            this.c1InputPanel3.Size = new System.Drawing.Size(754, 32);
            this.c1InputPanel3.TabIndex = 30;
            // 
            // inputGroupHeader3
            // 
            this.inputGroupHeader3.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader3.ElementHeight = 28;
            this.inputGroupHeader3.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader3.Height = 28;
            this.inputGroupHeader3.Name = "inputGroupHeader3";
            this.inputGroupHeader3.Text = "프로그램";
            // 
            // fxAuthPgmList
            // 
            this.fxAuthPgmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxAuthPgmList.AutoClipboard = true;
            this.fxAuthPgmList.BackColor = System.Drawing.Color.White;
            this.fxAuthPgmList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxAuthPgmList.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxAuthPgmList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxAuthPgmList.Location = new System.Drawing.Point(2, 341);
            this.fxAuthPgmList.Name = "fxAuthPgmList";
            this.fxAuthPgmList.Rows.Count = 1;
            this.fxAuthPgmList.Rows.DefaultSize = 20;
            this.fxAuthPgmList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxAuthPgmList.ShowCellLabels = true;
            this.fxAuthPgmList.Size = new System.Drawing.Size(754, 325);
            this.fxAuthPgmList.StyleInfo = resources.GetString("fxAuthPgmList.StyleInfo");
            this.fxAuthPgmList.TabIndex = 29;
            // 
            // c1InputPanel2
            // 
            this.c1InputPanel2.BackColor = System.Drawing.Color.White;
            this.c1InputPanel2.BorderColor = System.Drawing.Color.White;
            this.c1InputPanel2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel2.Items.Add(this.inputGroupHeader2);
            this.c1InputPanel2.Location = new System.Drawing.Point(2, 49);
            this.c1InputPanel2.Name = "c1InputPanel2";
            this.c1InputPanel2.Size = new System.Drawing.Size(367, 32);
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
            this.fxAuthList.AutoClipboard = true;
            this.fxAuthList.BackColor = System.Drawing.Color.White;
            this.fxAuthList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxAuthList.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxAuthList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxAuthList.Location = new System.Drawing.Point(2, 84);
            this.fxAuthList.Name = "fxAuthList";
            this.fxAuthList.Rows.Count = 1;
            this.fxAuthList.Rows.DefaultSize = 20;
            this.fxAuthList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxAuthList.ShowCellLabels = true;
            this.fxAuthList.Size = new System.Drawing.Size(367, 220);
            this.fxAuthList.StyleInfo = resources.GetString("fxAuthList.StyleInfo");
            this.fxAuthList.TabIndex = 25;
            this.fxAuthList.RowColChange += new System.EventHandler(this.fxAuthList_RowColChange);
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
            this.commonButton1.Location = new System.Drawing.Point(2, 5);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewEnable = false;
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintEnable = false;
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(754, 37);
            this.commonButton1.TabIndex = 24;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.BackColor = System.Drawing.Color.White;
            this.c1InputPanel1.BorderColor = System.Drawing.Color.White;
            this.c1InputPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Location = new System.Drawing.Point(389, 49);
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
            this.fxUserList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxUserList.AutoClipboard = true;
            this.fxUserList.BackColor = System.Drawing.Color.White;
            this.fxUserList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxUserList.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxUserList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxUserList.Location = new System.Drawing.Point(389, 84);
            this.fxUserList.Name = "fxUserList";
            this.fxUserList.Rows.Count = 1;
            this.fxUserList.Rows.DefaultSize = 20;
            this.fxUserList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxUserList.ShowCellLabels = true;
            this.fxUserList.Size = new System.Drawing.Size(367, 220);
            this.fxUserList.StyleInfo = resources.GetString("fxUserList.StyleInfo");
            this.fxUserList.TabIndex = 20;
            // 
            // AuthUserMgmt
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.c1InputPanel3);
            this.Controls.Add(this.fxAuthPgmList);
            this.Controls.Add(this.c1InputPanel2);
            this.Controls.Add(this.fxAuthList);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.c1InputPanel1);
            this.Controls.Add(this.fxUserList);
            this.Name = "AuthUserMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.AuthUserMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuthPgmList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuthList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1FlexGrid.C1FlexGrid fxUserList;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel2;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1FlexGrid.C1FlexGrid fxAuthList;
        private C1.Win.C1FlexGrid.C1FlexGrid fxAuthPgmList;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel3;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader3;
    }
}
