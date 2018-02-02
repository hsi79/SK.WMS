namespace SK.WMS.SM.UI
{
    partial class UserMgmt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMgmt));
            this.pnlUserMgmt = new SK.WMS.WinControls.SKPanel();
            this.skcGroupBox3 = new SK.WMS.WinControls.SKGroupBox();
            this.skCtitleLabel3 = new SK.WMS.WinControls.SKtitleLabel();
            this.fxUserList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.skcGroupBox2 = new SK.WMS.WinControls.SKGroupBox();
            this.chkLock = new System.Windows.Forms.CheckBox();
            this.txtLoginId = new SK.WMS.WinControls.SKTextBox();
            this.btnDept = new C1.Win.C1Input.C1Button();
            this.btnInit = new C1.Win.C1Input.C1Button();
            this.skcLabel14 = new SK.WMS.WinControls.SKLabel();
            this.skcLabel13 = new SK.WMS.WinControls.SKLabel();
            this.txtEmail = new SK.WMS.WinControls.SKTextBox();
            this.skcLabel12 = new SK.WMS.WinControls.SKLabel();
            this.txtTel = new SK.WMS.WinControls.SKTextBox();
            this.skcLabel11 = new SK.WMS.WinControls.SKLabel();
            this.txtMobile = new SK.WMS.WinControls.SKTextBox();
            this.skcLabel5 = new SK.WMS.WinControls.SKLabel();
            this.lblUserNm = new SK.WMS.WinControls.SKLabel();
            this.txtUserNm = new SK.WMS.WinControls.SKTextBox();
            this.lblUserID = new SK.WMS.WinControls.SKLabel();
            this.txtUserID = new SK.WMS.WinControls.SKTextBox();
            this.skCtitleLabel2 = new SK.WMS.WinControls.SKtitleLabel();
            this.skcGroupBox1 = new SK.WMS.WinControls.SKGroupBox();
            this.skcLabel1 = new SK.WMS.WinControls.SKLabel();
            this.searchUserNm = new SK.WMS.WinControls.SKTextBox();
            this.skCtitleLabel1 = new SK.WMS.WinControls.SKtitleLabel();
            this.commonButton1 = new SK.WMS.WinControls.CommonButton();
            this.pnlUserMgmt.SuspendLayout();
            this.skcGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fxUserList)).BeginInit();
            this.skcGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID)).BeginInit();
            this.skcGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchUserNm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUserMgmt
            // 
            this.pnlUserMgmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserMgmt.Controls.Add(this.skcGroupBox3);
            this.pnlUserMgmt.Controls.Add(this.skcGroupBox2);
            this.pnlUserMgmt.Controls.Add(this.skcGroupBox1);
            this.pnlUserMgmt.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnlUserMgmt.Location = new System.Drawing.Point(0, 47);
            this.pnlUserMgmt.Name = "pnlUserMgmt";
            this.pnlUserMgmt.Size = new System.Drawing.Size(962, 605);
            this.pnlUserMgmt.TabIndex = 60;
            // 
            // skcGroupBox3
            // 
            this.skcGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skcGroupBox3.BackColor = System.Drawing.Color.White;
            this.skcGroupBox3.Controls.Add(this.skCtitleLabel3);
            this.skcGroupBox3.Controls.Add(this.fxUserList);
            this.skcGroupBox3.Font = new System.Drawing.Font("맑은 고딕", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.skcGroupBox3.Location = new System.Drawing.Point(4, 254);
            this.skcGroupBox3.Name = "skcGroupBox3";
            this.skcGroupBox3.Size = new System.Drawing.Size(955, 351);
            this.skcGroupBox3.TabIndex = 62;
            this.skcGroupBox3.TabStop = false;
            // 
            // skCtitleLabel3
            // 
            this.skCtitleLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skCtitleLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.skCtitleLabel3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCtitleLabel3.ForeColor = System.Drawing.Color.Black;
            this.skCtitleLabel3.Location = new System.Drawing.Point(7, 5);
            this.skCtitleLabel3.Name = "skCtitleLabel3";
            this.skCtitleLabel3.Size = new System.Drawing.Size(942, 23);
            this.skCtitleLabel3.TabIndex = 60;
            this.skCtitleLabel3.Text = "사용자 리스트";
            this.skCtitleLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fxUserList
            // 
            this.fxUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fxUserList.AutoClipboard = true;
            this.fxUserList.BackColor = System.Drawing.Color.White;
            this.fxUserList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.fxUserList.ColumnInfo = "3,1,0,0,0,40,Columns:";
            this.fxUserList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus;
            this.fxUserList.Location = new System.Drawing.Point(2, 31);
            this.fxUserList.Name = "fxUserList";
            this.fxUserList.Rows.Count = 1;
            this.fxUserList.Rows.DefaultSize = 8;
            this.fxUserList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fxUserList.ShowCellLabels = true;
            this.fxUserList.Size = new System.Drawing.Size(953, 314);
            this.fxUserList.StyleInfo = resources.GetString("fxUserList.StyleInfo");
            this.fxUserList.TabIndex = 20;
            this.fxUserList.RowColChange += new System.EventHandler(this.fxUserList_RowColChange);
            // 
            // skcGroupBox2
            // 
            this.skcGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skcGroupBox2.BackColor = System.Drawing.Color.White;
            this.skcGroupBox2.Controls.Add(this.chkLock);
            this.skcGroupBox2.Controls.Add(this.txtLoginId);
            this.skcGroupBox2.Controls.Add(this.btnDept);
            this.skcGroupBox2.Controls.Add(this.btnInit);
            this.skcGroupBox2.Controls.Add(this.skcLabel14);
            this.skcGroupBox2.Controls.Add(this.skcLabel13);
            this.skcGroupBox2.Controls.Add(this.txtEmail);
            this.skcGroupBox2.Controls.Add(this.skcLabel12);
            this.skcGroupBox2.Controls.Add(this.txtTel);
            this.skcGroupBox2.Controls.Add(this.skcLabel11);
            this.skcGroupBox2.Controls.Add(this.txtMobile);
            this.skcGroupBox2.Controls.Add(this.skcLabel5);
            this.skcGroupBox2.Controls.Add(this.lblUserNm);
            this.skcGroupBox2.Controls.Add(this.txtUserNm);
            this.skcGroupBox2.Controls.Add(this.lblUserID);
            this.skcGroupBox2.Controls.Add(this.txtUserID);
            this.skcGroupBox2.Controls.Add(this.skCtitleLabel2);
            this.skcGroupBox2.Font = new System.Drawing.Font("맑은 고딕", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skcGroupBox2.Location = new System.Drawing.Point(4, 73);
            this.skcGroupBox2.Name = "skcGroupBox2";
            this.skcGroupBox2.Size = new System.Drawing.Size(955, 174);
            this.skcGroupBox2.TabIndex = 61;
            this.skcGroupBox2.TabStop = false;
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.Location = new System.Drawing.Point(95, 100);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(15, 14);
            this.chkLock.TabIndex = 28;
            this.chkLock.UseVisualStyleBackColor = true;
            // 
            // txtLoginId
            // 
            this.txtLoginId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.txtLoginId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginId.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtLoginId.Location = new System.Drawing.Point(535, 145);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(150, 21);
            this.txtLoginId.TabIndex = 27;
            this.txtLoginId.Tag = null;
            this.txtLoginId.TextDetached = true;
            this.txtLoginId.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtLoginId.Visible = false;
            this.txtLoginId.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txtLoginId.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(691, 143);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(23, 23);
            this.btnDept.TabIndex = 49;
            this.btnDept.Text = "..";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Visible = false;
            this.btnDept.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // btnInit
            // 
            this.btnInit.FlatAppearance.BorderSize = 0;
            this.btnInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInit.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInit.Image = ((System.Drawing.Image)(resources.GetObject("btnInit.Image")));
            this.btnInit.Location = new System.Drawing.Point(666, 35);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(77, 25);
            this.btnInit.TabIndex = 59;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            this.btnInit.MouseLeave += new System.EventHandler(this.btnInit_MouseLeave);
            this.btnInit.MouseHover += new System.EventHandler(this.btnInit_MouseHover);
            // 
            // skcLabel14
            // 
            this.skcLabel14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcLabel14.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skcLabel14.Location = new System.Drawing.Point(8, 100);
            this.skcLabel14.Name = "skcLabel14";
            this.skcLabel14.Size = new System.Drawing.Size(80, 15);
            this.skcLabel14.TabIndex = 26;
            this.skcLabel14.Text = "사용금지";
            // 
            // skcLabel13
            // 
            this.skcLabel13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcLabel13.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skcLabel13.Location = new System.Drawing.Point(581, 71);
            this.skcLabel13.Name = "skcLabel13";
            this.skcLabel13.Size = new System.Drawing.Size(80, 15);
            this.skcLabel13.TabIndex = 24;
            this.skcLabel13.Text = "이메일";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEmail.Location = new System.Drawing.Point(666, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 21);
            this.txtEmail.TabIndex = 23;
            this.txtEmail.Tag = null;
            this.txtEmail.TextDetached = true;
            this.txtEmail.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtEmail.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txtEmail.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // skcLabel12
            // 
            this.skcLabel12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcLabel12.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skcLabel12.Location = new System.Drawing.Point(294, 71);
            this.skcLabel12.Name = "skcLabel12";
            this.skcLabel12.Size = new System.Drawing.Size(80, 15);
            this.skcLabel12.TabIndex = 22;
            this.skcLabel12.Text = "전화번호";
            // 
            // txtTel
            // 
            this.txtTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTel.Location = new System.Drawing.Point(379, 69);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(150, 21);
            this.txtTel.TabIndex = 21;
            this.txtTel.Tag = null;
            this.txtTel.TextDetached = true;
            this.txtTel.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtTel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txtTel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // skcLabel11
            // 
            this.skcLabel11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcLabel11.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skcLabel11.Location = new System.Drawing.Point(8, 71);
            this.skcLabel11.Name = "skcLabel11";
            this.skcLabel11.Size = new System.Drawing.Size(80, 15);
            this.skcLabel11.TabIndex = 20;
            this.skcLabel11.Text = "휴대폰";
            // 
            // txtMobile
            // 
            this.txtMobile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMobile.Location = new System.Drawing.Point(93, 69);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(150, 21);
            this.txtMobile.TabIndex = 19;
            this.txtMobile.Tag = null;
            this.txtMobile.TextDetached = true;
            this.txtMobile.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtMobile.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txtMobile.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // skcLabel5
            // 
            this.skcLabel5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcLabel5.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skcLabel5.Location = new System.Drawing.Point(579, 39);
            this.skcLabel5.Name = "skcLabel5";
            this.skcLabel5.Size = new System.Drawing.Size(80, 15);
            this.skcLabel5.TabIndex = 7;
            this.skcLabel5.Text = "비밀번호";
            // 
            // lblUserNm
            // 
            this.lblUserNm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserNm.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.lblUserNm.Location = new System.Drawing.Point(293, 39);
            this.lblUserNm.Name = "lblUserNm";
            this.lblUserNm.Size = new System.Drawing.Size(80, 15);
            this.lblUserNm.TabIndex = 4;
            this.lblUserNm.Text = "사용자 명";
            // 
            // txtUserNm
            // 
            this.txtUserNm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.txtUserNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserNm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserNm.Location = new System.Drawing.Point(379, 37);
            this.txtUserNm.Name = "txtUserNm";
            this.txtUserNm.Required = true;
            this.txtUserNm.Size = new System.Drawing.Size(150, 21);
            this.txtUserNm.TabIndex = 3;
            this.txtUserNm.Tag = null;
            this.txtUserNm.TextDetached = true;
            this.txtUserNm.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtUserNm.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txtUserNm.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserID.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.lblUserID.Location = new System.Drawing.Point(8, 39);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(80, 15);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "사용자 ID";
            // 
            // txtUserID
            // 
            this.txtUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserID.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUserID.Location = new System.Drawing.Point(93, 37);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Required = true;
            this.txtUserID.Size = new System.Drawing.Size(150, 21);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Tag = null;
            this.txtUserID.TextDetached = true;
            this.txtUserID.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtUserID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.txtUserID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // skCtitleLabel2
            // 
            this.skCtitleLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skCtitleLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.skCtitleLabel2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCtitleLabel2.ForeColor = System.Drawing.Color.Black;
            this.skCtitleLabel2.Location = new System.Drawing.Point(7, 9);
            this.skCtitleLabel2.Name = "skCtitleLabel2";
            this.skCtitleLabel2.Size = new System.Drawing.Size(942, 23);
            this.skCtitleLabel2.TabIndex = 0;
            this.skCtitleLabel2.Text = "입력 항목";
            this.skCtitleLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skcGroupBox1
            // 
            this.skcGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skcGroupBox1.BackColor = System.Drawing.Color.White;
            this.skcGroupBox1.Controls.Add(this.skcLabel1);
            this.skcGroupBox1.Controls.Add(this.searchUserNm);
            this.skcGroupBox1.Controls.Add(this.skCtitleLabel1);
            this.skcGroupBox1.Font = new System.Drawing.Font("맑은 고딕", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skcGroupBox1.Location = new System.Drawing.Point(4, 4);
            this.skcGroupBox1.Name = "skcGroupBox1";
            this.skcGroupBox1.Size = new System.Drawing.Size(955, 63);
            this.skcGroupBox1.TabIndex = 60;
            this.skcGroupBox1.TabStop = false;
            // 
            // skcLabel1
            // 
            this.skcLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skcLabel1.LabelType = SK.WMS.WinControls.SKLabel.LABEL_TYPE.Default;
            this.skcLabel1.Location = new System.Drawing.Point(8, 37);
            this.skcLabel1.Name = "skcLabel1";
            this.skcLabel1.Size = new System.Drawing.Size(80, 15);
            this.skcLabel1.TabIndex = 2;
            this.skcLabel1.Text = "사용자 명";
            // 
            // searchUserNm
            // 
            this.searchUserNm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(187)))), ((int)(((byte)(198)))));
            this.searchUserNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchUserNm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchUserNm.Location = new System.Drawing.Point(93, 35);
            this.searchUserNm.Name = "searchUserNm";
            this.searchUserNm.Size = new System.Drawing.Size(150, 21);
            this.searchUserNm.TabIndex = 1;
            this.searchUserNm.Tag = null;
            this.searchUserNm.TextDetached = true;
            this.searchUserNm.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.searchUserNm.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            this.searchUserNm.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // skCtitleLabel1
            // 
            this.skCtitleLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skCtitleLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.skCtitleLabel1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.skCtitleLabel1.ForeColor = System.Drawing.Color.Black;
            this.skCtitleLabel1.Location = new System.Drawing.Point(7, 9);
            this.skCtitleLabel1.Name = "skCtitleLabel1";
            this.skCtitleLabel1.Size = new System.Drawing.Size(942, 23);
            this.skCtitleLabel1.TabIndex = 0;
            this.skCtitleLabel1.Text = "검색 조건";
            this.skCtitleLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // commonButton1
            // 
            this.commonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commonButton1.BackColor = System.Drawing.Color.Transparent;
            this.commonButton1.BindingGrid = false;
            this.commonButton1.BindingGridControl = null;
            this.commonButton1.DelCol = 0;
            this.commonButton1.ExcelEnable = false;
            this.commonButton1.ExcelName = "Excel";
            this.commonButton1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.commonButton1.Location = new System.Drawing.Point(2, 3);
            this.commonButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commonButton1.Name = "commonButton1";
            this.commonButton1.NewName = "신 규";
            this.commonButton1.Padding = new System.Windows.Forms.Padding(6);
            this.commonButton1.PrintEnable = false;
            this.commonButton1.PrintName = "Print";
            this.commonButton1.Size = new System.Drawing.Size(960, 36);
            this.commonButton1.TabIndex = 28;
            this.commonButton1.OnSearchClick += new System.EventHandler(this.commonButton1_OnSearchClick);
            this.commonButton1.OnSaveClick += new System.EventHandler(this.commonButton1_OnSaveClick);
            this.commonButton1.OnDeleteClick += new System.EventHandler(this.commonButton1_OnDeleteClick);
            this.commonButton1.OnNewClick += new System.EventHandler(this.commonButton1_OnNewClick);
            // 
            // UserMgmt
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlUserMgmt);
            this.Controls.Add(this.commonButton1);
            this.Name = "UserMgmt";
            this.Size = new System.Drawing.Size(966, 655);
            this.pnlUserMgmt.ResumeLayout(false);
            this.skcGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fxUserList)).EndInit();
            this.skcGroupBox2.ResumeLayout(false);
            this.skcGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID)).EndInit();
            this.skcGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchUserNm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid fxUserList;
        private WinControls.CommonButton commonButton1;
        private C1.Win.C1Input.C1Button btnDept;
        private C1.Win.C1Input.C1Button btnInit;
        private WinControls.SKPanel pnlUserMgmt;
        private WinControls.SKGroupBox skcGroupBox1;
        private WinControls.SKLabel skcLabel1;
        private WinControls.SKTextBox searchUserNm;
        private WinControls.SKtitleLabel skCtitleLabel1;
        private WinControls.SKGroupBox skcGroupBox2;
        private WinControls.SKLabel lblUserNm;
        private WinControls.SKTextBox txtUserNm;
        private WinControls.SKLabel lblUserID;
        private WinControls.SKTextBox txtUserID;
        private WinControls.SKtitleLabel skCtitleLabel2;
        private WinControls.SKLabel skcLabel5;
        private WinControls.SKLabel skcLabel14;
        private WinControls.SKLabel skcLabel13;
        private WinControls.SKTextBox txtEmail;
        private WinControls.SKLabel skcLabel12;
        private WinControls.SKTextBox txtTel;
        private WinControls.SKLabel skcLabel11;
        private WinControls.SKTextBox txtMobile;
        private System.Windows.Forms.CheckBox chkLock;
        private WinControls.SKTextBox txtLoginId;
        private WinControls.SKGroupBox skcGroupBox3;
        private WinControls.SKtitleLabel skCtitleLabel3;
    }
}
