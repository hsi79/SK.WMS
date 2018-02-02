﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Command;


namespace SK.WMS.WinControls
{


    public partial class SKDockingTab : C1DockingTab
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

            this.BackColor = ColorVar.DefaultBackColor;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;

            this.ResumeLayout(false);

        }

        
        #endregion

        public SKDockingTab()
        {

            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.BackColor = ColorVar.DefaultBackColor;
            this.ForeColor = ColorVar.ForeColor;

        }
        

    }
}
