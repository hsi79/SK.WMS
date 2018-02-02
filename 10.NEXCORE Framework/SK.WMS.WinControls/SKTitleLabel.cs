using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace SK.WMS.WinControls
{


    public partial class SKtitleLabel :  Label
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
            this.SuspendLayout();
            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.SKtitleLabel_Layout);
            this.Text = "검색 조건";

            this.AutoSize = false;

            this.ResumeLayout(false);

        }

        #endregion

        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {

            }
        }
        public SKtitleLabel()
        {
            this.AutoSize = false;
            InitializeComponent();



        }



        protected override void OnPaint(PaintEventArgs pe)
        {


            base.OnPaint(pe);
            this.BackColor = Color.FromArgb(234, 242, 251);
            this.ForeColor = ColorVar.TitleForeColor;
            //this.TextAlign = ContentAlignment.MiddleLeft;
            

        }

        private void SKtitleLabel_Layout(object sender, LayoutEventArgs e)
        {
            //this.FlatAppearance.BorderColor = Color.Transparent;

        }


    }
}
