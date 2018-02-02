namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3120
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3120));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skLabel4 = new SK.WMS.WinControls.SKLabel();
            this.skLabel5 = new SK.WMS.WinControls.SKLabel();
            this.skDateEdit2 = new SK.WMS.WinControls.SKDateEdit();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skTextBox2 = new SK.WMS.WinControls.SKTextBox();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).BeginInit();
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
            this.skGridView1.Location = new System.Drawing.Point(0, 102);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(790, 215);
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
            this.skLabel1.Location = new System.Drawing.Point(3, 44);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(113, 21);
            this.skLabel1.TabIndex = 2;
            this.skLabel1.Text = "컨테이너작업일자";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(3, 74);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(113, 21);
            this.skLabel2.TabIndex = 3;
            this.skLabel2.Text = "컨테이너작업일자";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel3
            // 
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(370, 45);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(69, 21);
            this.skLabel3.TabIndex = 4;
            this.skLabel3.Text = "수출번호";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel4
            // 
            this.skLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel4.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel4.Location = new System.Drawing.Point(231, 74);
            this.skLabel4.Name = "skLabel4";
            this.skLabel4.Size = new System.Drawing.Size(79, 21);
            this.skLabel4.TabIndex = 5;
            this.skLabel4.Text = "전송유무";
            this.skLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel5
            // 
            this.skLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel5.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel5.Location = new System.Drawing.Point(219, 45);
            this.skLabel5.Name = "skLabel5";
            this.skLabel5.Size = new System.Drawing.Size(26, 21);
            this.skLabel5.TabIndex = 13;
            this.skLabel5.Text = "~";
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
            this.skDateEdit2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDateEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.skDateEdit2.Location = new System.Drawing.Point(251, 45);
            this.skDateEdit2.Name = "skDateEdit2";
            this.skDateEdit2.Required = false;
            this.skDateEdit2.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit2.TabIndex = 12;
            this.skDateEdit2.Tag = null;
            this.skDateEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
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
            this.skDateEdit1.Location = new System.Drawing.Point(113, 45);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit1.TabIndex = 11;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(113, 75);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(112, 21);
            this.skTextBox1.TabIndex = 14;
            this.skTextBox1.Tag = null;
            this.skTextBox1.TextDetached = true;
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
            this.skComboBox1.Location = new System.Drawing.Point(316, 75);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(100, 21);
            this.skComboBox1.TabIndex = 15;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skTextBox2
            // 
            this.skTextBox2.BackColor = System.Drawing.Color.White;
            this.skTextBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox2.ForeColor = System.Drawing.Color.Black;
            this.skTextBox2.Location = new System.Drawing.Point(445, 46);
            this.skTextBox2.Name = "skTextBox2";
            this.skTextBox2.Size = new System.Drawing.Size(71, 21);
            this.skTextBox2.TabIndex = 16;
            this.skTextBox2.Tag = null;
            this.skTextBox2.TextDetached = true;
            // 
            // skGridView2
            // 
            this.skGridView2.AutoClipboard = true;
            this.skGridView2.BackColor = System.Drawing.Color.White;
            this.skGridView2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView2.ColumnInfo = resources.GetString("skGridView2.ColumnInfo");
            this.skGridView2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView2.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView2.Location = new System.Drawing.Point(0, 326);
            this.skGridView2.Name = "skGridView2";
            this.skGridView2.Rows.Count = 1;
            this.skGridView2.Rows.DefaultSize = 20;
            this.skGridView2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView2.ShowCellLabels = true;
            this.skGridView2.Size = new System.Drawing.Size(790, 271);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 17;
            // 
            // OUB3120
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skGridView2);
            this.Controls.Add(this.skTextBox2);
            this.Controls.Add(this.skComboBox1);
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skLabel5);
            this.Controls.Add(this.skDateEdit2);
            this.Controls.Add(this.skDateEdit1);
            this.Controls.Add(this.skLabel4);
            this.Controls.Add(this.skLabel3);
            this.Controls.Add(this.skLabel2);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skGridView1);
            this.Name = "OUB3120";
            this.Size = new System.Drawing.Size(796, 600);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKLabel skLabel4;
        private WinControls.SKLabel skLabel5;
        private WinControls.SKDateEdit skDateEdit2;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKTextBox skTextBox2;
        private WinControls.SKGridView skGridView2;
    }
}
