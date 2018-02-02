namespace SK.WMS.INV60.CLS.UI
{
    partial class CLS6020
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLS6020));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
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
            this.skGridView1.Location = new System.Drawing.Point(3, 74);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(790, 462);
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
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(3, 9);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 2;
            this.skButton1.Text = "SAP재고수신";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(3, 47);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(107, 21);
            this.skLabel1.TabIndex = 3;
            this.skLabel1.Text = "SAP검증결과확인";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.skDateEdit1.Location = new System.Drawing.Point(116, 47);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit1.TabIndex = 4;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(222, 46);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(78, 21);
            this.skLabel2.TabIndex = 3;
            this.skLabel2.Text = "Option";
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
            this.skComboBox1.Location = new System.Drawing.Point(306, 47);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(106, 21);
            this.skComboBox1.TabIndex = 5;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skLabel3
            // 
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(418, 46);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(78, 21);
            this.skLabel3.TabIndex = 3;
            this.skLabel3.Text = "SAP수신일시";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(502, 46);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(169, 21);
            this.skTextBox1.TabIndex = 6;
            this.skTextBox1.Tag = null;
            this.skTextBox1.TextDetached = true;
            // 
            // CLS6020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skComboBox1);
            this.Controls.Add(this.skDateEdit1);
            this.Controls.Add(this.skLabel3);
            this.Controls.Add(this.skLabel2);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.skButton1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skGridView1);
            this.Name = "CLS6020";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKButton skButton1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKTextBox skTextBox1;
    }
}
