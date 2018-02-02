namespace SK.WMS.SM.UI
{
    partial class AuthGrpMgmt
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthGrpMgmt));
            this.InPanel = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel6 = new C1.Win.C1InputPanel.InputLabel();
            this.txtAuthID = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel7 = new C1.Win.C1InputPanel.InputLabel();
            this.txtAuthNm = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel11 = new C1.Win.C1InputPanel.InputLabel();
            this.txtAuthDesc = new C1.Win.C1InputPanel.InputTextBox();
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.fxAuth = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuth)).BeginInit();
            this.SuspendLayout();
            // 
            // InPanel
            // 
            this.InPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InPanel.BackColor = System.Drawing.Color.White;
            this.InPanel.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.InPanel.Items.Add(this.inputGroupHeader2);
            this.InPanel.Items.Add(this.inputLabel6);
            this.InPanel.Items.Add(this.txtAuthID);
            this.InPanel.Items.Add(this.inputLabel7);
            this.InPanel.Items.Add(this.txtAuthNm);
            this.InPanel.Items.Add(this.inputLabel11);
            this.InPanel.Items.Add(this.txtAuthDesc);
            this.InPanel.Location = new System.Drawing.Point(1, 420);
            this.InPanel.Name = "InPanel";
            this.InPanel.Size = new System.Drawing.Size(755, 190);
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
            // inputLabel6
            // 
            this.inputLabel6.ForeColor = System.Drawing.Color.Black;
            this.inputLabel6.Name = "inputLabel6";
            this.inputLabel6.Text = "권한 ID";
            this.inputLabel6.Width = 100;
            // 
            // txtAuthID
            // 
            this.txtAuthID.Enabled = false;
            this.txtAuthID.MaxLength = 10;
            this.txtAuthID.Name = "txtAuthID";
            this.txtAuthID.Width = 150;
            // 
            // inputLabel7
            // 
            this.inputLabel7.ForeColor = System.Drawing.Color.Black;
            this.inputLabel7.Name = "inputLabel7";
            this.inputLabel7.Text = "권한그룹 명";
            this.inputLabel7.Width = 100;
            this.inputLabel7.DoubleClick += new System.EventHandler(this.inputLabel7_DoubleClick);
            // 
            // txtAuthNm
            // 
            this.txtAuthNm.MaxLength = 100;
            this.txtAuthNm.Name = "txtAuthNm";
            this.txtAuthNm.Width = 250;
            // 
            // inputLabel11
            // 
            this.inputLabel11.ForeColor = System.Drawing.Color.Black;
            this.inputLabel11.Name = "inputLabel11";
            this.inputLabel11.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.inputLabel11.Text = "설명";
            this.inputLabel11.Width = 100;
            // 
            // txtAuthDesc
            // 
            this.txtAuthDesc.Name = "txtAuthDesc";
            this.txtAuthDesc.Width = 500;
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.BackColor = System.Drawing.Color.White;
            this.c1InputPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.c1InputPanel1.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel1.Location = new System.Drawing.Point(2, 49);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(754, 32);
            this.c1InputPanel1.TabIndex = 21;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ElementHeight = 28;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Height = 28;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "권한그룹 리스트";
            // 
            // fxAuth
            // 
            this.fxAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxAuth.AutoClipboard = true;
            this.fxAuth.BackColor = System.Drawing.Color.White;
            this.fxAuth.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxAuth.ColumnInfo = "3,1,0,0,0,110,Columns:";
            this.fxAuth.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fxAuth.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxAuth.Location = new System.Drawing.Point(1, 87);
            this.fxAuth.Name = "fxAuth";
            this.fxAuth.Rows.Count = 1;
            this.fxAuth.Rows.DefaultSize = 22;
            this.fxAuth.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxAuth.ShowCellLabels = true;
            this.fxAuth.Size = new System.Drawing.Size(755, 323);
            this.fxAuth.StyleInfo = resources.GetString("fxAuth.StyleInfo");
            this.fxAuth.TabIndex = 20;
            this.fxAuth.RowColChange += new System.EventHandler(this.fxAuth_RowColChange);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.White;
            this.commonButton1.BindingGrid = false;
            this.commonButton1.BindingGridControl = null;
            this.commonButton1.DelCol = 0;
            this.commonButton1.ExcelEnable = false;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(2, 4);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintEnable = false;
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(754, 39);
            this.commonButton1.TabIndex = 24;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            this.commonButton1.OnDeleteClick += new System.EventHandler(this.commonButton1_OnDeleteClick);
            this.commonButton1.OnExcelClick += new System.EventHandler(this.commonButton1_OnExcelClick);
            this.commonButton1.OnPrintClick += new System.EventHandler(this.commonButton1_OnPrintClick);
            this.commonButton1.OnNewClick += new System.EventHandler(this.commonButton1_OnNewClick);
            // 
            // AuthGrpMgmt
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.InPanel);
            this.Controls.Add(this.c1InputPanel1);
            this.Controls.Add(this.fxAuth);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "AuthGrpMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.AuthGrpMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxAuth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel InPanel;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputLabel inputLabel6;
        private C1.Win.C1InputPanel.InputTextBox txtAuthID;
        private C1.Win.C1InputPanel.InputLabel inputLabel7;
        private C1.Win.C1InputPanel.InputTextBox txtAuthNm;
        private C1.Win.C1InputPanel.InputLabel inputLabel11;
        private C1.Win.C1InputPanel.InputTextBox txtAuthDesc;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1FlexGrid.C1FlexGrid fxAuth;
        private WinControls.CommonButton commonButton1;
        private System.Windows.Forms.ImageList imageList1;





    }
}
