namespace SK.WMS.INV60.CLS.UI
{
    partial class CLS6010
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLS6010));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skPanel1 = new SK.WMS.WinControls.SKPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.skLabel4 = new SK.WMS.WinControls.SKLabel();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skLabel5 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skLabel6 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox2 = new SK.WMS.WinControls.SKTextBox();
            this.helpWindow1 = new SK.WMS.WinControls.HelpWindow();
            this.helpWindow2 = new SK.WMS.WinControls.HelpWindow();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            this.skPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).BeginInit();
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
            this.skGridView1.Location = new System.Drawing.Point(3, 99);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(790, 437);
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
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(3, 42);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(60, 21);
            this.skLabel1.TabIndex = 2;
            this.skLabel1.Text = "마감일자";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(3, 63);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(60, 21);
            this.skLabel2.TabIndex = 2;
            this.skLabel2.Text = "제품코드";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skDateEdit1
            // 
            this.skDateEdit1.AutoSize = false;
            this.skDateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.skDateEdit1.Calendar.DayNameLength = 1;
            this.skDateEdit1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.skDateEdit1.Location = new System.Drawing.Point(69, 42);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit1.TabIndex = 3;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel3
            // 
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(175, 63);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(27, 21);
            this.skLabel3.TabIndex = 2;
            this.skLabel3.Text = "~";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skPanel1
            // 
            this.skPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skPanel1.Controls.Add(this.radioButton2);
            this.skPanel1.Controls.Add(this.radioButton1);
            this.skPanel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skPanel1.Location = new System.Drawing.Point(178, 41);
            this.skPanel1.Name = "skPanel1";
            this.skPanel1.Size = new System.Drawing.Size(156, 22);
            this.skPanel1.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(97, -1);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "합계";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, -1);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "제품코드별";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // skLabel4
            // 
            this.skLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel4.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel4.Location = new System.Drawing.Point(314, 64);
            this.skLabel4.Name = "skLabel4";
            this.skLabel4.Size = new System.Drawing.Size(60, 21);
            this.skLabel4.TabIndex = 2;
            this.skLabel4.Text = "등급";
            this.skLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.skComboBox1.Location = new System.Drawing.Point(380, 64);
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
            // skLabel5
            // 
            this.skLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel5.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel5.Location = new System.Drawing.Point(486, 64);
            this.skLabel5.Name = "skLabel5";
            this.skLabel5.Size = new System.Drawing.Size(60, 21);
            this.skLabel5.TabIndex = 2;
            this.skLabel5.Text = "Batch No";
            this.skLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(552, 64);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(67, 21);
            this.skTextBox1.TabIndex = 6;
            this.skTextBox1.Tag = null;
            this.skTextBox1.TextDetached = true;
            // 
            // skLabel6
            // 
            this.skLabel6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel6.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel6.Location = new System.Drawing.Point(625, 63);
            this.skLabel6.Name = "skLabel6";
            this.skLabel6.Size = new System.Drawing.Size(27, 21);
            this.skLabel6.TabIndex = 2;
            this.skLabel6.Text = "~";
            this.skLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skTextBox2
            // 
            this.skTextBox2.BackColor = System.Drawing.Color.White;
            this.skTextBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox2.ForeColor = System.Drawing.Color.Black;
            this.skTextBox2.Location = new System.Drawing.Point(658, 64);
            this.skTextBox2.Name = "skTextBox2";
            this.skTextBox2.Size = new System.Drawing.Size(67, 21);
            this.skTextBox2.TabIndex = 6;
            this.skTextBox2.Tag = null;
            this.skTextBox2.TextDetached = true;
            // 
            // helpWindow1
            // 
            this.helpWindow1.BackColor = System.Drawing.Color.Transparent;
            this.helpWindow1.DisplayName = null;
            this.helpWindow1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.helpWindow1.InParam = null;
            this.helpWindow1.Location = new System.Drawing.Point(67, 64);
            this.helpWindow1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helpWindow1.Name = "helpWindow1";
            this.helpWindow1.Padding = new System.Windows.Forms.Padding(6);
            this.helpWindow1.PakageName = null;
            this.helpWindow1.Size = new System.Drawing.Size(105, 22);
            this.helpWindow1.TabIndex = 7;
            this.helpWindow1.ValueName = null;
            // 
            // helpWindow2
            // 
            this.helpWindow2.BackColor = System.Drawing.Color.Transparent;
            this.helpWindow2.DisplayName = null;
            this.helpWindow2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.helpWindow2.InParam = null;
            this.helpWindow2.Location = new System.Drawing.Point(203, 64);
            this.helpWindow2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helpWindow2.Name = "helpWindow2";
            this.helpWindow2.Padding = new System.Windows.Forms.Padding(6);
            this.helpWindow2.PakageName = null;
            this.helpWindow2.Size = new System.Drawing.Size(105, 22);
            this.helpWindow2.TabIndex = 7;
            this.helpWindow2.ValueName = null;
            // 
            // CLS6010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helpWindow2);
            this.Controls.Add(this.helpWindow1);
            this.Controls.Add(this.skTextBox2);
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skComboBox1);
            this.Controls.Add(this.skPanel1);
            this.Controls.Add(this.skDateEdit1);
            this.Controls.Add(this.skLabel6);
            this.Controls.Add(this.skLabel3);
            this.Controls.Add(this.skLabel5);
            this.Controls.Add(this.skLabel4);
            this.Controls.Add(this.skLabel2);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skGridView1);
            this.Name = "CLS6010";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            this.skPanel1.ResumeLayout(false);
            this.skPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKPanel skPanel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private WinControls.SKLabel skLabel4;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKLabel skLabel5;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKLabel skLabel6;
        private WinControls.SKTextBox skTextBox2;
        private WinControls.HelpWindow helpWindow1;
        private WinControls.HelpWindow helpWindow2;
    }
}
