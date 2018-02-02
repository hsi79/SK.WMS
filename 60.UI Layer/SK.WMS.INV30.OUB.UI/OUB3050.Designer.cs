namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3050
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3050));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skDockingTab1 = new SK.WMS.WinControls.SKDockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView3 = new SK.WMS.WinControls.SKGridView();
            this.skGridView4 = new SK.WMS.WinControls.SKGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).BeginInit();
            this.skDockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            this.c1DockingTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView4)).BeginInit();
            this.SuspendLayout();
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
            this.commonButton1.Location = new System.Drawing.Point(265, 0);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(528, 34);
            this.commonButton1.TabIndex = 1;
            // 
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(3, 13);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(59, 21);
            this.skLabel1.TabIndex = 2;
            this.skLabel1.Text = "전표발행";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skComboBox1
            // 
            this.skComboBox1.AddItemSeparator = ';';
            this.skComboBox1.AutoCompletion = true;
            this.skComboBox1.AutoDropDown = true;
            this.skComboBox1.AutoSize = false;
            this.skComboBox1.Caption = "";
            this.skComboBox1.CaptionHeight = 17;
            this.skComboBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.skComboBox1.ColumnCaptionHeight = 18;
            this.skComboBox1.ColumnFooterHeight = 18;
            this.skComboBox1.ColumnHeaders = false;
            this.skComboBox1.ContentHeight = 15;
            this.skComboBox1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.skComboBox1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.skComboBox1.EditorFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.skComboBox1.EditorHeight = 15;
            this.skComboBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox1.Images.Add(((System.Drawing.Image)(resources.GetObject("skComboBox1.Images"))));
            this.skComboBox1.ItemHeight = 15;
            this.skComboBox1.Location = new System.Drawing.Point(68, 13);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(100, 21);
            this.skComboBox1.TabIndex = 3;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skDockingTab1
            // 
            this.skDockingTab1.BackColor = System.Drawing.Color.White;
            this.skDockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.skDockingTab1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDockingTab1.ForeColor = System.Drawing.Color.Black;
            this.skDockingTab1.Location = new System.Drawing.Point(6, 41);
            this.skDockingTab1.Name = "skDockingTab1";
            this.skDockingTab1.SelectedIndex = 2;
            this.skDockingTab1.Size = new System.Drawing.Size(397, 495);
            this.skDockingTab1.TabIndex = 4;
            this.skDockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.skDockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.skGridView1);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(395, 467);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "RACK";
            // 
            // skGridView1
            // 
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = "6,1,0,0,0,110,Columns:1{Width:61;Caption:\"배차번호\";}\t2{Width:36;Caption:\"상태\";}\t3{Wid" +
                "th:86;Caption:\"차량카드번호\";}\t4{Width:61;Caption:\"차량번호\";}\t5{Width:45;Caption:\"DOCK\";}" +
                "\t";
            this.skGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skGridView1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView1.Location = new System.Drawing.Point(0, 0);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(395, 467);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 0;
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.skGridView3);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(395, 467);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "야적";
            // 
            // skGridView3
            // 
            this.skGridView3.AutoClipboard = true;
            this.skGridView3.BackColor = System.Drawing.Color.White;
            this.skGridView3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView3.ColumnInfo = "6,1,0,0,0,110,Columns:1{Width:61;Caption:\"배차번호\";}\t2{Width:36;Caption:\"상태\";}\t3{Wid" +
                "th:86;Caption:\"차량카드번호\";}\t4{Width:61;Caption:\"차량번호\";}\t5{Width:45;Caption:\"DOCK\";}" +
                "\t";
            this.skGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skGridView3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView3.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView3.Location = new System.Drawing.Point(0, 0);
            this.skGridView3.Name = "skGridView3";
            this.skGridView3.Rows.Count = 1;
            this.skGridView3.Rows.DefaultSize = 20;
            this.skGridView3.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView3.ShowCellLabels = true;
            this.skGridView3.Size = new System.Drawing.Size(395, 467);
            this.skGridView3.StyleInfo = resources.GetString("skGridView3.StyleInfo");
            this.skGridView3.TabIndex = 1;
            // 
            // skGridView4
            // 
            this.skGridView4.AutoClipboard = true;
            this.skGridView4.BackColor = System.Drawing.Color.White;
            this.skGridView4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView4.ColumnInfo = "7,1,0,0,0,110,Columns:1{Width:61;Caption:\"업체코드\";}\t2{Width:49;Caption:\"업체명\";}\t3{Wi" +
                "dth:61;Caption:\"제품코드\";}\t4{Width:49;Caption:\"제품명\";}\t5{Width:36;Caption:\"수량\";}\t6{C" +
                "aption:\"DOCK\";}\t";
            this.skGridView4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView4.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView4.Location = new System.Drawing.Point(409, 41);
            this.skGridView4.Name = "skGridView4";
            this.skGridView4.Rows.Count = 1;
            this.skGridView4.Rows.DefaultSize = 20;
            this.skGridView4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView4.ShowCellLabels = true;
            this.skGridView4.Size = new System.Drawing.Size(384, 494);
            this.skGridView4.StyleInfo = resources.GetString("skGridView4.StyleInfo");
            this.skGridView4.TabIndex = 5;
            // 
            // OUB3050
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skGridView4);
            this.Controls.Add(this.skDockingTab1);
            this.Controls.Add(this.skComboBox1);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.commonButton1);
            this.Name = "OUB3050";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).EndInit();
            this.skDockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.c1DockingTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKDockingTab skDockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private WinControls.SKGridView skGridView1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        private WinControls.SKGridView skGridView3;
        private WinControls.SKGridView skGridView4;
    }
}
