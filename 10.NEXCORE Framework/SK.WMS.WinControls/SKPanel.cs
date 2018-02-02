using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Infragistics.Win.Misc;
//using SKS.MIS.Interfaces;
//using SKS.MIS.Common.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace SK.WMS.WinControls
{


    public partial class SKPanel : Panel
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
        const int SB_HORZ = 0;
        const int SB_VERT = 1;
        const int SB_CTL = 2;
        const int SB_BOTH = 3;

        [DllImport("user32.dll")]

        static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.SKPanel_Layout);
            this.ResumeLayout(false);
            
            base.AutoScroll = false;
            //base.VerticalScroll.Visible = true;
            //base.HorizontalScroll.Visible = false;
        }

        #endregion


        public SKPanel()
        {
            InitializeComponent();

        }
        //private bool vscroll;
        //[Category("SK")]
        //[Description("세로 스크롤바")]
        //[Browsable(true)]
        //[DefaultValue(true)]
        //public bool Vscroll
        //{
        //    get
        //    {
        //        return vscroll;
        //    }
        //    set
        //    {
        //        vscroll = value;
        //    }

        //}
        //private bool hscroll;
        //[Category("SK")]
        //[Description("가로 스크롤바")]
        //[Browsable(true)]
        //[DefaultValue(false)]
        //public bool Hscroll
        //{
        //    get
        //    {
        //        return hscroll;
        //    }
        //    set
        //    {
        //        hscroll = value;
        //    }

        //}



        

        protected override void OnPaint(PaintEventArgs pe)
        {
            ShowScrollBar(this.Handle, SB_HORZ, false);            

            base.OnPaint(pe);
        }
        private void SKPanel_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}
