using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NEXCORE.Utility
{
    public partial class ProgressControl : UserControl
    {
        private bool _IsOperationInProgress;
        public bool IsOperationInProgress
        {
            get { return _IsOperationInProgress; }
            set { _IsOperationInProgress = value; }
        }
                
        private BackgroundWorker bgwCommon;
        private PictureBox pictureBox1;
        private const int TOTAL_COUNT = 100;
        private const int OPERATION_TIME = 10;

        public ProgressControl()
        {
            InitializeComponent();
            //this.Visible = false;
        }

        public void RunProgress()
        {            
            IsOperationInProgress = true;
            bgwCommon.RunWorkerAsync();
            this.Visible = true;
        }

        //프로그래스바 종료 
        public void FinishProgress()
        {
            IsOperationInProgress = false;
            this.Visible = false;
        }

        private void bgwCommon_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= TOTAL_COUNT; i++)
            {
                Thread.Sleep(OPERATION_TIME);
                bgwCommon.ReportProgress(i);
            }
        }

        private void bgwCommon_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void bgwCommon_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsOperationInProgress = false;
            this.Visible = false;
        }
        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressControl));
            this.bgwCommon = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwCommon
            // 
            this.bgwCommon.WorkerReportsProgress = true;
            this.bgwCommon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCommon_DoWork);
            this.bgwCommon.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwCommon_ProgressChanged);
            this.bgwCommon.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCommon_RunWorkerCompleted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ProgressControl
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProgressControl";
            this.Size = new System.Drawing.Size(255, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }        
    }
}
