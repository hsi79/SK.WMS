using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using C1.Win.C1Input;
using System.Windows.Forms;

namespace SK.WMS.WinControls
{


    public partial class SKTextBox :  C1TextBox
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
            // 
            // SKButton
            // 
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.SKTextBox_Layout);
            this.GotFocus += new EventHandler(SKTextBox_GotFocus);
            this.LostFocus += new EventHandler(SKTextBox_LostFocus);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BorderColor = ColorVar.BorderColor;
            this.BackColor = ColorVar.DefaultBackColor;
            this.ForeColor = ColorVar.ForeColor;
            this.TextAlign = HorizontalAlignment.Left;
            //this.VerticalAlign = VerticalAlignEnum.Middle;
            this.TextDetached = true;


            this.Size = new System.Drawing.Size(100, 21);
            //if (required)
            //{
            //    this.BackColor = ColorVar.RequiredBackColor;
            //    this.ForeColor = ColorVar.RequiredForeColor;
            //    this.BorderColor = ColorVar.RequiredBorderColor;
            //}

            this.ResumeLayout(false);

        }

        void SKTextBox_LostFocus(object sender, EventArgs e)
        {
            //this.BackColor = ColorVar.DefaultBackColor;
        }

        void SKTextBox_GotFocus(object sender, EventArgs e)
        {
            //this.BackColor = ColorVar.FocusBackColor;
        }

        #endregion

        private bool required;
        [Category("SK")]
        [Description("필수항목")]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool Required
        {
            get
            {
                return required;
            }
            set
            {
                required = value;
            }

        }
        public SKTextBox()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);





            if (required)
            {
                this.BackColor = ColorVar.RequiredBackColor;
                this.ForeColor = ColorVar.RequiredForeColor;
                this.BorderColor = ColorVar.RequiredBorderColor;
            }

            if (this.ReadOnly == true)
            {
                this.BackColor = Color.FromArgb(239, 239, 239);
            }

            if (this.Enabled == false)
            {
                this.BackColor = Color.FromArgb(239, 239, 239);
            }
        }
        private void SKTextBox_Layout(object sender, LayoutEventArgs e)
        {
            //this.FlatAppearance.BorderColor = Color.Transparent;

        }
    }
}
