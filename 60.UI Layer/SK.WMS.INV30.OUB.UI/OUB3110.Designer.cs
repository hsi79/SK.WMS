namespace SK.WMS.INV30.OUB.UI
{
    partial class OUB3110
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OUB3110));
            this.skGridView1 = new SK.WMS.WinControls.SKGridView();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.skPanel2 = new SK.WMS.WinControls.SKPanel();
            this.skComboBox1 = new SK.WMS.WinControls.SKComboBox();
            this.skTextBox5 = new SK.WMS.WinControls.SKTextBox();
            this.skTextBox6 = new SK.WMS.WinControls.SKTextBox();
            this.skTextBox3 = new SK.WMS.WinControls.SKTextBox();
            this.skTextBox4 = new SK.WMS.WinControls.SKTextBox();
            this.skTextBox2 = new SK.WMS.WinControls.SKTextBox();
            this.skTextBox1 = new SK.WMS.WinControls.SKTextBox();
            this.skLabel4 = new SK.WMS.WinControls.SKLabel();
            this.skLabel3 = new SK.WMS.WinControls.SKLabel();
            this.skLabel2 = new SK.WMS.WinControls.SKLabel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).BeginInit();
            this.skPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).BeginInit();
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
            this.skGridView1.ColumnInfo = "7,1,0,0,0,110,Columns:1{Width:61;Caption:\"제품코드\";}\t2{Width:49;Caption:\"제품명\";}\t3{Wi" +
                "dth:61;Caption:\"배차번호\";}\t4{Width:61;Caption:\"제품단수\";}\t5{Width:85;Caption:\"BAG수량합계\"" +
                ";}\t6{Width:94;Caption:\"중량합계(TON)\";}\t";
            this.skGridView1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.skGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skGridView1.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.skGridView1.Location = new System.Drawing.Point(3, 41);
            this.skGridView1.Name = "skGridView1";
            this.skGridView1.Rows.Count = 1;
            this.skGridView1.Rows.DefaultSize = 20;
            this.skGridView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.skGridView1.ShowCellLabels = true;
            this.skGridView1.Size = new System.Drawing.Size(790, 202);
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
            // skPanel2
            // 
            this.skPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skPanel2.Controls.Add(this.skComboBox1);
            this.skPanel2.Controls.Add(this.skTextBox5);
            this.skPanel2.Controls.Add(this.skTextBox6);
            this.skPanel2.Controls.Add(this.skTextBox3);
            this.skPanel2.Controls.Add(this.skTextBox4);
            this.skPanel2.Controls.Add(this.skTextBox2);
            this.skPanel2.Controls.Add(this.skTextBox1);
            this.skPanel2.Controls.Add(this.skLabel4);
            this.skPanel2.Controls.Add(this.skLabel3);
            this.skPanel2.Controls.Add(this.skLabel2);
            this.skPanel2.Controls.Add(this.radioButton5);
            this.skPanel2.Controls.Add(this.radioButton4);
            this.skPanel2.Controls.Add(this.radioButton3);
            this.skPanel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skPanel2.Location = new System.Drawing.Point(130, 249);
            this.skPanel2.Name = "skPanel2";
            this.skPanel2.Size = new System.Drawing.Size(537, 141);
            this.skPanel2.TabIndex = 4;
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
            this.skComboBox1.Location = new System.Drawing.Point(130, 101);
            this.skComboBox1.MatchEntryTimeout = ((long)(2000));
            this.skComboBox1.MaxDropDownItems = ((short)(5));
            this.skComboBox1.MaxLength = 32767;
            this.skComboBox1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.skComboBox1.Name = "skComboBox1";
            this.skComboBox1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.skComboBox1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.skComboBox1.Size = new System.Drawing.Size(163, 21);
            this.skComboBox1.TabIndex = 14;
            this.skComboBox1.Text = "skComboBox1";
            this.skComboBox1.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            this.skComboBox1.PropBag = resources.GetString("skComboBox1.PropBag");
            // 
            // skTextBox5
            // 
            this.skTextBox5.BackColor = System.Drawing.Color.White;
            this.skTextBox5.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox5.ForeColor = System.Drawing.Color.Black;
            this.skTextBox5.Location = new System.Drawing.Point(213, 78);
            this.skTextBox5.Name = "skTextBox5";
            this.skTextBox5.Size = new System.Drawing.Size(80, 21);
            this.skTextBox5.TabIndex = 13;
            this.skTextBox5.Tag = null;
            this.skTextBox5.TextDetached = true;
            // 
            // skTextBox6
            // 
            this.skTextBox6.BackColor = System.Drawing.Color.White;
            this.skTextBox6.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox6.ForeColor = System.Drawing.Color.Black;
            this.skTextBox6.Location = new System.Drawing.Point(130, 78);
            this.skTextBox6.Name = "skTextBox6";
            this.skTextBox6.Size = new System.Drawing.Size(80, 21);
            this.skTextBox6.TabIndex = 12;
            this.skTextBox6.Tag = null;
            this.skTextBox6.TextDetached = true;
            // 
            // skTextBox3
            // 
            this.skTextBox3.BackColor = System.Drawing.Color.White;
            this.skTextBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox3.ForeColor = System.Drawing.Color.Black;
            this.skTextBox3.Location = new System.Drawing.Point(213, 52);
            this.skTextBox3.Name = "skTextBox3";
            this.skTextBox3.Size = new System.Drawing.Size(80, 21);
            this.skTextBox3.TabIndex = 11;
            this.skTextBox3.Tag = null;
            this.skTextBox3.TextDetached = true;
            // 
            // skTextBox4
            // 
            this.skTextBox4.BackColor = System.Drawing.Color.White;
            this.skTextBox4.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox4.ForeColor = System.Drawing.Color.Black;
            this.skTextBox4.Location = new System.Drawing.Point(130, 52);
            this.skTextBox4.Name = "skTextBox4";
            this.skTextBox4.Size = new System.Drawing.Size(80, 21);
            this.skTextBox4.TabIndex = 10;
            this.skTextBox4.Tag = null;
            this.skTextBox4.TextDetached = true;
            // 
            // skTextBox2
            // 
            this.skTextBox2.BackColor = System.Drawing.Color.White;
            this.skTextBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox2.ForeColor = System.Drawing.Color.Black;
            this.skTextBox2.Location = new System.Drawing.Point(213, 27);
            this.skTextBox2.Name = "skTextBox2";
            this.skTextBox2.Size = new System.Drawing.Size(80, 21);
            this.skTextBox2.TabIndex = 9;
            this.skTextBox2.Tag = null;
            this.skTextBox2.TextDetached = true;
            // 
            // skTextBox1
            // 
            this.skTextBox1.BackColor = System.Drawing.Color.White;
            this.skTextBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skTextBox1.ForeColor = System.Drawing.Color.Black;
            this.skTextBox1.Location = new System.Drawing.Point(130, 27);
            this.skTextBox1.Name = "skTextBox1";
            this.skTextBox1.Size = new System.Drawing.Size(80, 21);
            this.skTextBox1.TabIndex = 8;
            this.skTextBox1.Tag = null;
            this.skTextBox1.TextDetached = true;
            // 
            // skLabel4
            // 
            this.skLabel4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel4.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel4.Location = new System.Drawing.Point(37, 101);
            this.skLabel4.Name = "skLabel4";
            this.skLabel4.Size = new System.Drawing.Size(80, 21);
            this.skLabel4.TabIndex = 7;
            this.skLabel4.Text = "출고-DOCK";
            this.skLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel3
            // 
            this.skLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel3.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel3.Location = new System.Drawing.Point(213, 5);
            this.skLabel3.Name = "skLabel3";
            this.skLabel3.Size = new System.Drawing.Size(80, 21);
            this.skLabel3.TabIndex = 6;
            this.skLabel3.Text = "요청수량";
            this.skLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skLabel2
            // 
            this.skLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skLabel2.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skLabel2.Location = new System.Drawing.Point(127, 5);
            this.skLabel2.Name = "skLabel2";
            this.skLabel2.Size = new System.Drawing.Size(80, 21);
            this.skLabel2.TabIndex = 5;
            this.skLabel2.Text = "지시수량";
            this.skLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(56, 79);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton5.Size = new System.Drawing.Size(61, 19);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.Text = "팔렛수";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(80, 54);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton4.Size = new System.Drawing.Size(37, 19);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "백";
            this.radioButton4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(80, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton3.Size = new System.Drawing.Size(37, 19);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "톤";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // OUB3110
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skPanel2);
            this.Controls.Add(this.commonButton1);
            this.Controls.Add(this.skGridView1);
            this.Name = "OUB3110";
            this.Size = new System.Drawing.Size(796, 475);
            ((System.ComponentModel.ISupportInitialize)(this.skGridView1)).EndInit();
            this.skPanel2.ResumeLayout(false);
            this.skPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinControls.SKGridView skGridView1;
        private WinControls.CommonButton commonButton1;
        private WinControls.SKPanel skPanel2;
        private WinControls.SKComboBox skComboBox1;
        private WinControls.SKTextBox skTextBox5;
        private WinControls.SKTextBox skTextBox6;
        private WinControls.SKTextBox skTextBox3;
        private WinControls.SKTextBox skTextBox4;
        private WinControls.SKTextBox skTextBox2;
        private WinControls.SKTextBox skTextBox1;
        private WinControls.SKLabel skLabel4;
        private WinControls.SKLabel skLabel3;
        private WinControls.SKLabel skLabel2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}
