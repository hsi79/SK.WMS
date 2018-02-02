namespace SK.WMS.WinControls
{
    partial class FileUpControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileUpControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpload = new C1.Win.C1Input.C1Button();
            this.btnFileDelete = new C1.Win.C1Input.C1Button();
            this.btnFileAdd = new C1.Win.C1Input.C1Button();
            this.listFile = new System.Windows.Forms.ListBox();
            this.c1InputPanel2 = new C1.Win.C1InputPanel.C1InputPanel();
            this.inputGroupHeader1 = new C1.Win.C1InputPanel.InputGroupHeader();
            this.inputLabel1 = new C1.Win.C1InputPanel.InputLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnFileDelete);
            this.panel1.Controls.Add(this.btnFileAdd);
            this.panel1.Controls.Add(this.listFile);
            this.panel1.Controls.Add(this.c1InputPanel2);
            this.panel1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 275);
            this.panel1.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(168, 240);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(77, 25);
            this.btnUpload.TabIndex = 50;
            this.btnUpload.Text = "업로드";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnFileDelete
            // 
            this.btnFileDelete.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFileDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnFileDelete.Image")));
            this.btnFileDelete.Location = new System.Drawing.Point(86, 240);
            this.btnFileDelete.Name = "btnFileDelete";
            this.btnFileDelete.Size = new System.Drawing.Size(77, 25);
            this.btnFileDelete.TabIndex = 49;
            this.btnFileDelete.Text = "삭제";
            this.btnFileDelete.UseVisualStyleBackColor = true;
            this.btnFileDelete.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnFileDelete.Click += new System.EventHandler(this.btnFileDelete_Click);
            // 
            // btnFileAdd
            // 
            this.btnFileAdd.FlatAppearance.BorderSize = 0;
            this.btnFileAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileAdd.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFileAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnFileAdd.Image")));
            this.btnFileAdd.Location = new System.Drawing.Point(4, 240);
            this.btnFileAdd.Name = "btnFileAdd";
            this.btnFileAdd.Size = new System.Drawing.Size(77, 25);
            this.btnFileAdd.TabIndex = 48;
            this.btnFileAdd.Text = "추가";
            this.btnFileAdd.UseVisualStyleBackColor = true;
            this.btnFileAdd.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnFileAdd.Click += new System.EventHandler(this.btnFileAdd_Click);
            // 
            // listFile
            // 
            this.listFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listFile.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listFile.FormattingEnabled = true;
            this.listFile.ItemHeight = 15;
            this.listFile.Location = new System.Drawing.Point(14, 30);
            this.listFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFile.Name = "listFile";
            this.listFile.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listFile.Size = new System.Drawing.Size(223, 197);
            this.listFile.TabIndex = 0;
            // 
            // c1InputPanel2
            // 
            this.c1InputPanel2.BackColor = System.Drawing.Color.White;
            this.c1InputPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1InputPanel2.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.c1InputPanel2.Items.Add(this.inputGroupHeader1);
            this.c1InputPanel2.Items.Add(this.inputLabel1);
            this.c1InputPanel2.Location = new System.Drawing.Point(1, 2);
            this.c1InputPanel2.Name = "c1InputPanel2";
            this.c1InputPanel2.Size = new System.Drawing.Size(251, 234);
            this.c1InputPanel2.TabIndex = 51;
            this.c1InputPanel2.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2010Silver;
            // 
            // inputGroupHeader1
            // 
            this.inputGroupHeader1.BackColor = System.Drawing.Color.DimGray;
            this.inputGroupHeader1.ForeColor = System.Drawing.Color.White;
            this.inputGroupHeader1.Height = 46;
            this.inputGroupHeader1.Name = "inputGroupHeader1";
            this.inputGroupHeader1.Text = "첨부파일";
            // 
            // inputLabel1
            // 
            this.inputLabel1.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Text = "                 ";
            // 
            // FileUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FileUpControl";
            this.Size = new System.Drawing.Size(265, 287);
            this.Load += new System.EventHandler(this.FileUpControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listFile;
        private C1.Win.C1Input.C1Button btnUpload;
        private C1.Win.C1Input.C1Button btnFileDelete;
        private C1.Win.C1Input.C1Button btnFileAdd;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel2;
        private C1.Win.C1InputPanel.InputGroupHeader inputGroupHeader1;
        private C1.Win.C1InputPanel.InputLabel inputLabel1;
    }
}
