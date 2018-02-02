namespace SK.WMS.INV40.MNG.UI
{
    partial class MNG4040
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MNG4040));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skDockingTab1 = new SK.WMS.WinControls.SKDockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView3 = new SK.WMS.WinControls.SKGridView();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView4 = new SK.WMS.WinControls.SKGridView();
            this.c1DockingTabPage4 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skCheckBox1 = new SK.WMS.WinControls.SKCheckBox();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.skButton2 = new SK.WMS.WinControls.SKButton();
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).BeginInit();
            this.skDockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            this.c1DockingTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView3)).BeginInit();
            this.c1DockingTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView4)).BeginInit();
            this.c1DockingTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
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
            // skDockingTab1
            // 
            this.skDockingTab1.BackColor = System.Drawing.Color.White;
            this.skDockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage3);
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage4);
            this.skDockingTab1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDockingTab1.ForeColor = System.Drawing.Color.Black;
            this.skDockingTab1.Location = new System.Drawing.Point(3, 88);
            this.skDockingTab1.Name = "skDockingTab1";
            this.skDockingTab1.SelectedIndex = 3;
            this.skDockingTab1.Size = new System.Drawing.Size(790, 423);
            this.skDockingTab1.TabIndex = 2;
            this.skDockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.skDockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.skGridView1);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(788, 395);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "1열(재배치전)";
            // 
            // skGridView1
            // 
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = resources.GetString("skGridView1.ColumnInfo");
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
            this.skGridView1.Size = new System.Drawing.Size(788, 395);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 1;
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.skGridView3);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(788, 395);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "2열(재배치전)";
            // 
            // skGridView3
            // 
            this.skGridView3.AutoClipboard = true;
            this.skGridView3.BackColor = System.Drawing.Color.White;
            this.skGridView3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView3.ColumnInfo = resources.GetString("skGridView3.ColumnInfo");
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
            this.skGridView3.Size = new System.Drawing.Size(788, 395);
            this.skGridView3.StyleInfo = resources.GetString("skGridView3.StyleInfo");
            this.skGridView3.TabIndex = 1;
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Controls.Add(this.skGridView4);
            this.c1DockingTabPage3.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(788, 395);
            this.c1DockingTabPage3.TabIndex = 2;
            this.c1DockingTabPage3.Text = "1열(재배치예상)";
            // 
            // skGridView4
            // 
            this.skGridView4.AutoClipboard = true;
            this.skGridView4.BackColor = System.Drawing.Color.White;
            this.skGridView4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView4.ColumnInfo = resources.GetString("skGridView4.ColumnInfo");
            this.skGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skGridView4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView4.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView4.Location = new System.Drawing.Point(0, 0);
            this.skGridView4.Name = "skGridView4";
            this.skGridView4.Rows.Count = 1;
            this.skGridView4.Rows.DefaultSize = 20;
            this.skGridView4.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView4.ShowCellLabels = true;
            this.skGridView4.Size = new System.Drawing.Size(788, 395);
            this.skGridView4.StyleInfo = resources.GetString("skGridView4.StyleInfo");
            this.skGridView4.TabIndex = 1;
            // 
            // c1DockingTabPage4
            // 
            this.c1DockingTabPage4.Controls.Add(this.skGridView2);
            this.c1DockingTabPage4.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage4.Name = "c1DockingTabPage4";
            this.c1DockingTabPage4.Size = new System.Drawing.Size(788, 395);
            this.c1DockingTabPage4.TabIndex = 3;
            this.c1DockingTabPage4.Text = "2열(재배치예상)";
            // 
            // skGridView2
            // 
            this.skGridView2.AutoClipboard = true;
            this.skGridView2.BackColor = System.Drawing.Color.White;
            this.skGridView2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView2.ColumnInfo = resources.GetString("skGridView2.ColumnInfo");
            this.skGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skGridView2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView2.Location = new System.Drawing.Point(0, 0);
            this.skGridView2.Name = "skGridView2";
            this.skGridView2.Rows.Count = 1;
            this.skGridView2.Rows.DefaultSize = 20;
            this.skGridView2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView2.ShowCellLabels = true;
            this.skGridView2.Size = new System.Drawing.Size(788, 395);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 1;
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(3, 59);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(80, 21);
            this.skLabel2.TabIndex = 4;
            this.skLabel2.Text = "Stacker";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.skComboBox1.Location = new System.Drawing.Point(89, 59);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(100, 21);
            this.skComboBox1.TabIndex = 5;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skLabel3
            // 
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(207, 59);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(80, 21);
            this.skLabel3.TabIndex = 4;
            this.skLabel3.Text = "사용로직";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skCheckBox1
            // 
            this.skCheckBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCheckBox1.Location = new System.Drawing.Point(293, 58);
            this.skCheckBox1.Name = "skCheckBox1";
            this.skCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.skCheckBox1.TabIndex = 6;
            this.skCheckBox1.Text = "2Fair 정렬";
            this.skCheckBox1.UseVisualStyleBackColor = true;
            // 
            // skButton1
            // 
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(15, 9);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 7;
            this.skButton1.Text = "재배치계산";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // skButton2
            // 
            this.skButton2.BackColor = System.Drawing.Color.White;
            this.skButton2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton2.Image = ((System.Drawing.Image)(resources.GetObject("skButton2.Image")));
            this.skButton2.Location = new System.Drawing.Point(98, 9);
            this.skButton2.Name = "skButton2";
            this.skButton2.Size = new System.Drawing.Size(77, 25);
            this.skButton2.TabIndex = 7;
            this.skButton2.Text = "재배치";
            this.skButton2.UseVisualStyleBackColor = true;
            this.skButton2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // MNG4040
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skButton2);
            this.Controls.Add(this.skButton1);
            this.Controls.Add(this.skCheckBox1);
            this.Controls.Add(this.skComboBox1);
            this.Controls.Add(this.skLabel3);
            this.Controls.Add(this.skLabel2);
            this.Controls.Add(this.skDockingTab1);
            this.Controls.Add(this.commonButton1);
            this.Name = "MNG4040";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).EndInit();
            this.skDockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.c1DockingTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView3)).EndInit();
            this.c1DockingTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView4)).EndInit();
            this.c1DockingTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private WinControls.SKDockingTab skDockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKCheckBox skCheckBox1;
        private WinControls.SKButton skButton1;
        private WinControls.SKButton skButton2;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage4;
        private WinControls.SKGridView skGridView1;
        private WinControls.SKGridView skGridView3;
        private WinControls.SKGridView skGridView4;
        private WinControls.SKGridView skGridView2;
    }
}
