namespace SK.WMS.INV20.INB.UI
{
    partial class INB2090
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INB2090));
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skDockingTab1 = new SK.WMS.WinControls.SKDockingTab();
            this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).BeginInit();
            this.skDockingTab1.SuspendLayout();
            this.c1DockingTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).BeginInit();
            this.c1DockingTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // skButton1
            // 
            this.skButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(3, 10);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 1;
            this.skButton1.Text = "작업지시";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // commonButton1
            // 
            this.commonButton1.BackColor = System.Drawing.Color.Transparent;
            this.commonButton1.BindingGrid = false;
            this.commonButton1.BindingGridControl = null;
            this.commonButton1.DelCol = 0;
            this.commonButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(146, 4);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(647, 37);
            this.commonButton1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.03279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.96721F));
            this.tableLayoutPanel1.Controls.Add(this.commonButton1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.skButton1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 45);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.splitContainer1.Panel2.Controls.Add(this.skDockingTab1);
            this.splitContainer1.Size = new System.Drawing.Size(796, 539);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 4;
            // 
            // skDockingTab1
            // 
            this.skDockingTab1.BackColor = System.Drawing.Color.White;
            this.skDockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage1);
            this.skDockingTab1.Controls.Add(this.c1DockingTabPage2);
            this.skDockingTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skDockingTab1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skDockingTab1.ForeColor = System.Drawing.Color.Black;
            this.skDockingTab1.Location = new System.Drawing.Point(0, 0);
            this.skDockingTab1.Name = "skDockingTab1";
            this.skDockingTab1.SelectedIndex = 1;
            this.skDockingTab1.Size = new System.Drawing.Size(796, 490);
            this.skDockingTab1.TabIndex = 1;
            this.skDockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.skDockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1DockingTabPage1
            // 
            this.c1DockingTabPage1.Controls.Add(this.skGridView2);
            this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage1.Name = "c1DockingTabPage1";
            this.c1DockingTabPage1.Size = new System.Drawing.Size(794, 462);
            this.c1DockingTabPage1.TabIndex = 0;
            this.c1DockingTabPage1.Text = "검색";
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
            this.skGridView2.Size = new System.Drawing.Size(794, 462);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 1;
            // 
            // c1DockingTabPage2
            // 
            this.c1DockingTabPage2.Controls.Add(this.skGridView1);
            this.c1DockingTabPage2.Location = new System.Drawing.Point(1, 27);
            this.c1DockingTabPage2.Name = "c1DockingTabPage2";
            this.c1DockingTabPage2.Size = new System.Drawing.Size(794, 462);
            this.c1DockingTabPage2.TabIndex = 1;
            this.c1DockingTabPage2.Text = "리스트";
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
            this.skGridView1.Size = new System.Drawing.Size(794, 462);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 1;
            // 
            // INB2090
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "INB2090";
            this.Size = new System.Drawing.Size(796, 539);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skDockingTab1)).EndInit();
            this.skDockingTab1.ResumeLayout(false);
            this.c1DockingTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            this.c1DockingTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKButton skButton1;
        private WinControls.CommonButton commonButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WinControls.SKDockingTab skDockingTab1;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
        private WinControls.SKGridView skGridView2;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
        private WinControls.SKGridView skGridView1;

    }
}
