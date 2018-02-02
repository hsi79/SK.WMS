namespace SK.WMS.TEMP.UI
{
    partial class Temp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temp1));
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.helpWindow1 = new SK.WMS.WinControls.HelpWindow();
            this.skButton4 = new SK.WMS.WinControls.SKButton();
            this.skButton3 = new SK.WMS.WinControls.SKButton();
            this.skButton2 = new SK.WMS.WinControls.SKButton();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skCheckBox2 = new SK.WMS.WinControls.SKCheckBox();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skCheckBox1 = new SK.WMS.WinControls.SKCheckBox();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.skDateEdit1.Location = new System.Drawing.Point(244, 94);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit1.TabIndex = 16;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // helpWindow1
            // 
            this.helpWindow1.BackColor = System.Drawing.Color.Transparent;
            this.helpWindow1.DisplayName = "H_DIS";
            this.helpWindow1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.helpWindow1.InParam = null;
            this.helpWindow1.Location = new System.Drawing.Point(14, 69);
            this.helpWindow1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helpWindow1.Name = "helpWindow1";
            this.helpWindow1.Padding = new System.Windows.Forms.Padding(6);
            this.helpWindow1.PakageName = "PK_NEXCORE.SP_SELECT";
            this.helpWindow1.Size = new System.Drawing.Size(200, 26);
            this.helpWindow1.TabIndex = 14;
            this.helpWindow1.ValueName = "H_VAL";
            // 
            // skButton4
            // 
            this.skButton4.BackColor = System.Drawing.Color.White;
            this.skButton4.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton4.Image = ((System.Drawing.Image)(resources.GetObject("skButton4.Image")));
            this.skButton4.Location = new System.Drawing.Point(523, 33);
            this.skButton4.Name = "skButton4";
            this.skButton4.Size = new System.Drawing.Size(77, 25);
            this.skButton4.TabIndex = 13;
            this.skButton4.Text = "메세지";
            this.skButton4.UseVisualStyleBackColor = true;
            this.skButton4.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton4.Click += new System.EventHandler(this.skButton4_Click);
            // 
            // skButton3
            // 
            this.skButton3.BackColor = System.Drawing.Color.White;
            this.skButton3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton3.Image = ((System.Drawing.Image)(resources.GetObject("skButton3.Image")));
            this.skButton3.Location = new System.Drawing.Point(439, 33);
            this.skButton3.Name = "skButton3";
            this.skButton3.Size = new System.Drawing.Size(77, 25);
            this.skButton3.TabIndex = 12;
            this.skButton3.Text = "Confirm";
            this.skButton3.UseVisualStyleBackColor = true;
            this.skButton3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton3.Click += new System.EventHandler(this.skButton3_Click);
            // 
            // skButton2
            // 
            this.skButton2.BackColor = System.Drawing.Color.White;
            this.skButton2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton2.Image = ((System.Drawing.Image)(resources.GetObject("skButton2.Image")));
            this.skButton2.Location = new System.Drawing.Point(355, 33);
            this.skButton2.Name = "skButton2";
            this.skButton2.Size = new System.Drawing.Size(77, 25);
            this.skButton2.TabIndex = 11;
            this.skButton2.Text = "에러메세지";
            this.skButton2.UseVisualStyleBackColor = true;
            this.skButton2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton2.Click += new System.EventHandler(this.skButton2_Click);
            // 
            // skButton1
            // 
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(271, 33);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 9;
            this.skButton1.Text = "skButton1";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.Click += new System.EventHandler(this.skButton1_Click);
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
            this.commonButton1.Location = new System.Drawing.Point(0, 0);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(756, 37);
            this.commonButton1.TabIndex = 8;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            // 
            // skCheckBox2
            // 
            this.skCheckBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCheckBox2.Location = new System.Drawing.Point(244, 64);
            this.skCheckBox2.Name = "skCheckBox2";
            this.skCheckBox2.Size = new System.Drawing.Size(104, 24);
            this.skCheckBox2.TabIndex = 6;
            this.skCheckBox2.Text = "skCheckBox2";
            this.skCheckBox2.UseVisualStyleBackColor = true;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(365, 74);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(67, 21);
            this.skTextBox1.TabIndex = 5;
            this.skTextBox1.Tag = null;
            this.skTextBox1.Text = "skTextBox1";
            this.skTextBox1.TextDetached = true;
            // 
            // skCheckBox1
            // 
            this.skCheckBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCheckBox1.Location = new System.Drawing.Point(638, 72);
            this.skCheckBox1.Name = "skCheckBox1";
            this.skCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.skCheckBox1.TabIndex = 4;
            this.skCheckBox1.Text = "skCheckBox1";
            this.skCheckBox1.UseVisualStyleBackColor = true;
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
            this.skComboBox1.Location = new System.Drawing.Point(452, 74);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(100, 21);
            this.skComboBox1.TabIndex = 17;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(574, 74);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(80, 21);
            this.skLabel1.TabIndex = 18;
            this.skLabel1.Text = "skLabel1";
            // 
            // skGridView1
            // 
            this.skGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = "10,1,0,0,0,110,Columns:1{Style:\"DataType:System.String;TextAlign:LeftCenter;\";}\t";
            this.skGridView1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView1.Location = new System.Drawing.Point(14, 326);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(728, 150);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 19;
            this.skGridView1.AfterEdit += new SK.WMS.WinControls.SKGridView.SKRowColEventHandler(this.skGridView1_AfterEdit);
            // 
            // Temp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.skGridView1);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.skComboBox1);
            this.Controls.Add(this.skDateEdit1);
            this.Controls.Add(this.helpWindow1);
            this.Controls.Add(this.skButton4);
            this.Controls.Add(this.skButton3);
            this.Controls.Add(this.skButton2);
            this.Controls.Add(this.skButton1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skCheckBox2);
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skCheckBox1);
            this.Name = "Temp1";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.Temp1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKCheckBox skCheckBox1;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKCheckBox skCheckBox2;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKButton skButton1;
        private WinControls.SKButton skButton2;
        private WinControls.SKButton skButton3;
        private WinControls.SKButton skButton4;
        private WinControls.HelpWindow helpWindow1;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKGridView skGridView1;
    }
}
