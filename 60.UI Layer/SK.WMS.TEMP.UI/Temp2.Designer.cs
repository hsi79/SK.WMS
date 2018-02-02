namespace SK.WMS.TEMP.UI
{
    partial class Temp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temp2));
            this.c1DropDownControl1 = new C1.Win.C1Input.C1DropDownControl();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skNumericEdit1 = new SK.WMS.WinControls.SKNumericEdit();
            this.skListBox1 = new SK.WMS.WinControls.SKListBox();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skGroupBox1 = new SK.WMS.WinControls.SKGroupBox();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skCheckBox1 = new SK.WMS.WinControls.SKCheckBox();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skNumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DropDownControl1
            // 
            this.c1DropDownControl1.Location = new System.Drawing.Point(302, 410);
            this.c1DropDownControl1.Name = "c1DropDownControl1";
            this.c1DropDownControl1.Size = new System.Drawing.Size(200, 21);
            this.c1DropDownControl1.TabIndex = 10;
            this.c1DropDownControl1.Tag = null;
            // 
            // skButton1
            // 
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(366, 357);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 11;
            this.skButton1.Text = "저장마감";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(345, 233);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(67, 21);
            this.skTextBox1.TabIndex = 9;
            this.skTextBox1.Tag = null;
            this.skTextBox1.Text = "skTextBox1";
            this.skTextBox1.TextDetached = true;
            // 
            // skNumericEdit1
            // 
            this.skNumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skNumericEdit1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skNumericEdit1.Location = new System.Drawing.Point(46, 339);
            this.skNumericEdit1.Name = "skNumericEdit1";
            this.skNumericEdit1.Size = new System.Drawing.Size(200, 21);
            this.skNumericEdit1.TabIndex = 8;
            this.skNumericEdit1.Tag = null;
            this.skNumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.skNumericEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skNumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None;
            // 
            // skListBox1
            // 
            this.skListBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skListBox1.FormattingEnabled = true;
            this.skListBox1.ItemHeight = 15;
            this.skListBox1.Location = new System.Drawing.Point(46, 238);
            this.skListBox1.Name = "skListBox1";
            this.skListBox1.Size = new System.Drawing.Size(120, 94);
            this.skListBox1.TabIndex = 7;
            // 
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(43, 213);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(80, 21);
            this.skLabel1.TabIndex = 6;
            this.skLabel1.Text = "skLabel1";
            // 
            // skGroupBox1
            // 
            this.skGroupBox1.BackColor = System.Drawing.Color.White;
            this.skGroupBox1.Font = new System.Drawing.Font("맑은 고딕", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skGroupBox1.Location = new System.Drawing.Point(506, 307);
            this.skGroupBox1.Name = "skGroupBox1";
            this.skGroupBox1.Size = new System.Drawing.Size(200, 100);
            this.skGroupBox1.TabIndex = 5;
            this.skGroupBox1.TabStop = false;
            this.skGroupBox1.Text = "skGroupBox1";
            // 
            // skGridView1
            // 
            this.skGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = "1,1,0,0,0,110,Columns:";
            this.skGridView1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView1.Location = new System.Drawing.Point(3, 60);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(742, 150);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 4;
            // 
            // skDateEdit1
            // 
            this.skDateEdit1.AutoSize = false;
            // 
            // 
            // 
            this.skDateEdit1.Calendar.DayNameLength = 1;
            this.skDateEdit1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.skDateEdit1.Location = new System.Drawing.Point(200, 238);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit1.TabIndex = 3;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skCheckBox1
            // 
            this.skCheckBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCheckBox1.Location = new System.Drawing.Point(540, 255);
            this.skCheckBox1.Name = "skCheckBox1";
            this.skCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.skCheckBox1.TabIndex = 2;
            this.skCheckBox1.Text = "skCheckBox1";
            this.skCheckBox1.UseVisualStyleBackColor = true;
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
            this.commonButton1.TabIndex = 0;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            // 
            // Temp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.skButton1);
            this.Controls.Add(this.c1DropDownControl1);
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skNumericEdit1);
            this.Controls.Add(this.skListBox1);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.skGroupBox1);
            this.Controls.Add(this.skGridView1);
            this.Controls.Add(this.skDateEdit1);
            this.Controls.Add(this.skCheckBox1);
            this.Controls.Add(this.commonButton1);
            this.Name = "Temp2";
            this.Size = new System.Drawing.Size(760, 683);
            this.Load += new System.EventHandler(this.Temp2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1DropDownControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skNumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private WinControls.SKCheckBox skCheckBox1;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKGridView skGridView1;
        private WinControls.SKGroupBox skGroupBox1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKListBox skListBox1;
        private WinControls.SKNumericEdit skNumericEdit1;
        private WinControls.SKTextBox skTextBox1;
        private C1.Win.C1Input.C1DropDownControl c1DropDownControl1;
        private WinControls.SKButton skButton1;
    }
}
