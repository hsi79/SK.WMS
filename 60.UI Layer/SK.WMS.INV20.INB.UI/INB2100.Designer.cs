namespace SK.WMS.INV20.INB.UI
{
    partial class INB2100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INB2100));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skLabel6 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox2 = new SK.WMS.WinControls.SKTextBox();
            this.skLabel5 = new SK.WMS.WinControls.SKLabel();
            this.skDateEdit2 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel4 = new SK.WMS.WinControls.SKLabel();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.helpWindow1 = new SK.WMS.WinControls.HelpWindow();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.skButton2 = new SK.WMS.WinControls.SKButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
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
            this.skGridView1.Size = new System.Drawing.Size(796, 244);
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
            this.tableLayoutPanel1.SetColumnSpan(this.commonButton1, 5);
            this.commonButton1.DelCol = 0;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(205, 4);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(588, 37);
            this.commonButton1.TabIndex = 1;
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
            this.skGridView2.Size = new System.Drawing.Size(796, 187);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 2;
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
            this.skComboBox1.ContentHeight = 18;
            this.skComboBox1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.skComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skComboBox1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.skComboBox1.EditorFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.skComboBox1.EditorHeight = 18;
            this.skComboBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skComboBox1.Images.Add(((System.Drawing.Image)(resources.GetObject("skComboBox1.Images"))));
            this.skComboBox1.ItemHeight = 15;
            this.skComboBox1.Location = new System.Drawing.Point(409, 78);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(104, 24);
            this.skComboBox1.TabIndex = 28;
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skLabel6
            // 
            this.skLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.skLabel6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel6.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel6.Location = new System.Drawing.Point(340, 79);
            this.skLabel6.Name = "skLabel6";
            this.skLabel6.Size = new System.Drawing.Size(63, 21);
            this.skLabel6.TabIndex = 27;
            this.skLabel6.Text = "상태";
            this.skLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skTextBox2
            // 
            this.skTextBox2.BackColor = System.Drawing.Color.White;
            this.skTextBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox2.ForeColor = System.Drawing.Color.Black;
            this.skTextBox2.Location = new System.Drawing.Point(409, 48);
            this.skTextBox2.Name = "skTextBox2";
            this.skTextBox2.Size = new System.Drawing.Size(104, 21);
            this.skTextBox2.TabIndex = 28;
            this.skTextBox2.Tag = null;
            this.skTextBox2.TextDetached = true;
            // 
            // skLabel5
            // 
            this.skLabel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.skLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel5.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel5.Location = new System.Drawing.Point(340, 49);
            this.skLabel5.Name = "skLabel5";
            this.skLabel5.Size = new System.Drawing.Size(63, 21);
            this.skLabel5.TabIndex = 26;
            this.skLabel5.Text = "배차번호";
            this.skLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skDateEdit2
            // 
            this.skDateEdit2.AutoSize = false;
            this.skDateEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.skDateEdit2.Calendar.DayNameLength = 1;
            this.skDateEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skDateEdit2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDateEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.skDateEdit2.Location = new System.Drawing.Point(227, 48);
            this.skDateEdit2.Name = "skDateEdit2";
            this.skDateEdit2.Required = false;
            this.skDateEdit2.Size = new System.Drawing.Size(106, 24);
            this.skDateEdit2.TabIndex = 25;
            this.skDateEdit2.Tag = null;
            this.skDateEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel4
            // 
            this.skLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.skLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel4.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel4.Location = new System.Drawing.Point(205, 49);
            this.skLabel4.Name = "skLabel4";
            this.skLabel4.Size = new System.Drawing.Size(16, 21);
            this.skLabel4.TabIndex = 24;
            this.skLabel4.Text = "~";
            // 
            // skDateEdit1
            // 
            this.skDateEdit1.AutoSize = false;
            this.skDateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.skDateEdit1.Calendar.DayNameLength = 1;
            this.skDateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skDateEdit1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.skDateEdit1.Location = new System.Drawing.Point(91, 48);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(108, 24);
            this.skDateEdit1.TabIndex = 23;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel3
            // 
            this.skLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(22, 49);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(63, 21);
            this.skLabel3.TabIndex = 22;
            this.skLabel3.Text = "작업일자";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.skTextBox1, 2);
            this.skTextBox1.Enabled = false;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(205, 78);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(128, 21);
            this.skTextBox1.TabIndex = 21;
            this.skTextBox1.Tag = null;
            this.skTextBox1.TextDetached = true;
            // 
            // helpWindow1
            // 
            this.helpWindow1.BackColor = System.Drawing.Color.Transparent;
            this.helpWindow1.DisplayName = null;
            this.helpWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpWindow1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.helpWindow1.InParam = null;
            this.helpWindow1.Location = new System.Drawing.Point(91, 79);
            this.helpWindow1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helpWindow1.Name = "helpWindow1";
            this.helpWindow1.Padding = new System.Windows.Forms.Padding(6);
            this.helpWindow1.PakageName = null;
            this.helpWindow1.Size = new System.Drawing.Size(108, 22);
            this.helpWindow1.TabIndex = 20;
            this.helpWindow1.ValueName = null;
            // 
            // skLabel2
            // 
            this.skLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(22, 79);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(63, 21);
            this.skLabel2.TabIndex = 19;
            this.skLabel2.Text = "제품코드";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // skButton1
            // 
            this.skButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 6F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(3, 10);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(76, 25);
            this.skButton1.TabIndex = 29;
            this.skButton1.Text = "출고 DOCK변경";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // skButton2
            // 
            this.skButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skButton2.BackColor = System.Drawing.Color.White;
            this.skButton2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton2.Image = ((System.Drawing.Image)(resources.GetObject("skButton2.Image")));
            this.skButton2.Location = new System.Drawing.Point(91, 10);
            this.skButton2.Name = "skButton2";
            this.skButton2.Size = new System.Drawing.Size(79, 25);
            this.skButton2.TabIndex = 30;
            this.skButton2.Text = "작업취소";
            this.skButton2.UseVisualStyleBackColor = true;
            this.skButton2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(796, 539);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 31;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.16982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.3558F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.770418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.09575F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.854117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.8825F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.8716F));
            this.tableLayoutPanel1.Controls.Add(this.skComboBox1, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.skButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.skTextBox2, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.skLabel6, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.skButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.commonButton1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.skLabel5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.skLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.skTextBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.skDateEdit2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.helpWindow1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.skLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.skLabel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.skDateEdit1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 100);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.skGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.skGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(796, 435);
            this.splitContainer2.SplitterDistance = 244;
            this.splitContainer2.TabIndex = 0;
            // 
            // INB2100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "INB2100";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKGridView skGridView2;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.HelpWindow helpWindow1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKLabel skLabel6;
        private WinControls.SKLabel skLabel5;
        private WinControls.SKDateEdit skDateEdit2;
        private WinControls.SKLabel skLabel4;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKTextBox skTextBox2;
        private WinControls.SKButton skButton1;
        private WinControls.SKButton skButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}
