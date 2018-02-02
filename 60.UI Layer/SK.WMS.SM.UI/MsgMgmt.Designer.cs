namespace SK.WMS.SM.UI
{
    partial class MsgMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgMgmt));
            this.pnlSearch = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader3 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.searchMessage = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel5 = new C1.Win.C1InputPanel.InputLabel();
            this.searchMessageNm = new C1.Win.C1InputPanel.InputTextBox();
            this.InPanel = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader2 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel6 = new C1.Win.C1InputPanel.InputLabel();
            this.txtMessageID = new C1.Win.C1InputPanel.InputTextBox();
            this.inputLabel11 = new C1.Win.C1InputPanel.InputLabel();
            this.txtMessageKo = new C1.Win.C1InputPanel.InputTextBox();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.fxMessage = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxMessage)).BeginInit();
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
            this.pnlSearch.Items.Add(this.inputLabel1);
            this.pnlSearch.Items.Add(this.searchMessage);
            this.pnlSearch.Items.Add(this.inputLabel5);
            this.pnlSearch.Items.Add(this.searchMessageNm);
            this.pnlSearch.Location = new System.Drawing.Point(2, 45);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(755, 60);
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
            // inputLabel1
            // 
            this.inputLabel1.ForeColor = System.Drawing.Color.Black;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "메세지 ID";
            this.inputLabel1.Width = 80;
            // 
            // searchMessage
            // 
            this.searchMessage.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.searchMessage.ForeColor = System.Drawing.Color.Black;
            this.searchMessage.Name = "searchMessage";
            this.searchMessage.Width = 150;
            // 
            // inputLabel5
            // 
            this.inputLabel5.ForeColor = System.Drawing.Color.Black;
            this.inputLabel5.Name = "inputLabel5";
            this.inputLabel5.Text = "메세지 명";
            this.inputLabel5.Width = 80;
            // 
            // searchMessageNm
            // 
            this.searchMessageNm.Name = "searchMessageNm";
            this.searchMessageNm.Width = 300;
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
            this.InPanel.Items.Add(this.txtMessageID);
            this.InPanel.Items.Add(this.inputLabel11);
            this.InPanel.Items.Add(this.txtMessageKo);
            this.InPanel.Location = new System.Drawing.Point(2, 108);
            this.InPanel.Name = "InPanel";
            this.InPanel.Size = new System.Drawing.Size(755, 90);
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
            this.inputLabel6.Text = "메세지 ID";
            this.inputLabel6.Width = 80;
            // 
            // txtMessageID
            // 
            this.txtMessageID.Enabled = false;
            this.txtMessageID.MaxLength = 10;
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.Width = 150;
            // 
            // inputLabel11
            // 
            this.inputLabel11.ForeColor = System.Drawing.Color.Black;
            this.inputLabel11.Name = "inputLabel11";
            this.inputLabel11.Text = "메세지 명";
            this.inputLabel11.Width = 80;
            // 
            // txtMessageKo
            // 
            this.txtMessageKo.Name = "txtMessageKo";
            this.txtMessageKo.Width = 500;
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.White;
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
            this.commonButton1.Size = new System.Drawing.Size(754, 33);
            this.commonButton1.TabIndex = 24;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            this.commonButton1.OnDeleteClick += new System.EventHandler(this.commonButton1_OnDeleteClick);
            this.commonButton1.OnExcelClick += new System.EventHandler(this.commonButton1_OnExcelClick);
            this.commonButton1.OnPrintClick += new System.EventHandler(this.commonButton1_OnPrintClick);
            this.commonButton1.OnNewClick += new System.EventHandler(this.commonButton1_OnNewClick);
            // 
            // fxMessage
            // 
            this.fxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxMessage.AutoClipboard = true;
            this.fxMessage.BackColor = System.Drawing.Color.White;
            this.fxMessage.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxMessage.ColumnInfo = "3,1,0,0,0,100,Columns:";
            this.fxMessage.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxMessage.Location = new System.Drawing.Point(2, 235);
            this.fxMessage.Name = "fxMessage";
            this.fxMessage.Rows.Count = 1;
            this.fxMessage.Rows.DefaultSize = 20;
            this.fxMessage.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxMessage.ShowCellLabels = true;
            this.fxMessage.Size = new System.Drawing.Size(755, 418);
            this.fxMessage.StyleInfo = resources.GetString("fxMessage.StyleInfo");
            this.fxMessage.TabIndex = 20;
            this.fxMessage.RowColChange += new System.EventHandler(this.fxMessage_RowColChange);

            // 
            // MsgMgmt
            // 
            this.BackColor = System.Drawing.Color.White;
            
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.InPanel);
            this.Controls.Add(this.fxMessage);
            this.Name = "MsgMgmt";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.MsgMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel pnlSearch;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
        private C1.Win.C1InputPanel.InputTextBox searchMessage;
        private C1.Win.C1InputPanel.InputLabel inputLabel5;
        private C1.Win.C1InputPanel.InputTextBox searchMessageNm;
        private C1.Win.C1InputPanel.C1InputPanel InPanel;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader2;
        private C1.Win.C1InputPanel.InputLabel inputLabel6;
        private C1.Win.C1InputPanel.InputTextBox txtMessageID;
        private C1.Win.C1InputPanel.InputLabel inputLabel11;
        private C1.Win.C1InputPanel.InputTextBox txtMessageKo;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader3;
        private C1.Win.C1FlexGrid.C1FlexGrid fxMessage;
        
    }
}
