namespace SK.WMS.Launcher
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainHolder = new C1.Win.C1Command.C1CommandHolder();
            this.c1MainMenu1 = new C1.Win.C1Command.C1MainMenu();
            this.tabBottom = new C1.Win.C1Command.C1DockingTab();
            this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
            this.StatusBar = new C1.Win.C1Ribbon.C1StatusBar();
            this.lblWrite = new C1.Win.C1Ribbon.RibbonLabel();
            this.lblUser = new C1.Win.C1Ribbon.RibbonLabel();
            this.tabMain = new C1.Win.C1Command.C1DockingTab();
            ((System.ComponentModel.ISupportInitialize)(this.MainHolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabBottom)).BeginInit();
            this.tabBottom.SuspendLayout();
            this.c1DockingTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MainHolder
            // 
            this.MainHolder.Owner = this;
            this.MainHolder.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Silver;
            // 
            // c1MainMenu1
            // 
            this.c1MainMenu1.AccessibleName = "Menu Bar";
            this.c1MainMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.c1MainMenu1.CommandHolder = null;
            this.c1MainMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1MainMenu1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c1MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.c1MainMenu1.Name = "c1MainMenu1";
            this.c1MainMenu1.Size = new System.Drawing.Size(1212, 28);
            this.c1MainMenu1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.c1MainMenu1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
            // 
            // tabBottom
            // 
            this.tabBottom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabBottom.BackColor = System.Drawing.Color.White;
            this.tabBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBottom.Controls.Add(this.c1DockingTabPage3);
            this.tabBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabBottom.Location = new System.Drawing.Point(0, 667);
            this.tabBottom.Name = "tabBottom";
            this.tabBottom.SelectedIndex = 1;
            this.tabBottom.ShowTabs = false;
            this.tabBottom.Size = new System.Drawing.Size(1212, 25);
            this.tabBottom.SplitterWidth = 1;
            this.tabBottom.TabAreaSpacing = 0;
            this.tabBottom.TabIndex = 47;
            this.tabBottom.TabsCanFocus = false;
            this.tabBottom.TabsSpacing = 1;
            this.tabBottom.TabStyle = C1.Win.C1Command.TabStyleEnum.Sloping;
            this.tabBottom.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.tabBottom.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1DockingTabPage3
            // 
            this.c1DockingTabPage3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c1DockingTabPage3.BackColor = System.Drawing.Color.White;
            this.c1DockingTabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.c1DockingTabPage3.Controls.Add(this.StatusBar);
            this.c1DockingTabPage3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.c1DockingTabPage3.ForeColor = System.Drawing.Color.Black;
            this.c1DockingTabPage3.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTabPage3.Name = "c1DockingTabPage3";
            this.c1DockingTabPage3.Size = new System.Drawing.Size(1212, 24);
            this.c1DockingTabPage3.TabBackColor = System.Drawing.Color.White;
            this.c1DockingTabPage3.TabBackColorSelected = System.Drawing.Color.White;
            this.c1DockingTabPage3.TabForeColor = System.Drawing.Color.Black;
            this.c1DockingTabPage3.TabForeColorSelected = System.Drawing.Color.White;
            this.c1DockingTabPage3.TabIndex = 0;
            this.c1DockingTabPage3.TabStop = false;
            // 
            // StatusBar
            // 
            this.StatusBar.LeftPaneItems.Add(this.lblWrite);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RightPaneItems.Add(this.lblUser);
            // 
            // lblWrite
            // 
            this.lblWrite.Name = "lblWrite";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Text = "홍길동 - 출하반";
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabMain.CanAutoHide = true;
            this.tabMain.CanCloseTabs = true;
            this.tabMain.CanMoveTabs = true;
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.HotTrack = true;
            this.tabMain.Location = new System.Drawing.Point(0, 28);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabBold = true;
            this.tabMain.ShowTabList = true;
            this.tabMain.Size = new System.Drawing.Size(1212, 639);
            this.tabMain.TabIndex = 49;
            this.tabMain.TabLook = ((C1.Win.C1Command.ButtonLookFlags)((C1.Win.C1Command.ButtonLookFlags.Text | C1.Win.C1Command.ButtonLookFlags.Image)));
            this.tabMain.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.tabMain.TabsSpacing = 5;
            this.tabMain.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010;
            this.tabMain.VisualStyle = C1.Win.C1Command.VisualStyle.Custom;
            this.tabMain.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1212, 692);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.tabBottom);
            this.Controls.Add(this.c1MainMenu1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SK WMS";
            this.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainHolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabBottom)).EndInit();
            this.tabBottom.ResumeLayout(false);
            this.c1DockingTabPage3.ResumeLayout(false);
            this.c1DockingTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        #region "변수 선언"

        private C1.Win.C1Command.C1CommandHolder MainHolder;
        private C1.Win.C1Command.C1MainMenu c1MainMenu1;
     
        #endregion

        //private System.Windows.Forms.WebBrowser weatherInfo;
        private C1.Win.C1Command.C1DockingTab tabBottom;
        private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
        private C1.Win.C1Ribbon.C1StatusBar StatusBar;
        private C1.Win.C1Ribbon.RibbonLabel lblWrite;
        private C1.Win.C1Ribbon.RibbonLabel lblUser;
        private C1.Win.C1Command.C1DockingTab tabMain;
    }
}