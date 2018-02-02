namespace SK.WMS.WinControls
{
    partial class SKCommonButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SKCommonButton));
            this.btnSearch = new C1.Win.C1Input.C1Button();
            this.btnSave = new C1.Win.C1Input.C1Button();
            this.btnDelete = new C1.Win.C1Input.C1Button();
            this.btnNew = new C1.Win.C1Input.C1Button();
            this.btnPrint = new C1.Win.C1Input.C1Button();
            this.btnExcel = new C1.Win.C1Input.C1Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Image = global::SK.WMS.WinControls.Properties.Resources.조회_1_normal;
            this.btnSearch.Location = new System.Drawing.Point(117, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Tag = "R";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnSearch.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Image = global::SK.WMS.WinControls.Properties.Resources.저장_1_normal;
            this.btnSave.Location = new System.Drawing.Point(329, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Tag = "S";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Image = global::SK.WMS.WinControls.Properties.Resources.삭제_1_normal;
            this.btnDelete.Location = new System.Drawing.Point(435, 7);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Tag = "D";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnNew.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Image = global::SK.WMS.WinControls.Properties.Resources.신규_1_normal;
            this.btnNew.Location = new System.Drawing.Point(223, 7);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 25);
            this.btnNew.TabIndex = 2;
            this.btnNew.Tag = "S";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnNew.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnNew.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            this.btnNew.MouseLeave += new System.EventHandler(this.btnNew_MouseLeave);
            this.btnNew.MouseHover += new System.EventHandler(this.btnNew_MouseHover);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnPrint.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrint.Image = global::SK.WMS.WinControls.Properties.Resources.인쇄_1_normal;
            this.btnPrint.Location = new System.Drawing.Point(647, 7);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 25);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Tag = "P";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnPrint.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            this.btnPrint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            this.btnPrint.MouseLeave += new System.EventHandler(this.btnPrint_MouseLeave);
            this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.White;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnExcel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.Image = global::SK.WMS.WinControls.Properties.Resources.엑셀_1_normal;
            this.btnExcel.Location = new System.Drawing.Point(541, 7);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 25);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Tag = "E";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnExcel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Black;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            this.btnExcel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            this.btnExcel.MouseLeave += new System.EventHandler(this.btnExcel_MouseLeave);
            this.btnExcel.MouseHover += new System.EventHandler(this.btnExcel_MouseHover);
            // 
            // SKCommonButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SKCommonButton";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Size = new System.Drawing.Size(756, 37);
            this.Load += new System.EventHandler(this.SKCommonButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1Button btnSearch;
        private C1.Win.C1Input.C1Button btnSave;
        private C1.Win.C1Input.C1Button btnDelete;
        private C1.Win.C1Input.C1Button btnNew;
        private C1.Win.C1Input.C1Button btnPrint;
        private C1.Win.C1Input.C1Button btnExcel;

    }
}
