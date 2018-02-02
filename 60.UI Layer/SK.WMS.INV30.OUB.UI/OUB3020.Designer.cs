namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3020
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3020));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            this.skButton1 = new SK.WMS.WinControls.SKButton();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
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
            this.skGridView1.Location = new System.Drawing.Point(3, 312);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(790, 224);
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
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 17F);
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(3, 6);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(120, 40);
            this.skLabel1.TabIndex = 2;
            this.skLabel1.Text = "바  코  드";
            this.skLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(129, 13);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(72, 21);
            this.skTextBox1.TabIndex = 3;
            this.skTextBox1.Tag = null;
            this.skTextBox1.Text = "S00000451";
            this.skTextBox1.TextDetached = true;
            this.skTextBox1.TextChanged += new System.EventHandler(this.skTextBox1_TextChanged);
            // 
            // skLabel2
            // 
            this.skLabel2.BackColor = System.Drawing.Color.White;
            this.skLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 17F);
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(3, 46);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(257, 40);
            this.skLabel2.TabIndex = 4;
            this.skLabel2.Text = "출문차량현황";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // skLabel3
            // 
            this.skLabel3.BackColor = System.Drawing.Color.White;
            this.skLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 17F);
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(3, 269);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(257, 40);
            this.skLabel3.TabIndex = 5;
            this.skLabel3.Text = "차량별 ORDER 현황";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.skGridView2.Location = new System.Drawing.Point(3, 89);
            this.skGridView2.Name = "skGridView2";
            this.skGridView2.Rows.Count = 1;
            this.skGridView2.Rows.DefaultSize = 20;
            this.skGridView2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView2.ShowCellLabels = true;
            this.skGridView2.Size = new System.Drawing.Size(790, 177);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 6;
            // 
            // skButton1
            // 
            this.skButton1.BackColor = System.Drawing.Color.White;
            this.skButton1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skButton1.Image = ((System.Drawing.Image)(resources.GetObject("skButton1.Image")));
            this.skButton1.Location = new System.Drawing.Point(217, 8);
            this.skButton1.Name = "skButton1";
            this.skButton1.Size = new System.Drawing.Size(77, 25);
            this.skButton1.TabIndex = 7;
            this.skButton1.Text = "출문처리";
            this.skButton1.UseVisualStyleBackColor = true;
            this.skButton1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.skButton1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // OUB3020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skButton1);
            this.Controls.Add(this.skGridView2);
            this.Controls.Add(this.skLabel3);
            this.Controls.Add(this.skLabel2);
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skGridView1);
            this.Name = "OUB3020";
            this.Size = new System.Drawing.Size(796, 539);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKGridView skGridView2;
        private WinControls.SKButton skButton1;
    }
}
