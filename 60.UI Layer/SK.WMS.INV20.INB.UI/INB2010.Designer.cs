namespace SK.WMS.INV20.INB.UI
{
    partial class INB2010
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INB2010));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.skDateEdit2 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            this.skGridView3 = new SK.WMS.WinControls.SKGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // commonButton1
            // 
            this.commonButton1.BackColor = System.Drawing.Color.Transparent;
            this.commonButton1.BindingGrid = false;
            this.commonButton1.BindingGridControl = null;
            this.tableLayoutPanel1.SetColumnSpan(this.commonButton1, 5);
            this.commonButton1.DelCol = 0;
            this.commonButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(3, 4);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(790, 37);
            this.commonButton1.TabIndex = 10;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.skDateEdit2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.skLabel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.skDateEdit1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.skLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.commonButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 539);
            this.tableLayoutPanel1.TabIndex = 10;
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
            this.skDateEdit2.Location = new System.Drawing.Point(218, 48);
            this.skDateEdit2.Name = "skDateEdit2";
            this.skDateEdit2.Required = false;
            this.skDateEdit2.Size = new System.Drawing.Size(128, 24);
            this.skDateEdit2.TabIndex = 14;
            this.skDateEdit2.Tag = null;
            this.skDateEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel2
            // 
            this.skLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(202, 45);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(10, 30);
            this.skLabel2.TabIndex = 13;
            this.skLabel2.Text = "~";
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
            this.skDateEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skDateEdit1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.skDateEdit1.Location = new System.Drawing.Point(68, 48);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(128, 24);
            this.skDateEdit1.TabIndex = 12;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel1
            // 
            this.skLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(3, 45);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(59, 30);
            this.skLabel1.TabIndex = 15;
            this.skLabel1.Text = "개정일자";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 5);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 78);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.skGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(790, 458);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 16;
            // 
            // skGridView1
            // 
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = "4,1,0,0,0,110,Columns:0{Width:15;}\t1{Width:61;Caption:\"개정일자\";}\t2{Width:60;Caption" +
                ":\"개정번호\";}\t3{Width:45;Caption:\"계열\";}\t";
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
            this.skGridView1.Size = new System.Drawing.Size(263, 458);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 13;
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
            this.splitContainer2.Panel1.Controls.Add(this.skGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.skGridView3);
            this.splitContainer2.Size = new System.Drawing.Size(523, 458);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 0;
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
            this.skGridView2.Size = new System.Drawing.Size(523, 207);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 14;
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
            this.skGridView3.Size = new System.Drawing.Size(523, 247);
            this.skGridView3.StyleInfo = resources.GetString("skGridView3.StyleInfo");
            this.skGridView3.TabIndex = 15;
            // 
            // INB2010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "INB2010";
            this.Size = new System.Drawing.Size(796, 539);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private WinControls.SKDateEdit skDateEdit2;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKLabel skLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WinControls.SKGridView skGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private WinControls.SKGridView skGridView2;
        private WinControls.SKGridView skGridView3;
    }
}
