namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3090
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3090));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skDockingTab1 = new SK.WMS.WinControls.SKDockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skDateEdit1 = new SK.WMS.WinControls.SKDateEdit();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).BeginInit();
            this.skDockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
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
            this.skDockingTab1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDockingTab1.ForeColor = System.Drawing.Color.Black;
            this.skDockingTab1.Location = new System.Drawing.Point(3, 41);
            this.skDockingTab1.Name = "skDockingTab1";
            this.skDockingTab1.Size = new System.Drawing.Size(790, 495);
            this.skDockingTab1.TabIndex = 2;
            this.skDockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.skDockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.splitContainer1);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(788, 467);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "조회항목";
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
            this.splitContainer1.Panel1.Controls.Add(this.skDateEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.skLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(788, 467);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.TabIndex = 0;
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
            this.skDateEdit1.Location = new System.Drawing.Point(98, 19);
            this.skDateEdit1.Name = "skDateEdit1";
            this.skDateEdit1.Required = false;
            this.skDateEdit1.Size = new System.Drawing.Size(100, 21);
            this.skDateEdit1.TabIndex = 1;
            this.skDateEdit1.Tag = null;
            this.skDateEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skDateEdit1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.skDateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(20, 19);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(72, 21);
            this.skLabel1.TabIndex = 0;
            this.skLabel1.Text = "조회일자";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.splitContainer2.Size = new System.Drawing.Size(788, 401);
            this.splitContainer2.SplitterDistance = 100;
            this.splitContainer2.TabIndex = 0;
            // 
            // skGridView1
            // 
            this.skGridView1.AutoClipboard = true;
            this.skGridView1.BackColor = System.Drawing.Color.White;
            this.skGridView1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView1.ColumnInfo = "7,1,0,0,0,110,Columns:1{Width:36;Caption:\"순번\";}\t2{Width:36;Caption:\"일자\";}\t3{Width" +
                ":86;Caption:\"창고별지시량\";}\t4{Width:55;Caption:\"RACK계\";}\t5{Width:61;Caption:\"야적장계\";}\t" +
                "6{Width:84;Caption:\"특기사항\";}\t";
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
            this.skGridView1.Size = new System.Drawing.Size(788, 100);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 0;
            // 
            // OUB3090
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skDockingTab1);
            this.Controls.Add(this.commonButton1);
            this.Name = "OUB3090";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).EndInit();
            this.skDockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skDateEdit1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private WinControls.SKDockingTab skDockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WinControls.SKDateEdit skDateEdit1;
        private WinControls.SKLabel skLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private WinControls.SKGridView skGridView1;
    }
}
