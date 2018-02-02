namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3040
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3040));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            this.skGridView3 = new SK.WMS.WinControls.SKGridView();
            this.skGroupBox1 = new SK.WMS.WinControls.SKGroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.skGroupBox1.SuspendLayout();
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
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(14, 47);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(55, 21);
            this.skLabel1.TabIndex = 26;
            this.skLabel1.Text = "팔렛지정";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(17, 71);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.skGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(776, 465);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 27;
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
            this.skGridView1.Size = new System.Drawing.Size(488, 461);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.splitContainer2.Size = new System.Drawing.Size(280, 465);
            this.splitContainer2.SplitterDistance = 224;
            this.splitContainer2.TabIndex = 0;
            // 
            // skGridView2
            // 
            this.skGridView2.AutoClipboard = true;
            this.skGridView2.BackColor = System.Drawing.Color.White;
            this.skGridView2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView2.ColumnInfo = "9,1,0,0,0,110,Columns:0{Width:18;}\t1{Width:49;Caption:\"제품명\";}\t2{Width:61;Caption:" +
                "\"주문수량\";}\t3{Width:61;Caption:\"팔렛타입\";}\t4{Width:61;Caption:\"팔렛수량\";}\t";
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
            this.skGridView2.Size = new System.Drawing.Size(276, 220);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 0;
            // 
            // skGridView3
            // 
            this.skGridView3.AutoClipboard = true;
            this.skGridView3.BackColor = System.Drawing.Color.White;
            this.skGridView3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.skGridView3.ColumnInfo = "4,1,0,0,0,110,Columns:0{Width:19;}\t1{Width:49;Caption:\"제품명\";}\t2{Width:61;Caption:" +
                "\"팔렛타입\";}\t3{Width:61;Caption:\"팔렛수량\";}\t";
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
            this.skGridView3.Size = new System.Drawing.Size(276, 233);
            this.skGridView3.StyleInfo = resources.GetString("skGridView3.StyleInfo");
            this.skGridView3.TabIndex = 0;
            // 
            // skGroupBox1
            // 
            this.skGroupBox1.BackColor = System.Drawing.Color.White;
            this.skGroupBox1.Controls.Add(this.radioButton3);
            this.skGroupBox1.Controls.Add(this.radioButton2);
            this.skGroupBox1.Controls.Add(this.radioButton1);
            this.skGroupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGroupBox1.Location = new System.Drawing.Point(75, 27);
            this.skGroupBox1.Name = "skGroupBox1";
            this.skGroupBox1.Size = new System.Drawing.Size(209, 38);
            this.skGroupBox1.TabIndex = 1;
            this.skGroupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(139, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 19);
            this.radioButton3.TabIndex = 40;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "미지정";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(74, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 19);
            this.radioButton2.TabIndex = 39;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "지정";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 19);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "전체";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // OUB3040
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skGroupBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.commonButton1);
            this.Name = "OUB3040";
            this.Size = new System.Drawing.Size(796, 539);
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
            this.skGroupBox1.ResumeLayout(false);
            this.skGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private WinControls.SKLabel skLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private WinControls.SKGridView skGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private WinControls.SKGridView skGridView2;
        private WinControls.SKGridView skGridView3;
        private WinControls.SKGroupBox skGroupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
