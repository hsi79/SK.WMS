namespace SK.WMS.INV40.MNG.UI
{
    partial class MNG4010
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MNG4010));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.skPanel1 = new SK.WMS.WinControls.SKPanel();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skComboBox4 = new SK.WMS.WinControls.SKComboBox();
            this.skComboBox3 = new SK.WMS.WinControls.SKComboBox();
            this.skComboBox2 = new SK.WMS.WinControls.SKComboBox();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skLabel6 = new SK.WMS.WinControls.SKLabel();
            this.skLabel5 = new SK.WMS.WinControls.SKLabel();
            this.skLabel4 = new SK.WMS.WinControls.SKLabel();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            this.skPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skGridView1
            // 
            this.skGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = resources.GetString("skGridView1.ColumnInfo");
            this.skGridView1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView1.Location = new System.Drawing.Point(3, 102);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(790, 434);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 0;
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
            // skButton1
            // 
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(3, 9);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 2;
            this.skButton1.Text = "S/C재작업";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // skPanel1
            // 
            this.skPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skPanel1.Controls.Add(this.skTextBox1);
            this.skPanel1.Controls.Add(this.skComboBox4);
            this.skPanel1.Controls.Add(this.skComboBox3);
            this.skPanel1.Controls.Add(this.skComboBox2);
            this.skPanel1.Controls.Add(this.skComboBox1);
            this.skPanel1.Controls.Add(this.skLabel6);
            this.skPanel1.Controls.Add(this.skLabel5);
            this.skPanel1.Controls.Add(this.skLabel4);
            this.skPanel1.Controls.Add(this.skLabel3);
            this.skPanel1.Controls.Add(this.skLabel2);
            this.skPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skPanel1.Location = new System.Drawing.Point(3, 40);
            this.skPanel1.Name = "skPanel1";
            this.skPanel1.Size = new System.Drawing.Size(790, 56);
            this.skPanel1.TabIndex = 3;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(338, 5);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(118, 21);
            this.skTextBox1.TabIndex = 3;
            this.skTextBox1.Tag = null;
            this.skTextBox1.Text = "skTextBox1";
            this.skTextBox1.TextDetached = true;
            // 
            // skComboBox4
            // 
            this.skComboBox4.AddItemSeparator = ';';
            this.skComboBox4.AutoCompletion = true;
            this.skComboBox4.AutoDropDown = true;
            this.skComboBox4.AutoSize = false;
            this.skComboBox4.Caption = "";
            this.skComboBox4.CaptionHeight = 17;
            this.skComboBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.skComboBox4.ColumnCaptionHeight = 18;
            this.skComboBox4.ColumnFooterHeight = 18;
            this.skComboBox4.ColumnHeaders = false;
            this.skComboBox4.ContentHeight = 15;
            this.skComboBox4.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.skComboBox4.EditorBackColor = System.Drawing.SystemColors.Window;
            this.skComboBox4.EditorFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox4.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.skComboBox4.EditorHeight = 15;
            this.skComboBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox4.Images.Add(((System.Drawing.Image)(resources.GetObject("skComboBox4.Images"))));
            this.skComboBox4.ItemHeight = 15;
            this.skComboBox4.Location = new System.Drawing.Point(337, 28);
            this.skComboBox4.MatchEntryTimeout = ((long)(2000));
            this.skComboBox4.MaxDropDownItems = ((short)(5));
            this.skComboBox4.MaxLength = 32767;
            this.skComboBox4.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox4.Name = "skComboBox4";
            this.skComboBox4.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox4.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox4.Size = new System.Drawing.Size(118, 21);
            this.skComboBox4.TabIndex = 2;
            this.skComboBox4.Text = "skComboBox1";
            this.skComboBox4.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox4.PropBag = resources.GetString("skComboBox4.PropBag");
            // 
            // skComboBox3
            // 
            this.skComboBox3.AddItemSeparator = ';';
            this.skComboBox3.AutoCompletion = true;
            this.skComboBox3.AutoDropDown = true;
            this.skComboBox3.AutoSize = false;
            this.skComboBox3.Caption = "";
            this.skComboBox3.CaptionHeight = 17;
            this.skComboBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.skComboBox3.ColumnCaptionHeight = 18;
            this.skComboBox3.ColumnFooterHeight = 18;
            this.skComboBox3.ColumnHeaders = false;
            this.skComboBox3.ContentHeight = 15;
            this.skComboBox3.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.skComboBox3.EditorBackColor = System.Drawing.SystemColors.Window;
            this.skComboBox3.EditorFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox3.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.skComboBox3.EditorHeight = 15;
            this.skComboBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox3.Images.Add(((System.Drawing.Image)(resources.GetObject("skComboBox3.Images"))));
            this.skComboBox3.ItemHeight = 15;
            this.skComboBox3.Location = new System.Drawing.Point(105, 28);
            this.skComboBox3.MatchEntryTimeout = ((long)(2000));
            this.skComboBox3.MaxDropDownItems = ((short)(5));
            this.skComboBox3.MaxLength = 32767;
            this.skComboBox3.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox3.Name = "skComboBox3";
            this.skComboBox3.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox3.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox3.Size = new System.Drawing.Size(118, 21);
            this.skComboBox3.TabIndex = 2;
            this.skComboBox3.Text = "skComboBox1";
            this.skComboBox3.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox3.PropBag = resources.GetString("skComboBox3.PropBag");
            // 
            // skComboBox2
            // 
            this.skComboBox2.AddItemSeparator = ';';
            this.skComboBox2.AutoCompletion = true;
            this.skComboBox2.AutoDropDown = true;
            this.skComboBox2.AutoSize = false;
            this.skComboBox2.Caption = "";
            this.skComboBox2.CaptionHeight = 17;
            this.skComboBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.skComboBox2.ColumnCaptionHeight = 18;
            this.skComboBox2.ColumnFooterHeight = 18;
            this.skComboBox2.ColumnHeaders = false;
            this.skComboBox2.ContentHeight = 15;
            this.skComboBox2.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.skComboBox2.EditorBackColor = System.Drawing.SystemColors.Window;
            this.skComboBox2.EditorFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox2.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.skComboBox2.EditorHeight = 15;
            this.skComboBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox2.Images.Add(((System.Drawing.Image)(resources.GetObject("skComboBox2.Images"))));
            this.skComboBox2.ItemHeight = 15;
            this.skComboBox2.Location = new System.Drawing.Point(105, 3);
            this.skComboBox2.MatchEntryTimeout = ((long)(2000));
            this.skComboBox2.MaxDropDownItems = ((short)(5));
            this.skComboBox2.MaxLength = 32767;
            this.skComboBox2.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox2.Name = "skComboBox2";
            this.skComboBox2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox2.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox2.Size = new System.Drawing.Size(118, 21);
            this.skComboBox2.TabIndex = 2;
            this.skComboBox2.Text = "skComboBox1";
            this.skComboBox2.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox2.PropBag = resources.GetString("skComboBox2.PropBag");
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
            this.skComboBox1.Location = new System.Drawing.Point(574, 5);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(118, 21);
            this.skComboBox1.TabIndex = 2;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skLabel6
            // 
            this.skLabel6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel6.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel6.Location = new System.Drawing.Point(244, 28);
            this.skLabel6.Name = "skLabel6";
            this.skLabel6.Size = new System.Drawing.Size(87, 21);
            this.skLabel6.TabIndex = 0;
            this.skLabel6.Text = "Bagging Line";
            this.skLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skLabel5
            // 
            this.skLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel5.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel5.Location = new System.Drawing.Point(257, 4);
            this.skLabel5.Name = "skLabel5";
            this.skLabel5.Size = new System.Drawing.Size(67, 21);
            this.skLabel5.TabIndex = 0;
            this.skLabel5.Text = "Batch No";
            this.skLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skLabel4
            // 
            this.skLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel4.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel4.Location = new System.Drawing.Point(32, 28);
            this.skLabel4.Name = "skLabel4";
            this.skLabel4.Size = new System.Drawing.Size(67, 21);
            this.skLabel4.TabIndex = 0;
            this.skLabel4.Text = "DOCK";
            this.skLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skLabel3
            // 
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(32, 4);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(67, 21);
            this.skLabel3.TabIndex = 0;
            this.skLabel3.Text = "작업유형";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(501, 5);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(67, 21);
            this.skLabel2.TabIndex = 0;
            this.skLabel2.Text = "S/C호기";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MNG4010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skPanel1);
            this.Controls.Add(this.skButton1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skGridView1);
            this.Name = "MNG4010";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.skPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKButton skButton1;
        private WinControls.SKPanel skPanel1;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKComboBox skComboBox4;
        private WinControls.SKComboBox skComboBox3;
        private WinControls.SKComboBox skComboBox2;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKLabel skLabel6;
        private WinControls.SKLabel skLabel5;
        private WinControls.SKLabel skLabel4;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKLabel skLabel2;
    }
}
