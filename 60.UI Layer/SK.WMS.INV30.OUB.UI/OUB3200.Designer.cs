namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3200
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3200));
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skCheckBox1 = new SK.WMS.WinControls.SKCheckBox();
            this.skLabel1 = new SK.WMS.WinControls.SKLabel();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skGroupBox1 = new SK.WMS.WinControls.SKGroupBox();
            this.skGroupBox2 = new SK.WMS.WinControls.SKGroupBox();
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.skGridView2 = new SK.WMS.WinControls.SKGridView();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).BeginInit();
            this.skGroupBox1.SuspendLayout();
            this.skGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).BeginInit();
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
            // skCheckBox1
            // 
            this.skCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skCheckBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCheckBox1.Location = new System.Drawing.Point(477, 41);
            this.skCheckBox1.Name = "skCheckBox1";
            this.skCheckBox1.Size = new System.Drawing.Size(131, 24);
            this.skCheckBox1.TabIndex = 2;
            this.skCheckBox1.Text = "현황 Auto Refresh";
            this.skCheckBox1.UseVisualStyleBackColor = true;
            // 
            // skLabel1
            // 
            this.skLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel1.Location = new System.Drawing.Point(623, 45);
            this.skLabel1.Name = "skLabel1";
            this.skLabel1.Size = new System.Drawing.Size(59, 21);
            this.skLabel1.TabIndex = 3;
            this.skLabel1.Text = "Interval : ";
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(761, 45);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(25, 21);
            this.skLabel2.TabIndex = 4;
            this.skLabel2.Text = "초";
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(688, 43);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(67, 21);
            this.skTextBox1.TabIndex = 5;
            this.skTextBox1.Tag = null;
            this.skTextBox1.TextDetached = true;
            // 
            // skGroupBox1
            // 
            this.skGroupBox1.BackColor = System.Drawing.Color.White;
            this.skGroupBox1.Controls.Add(this.skGridView1);
            this.skGroupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.skGroupBox1.Location = new System.Drawing.Point(3, 71);
            this.skGroupBox1.Name = "skGroupBox1";
            this.skGroupBox1.Size = new System.Drawing.Size(790, 237);
            this.skGroupBox1.TabIndex = 6;
            this.skGroupBox1.TabStop = false;
            this.skGroupBox1.Text = "입문차량현황";
            // 
            // skGroupBox2
            // 
            this.skGroupBox2.BackColor = System.Drawing.Color.White;
            this.skGroupBox2.Controls.Add(this.skGridView2);
            this.skGroupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.skGroupBox2.Location = new System.Drawing.Point(3, 314);
            this.skGroupBox2.Name = "skGroupBox2";
            this.skGroupBox2.Size = new System.Drawing.Size(790, 257);
            this.skGroupBox2.TabIndex = 7;
            this.skGroupBox2.TabStop = false;
            this.skGroupBox2.Text = "차량별 ORDER 현황";
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
            this.skGridView1.Location = new System.Drawing.Point(3, 25);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(784, 209);
            this.skGridView1.StyleInfo = resources.GetString("skGridView1.StyleInfo");
            this.skGridView1.TabIndex = 0;
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
            this.skGridView2.Location = new System.Drawing.Point(3, 25);
            this.skGridView2.Name = "skGridView2";
            this.skGridView2.Rows.Count = 1;
            this.skGridView2.Rows.DefaultSize = 20;
            this.skGridView2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView2.ShowCellLabels = true;
            this.skGridView2.Size = new System.Drawing.Size(784, 229);
            this.skGridView2.StyleInfo = resources.GetString("skGridView2.StyleInfo");
            this.skGridView2.TabIndex = 0;
            // 
            // OUB3200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skGroupBox2);
            this.Controls.Add(this.skGroupBox1);
            this.Controls.Add(this.skTextBox1);
            this.Controls.Add(this.skLabel2);
            this.Controls.Add(this.skLabel1);
            this.Controls.Add(this.skCheckBox1);
            this.Controls.Add(this.commonButton1);
            this.Name = "OUB3200";
            this.Size = new System.Drawing.Size(796, 571);
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            this.skGroupBox1.ResumeLayout(false);
            this.skGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.CommonButton commonButton1;
        private WinControls.SKCheckBox skCheckBox1;
        private WinControls.SKLabel skLabel1;
        private WinControls.SKLabel skLabel2;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKGroupBox skGroupBox1;
        private WinControls.SKGridView skGridView1;
        private WinControls.SKGroupBox skGroupBox2;
        private WinControls.SKGridView skGridView2;
    }
}
