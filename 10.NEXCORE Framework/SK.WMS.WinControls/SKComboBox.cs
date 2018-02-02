using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1List;

namespace SK.WMS.WinControls
{


    public partial class SKComboBox :  C1Combo
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
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.SKComboBox_Layout);

            this.GotFocus += new EventHandler(SKComboBox_GotFocus);
            this.LostFocus += new EventHandler(SKComboBox_LostFocus);
            this.Leave += new System.EventHandler(SKComboBox_Leave);

            //this.EditorBackColor = ColorVar.DefaultBackColor;
            //this.BackColor = ColorVar.DefaultBackColor;
            //this.Style.Borders.Color = ColorVar.BorderColor;
            //this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(234, 242, 251);
            this.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;

            this.ColumnHeaders = false;
            this.AutoCompletion = true;
            this.MaxDropDownItems = 5;

            this.AutoSize = false;
            this.Size = new System.Drawing.Size(100, 21);
           
            //if (required)
            //{
            //    this.EditorBackColor = ColorVar.RequiredBackColor;
            //    this.ForeColor = ColorVar.RequiredForeColor;
            //    this.Style.Borders.Color = ColorVar.RequiredBorderColor;
            //}
            this.ResumeLayout(false);

        }

        void SKComboBox_LostFocus(object sender, EventArgs e)
        {
            //this.BackColor = ColorVar.DefaultBackColor;
        }

        void SKComboBox_GotFocus(object sender, EventArgs e)
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
        public SKComboBox()
        {

            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            //this.EditorBackColor = ColorVar.DefaultBackColor;
            //this.BackColor = ColorVar.DefaultBackColor;
            //this.Style.Borders.Color = ColorVar.BorderColor;
            //this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue;
            
            this.AutoDropDown = true;

            if (required)
            {
                this.EditorBackColor = ColorVar.RequiredBackColor;
                this.ForeColor = ColorVar.RequiredForeColor;
                this.Style.Borders.Color = ColorVar.RequiredBorderColor;
            }

            if (this.Enabled == false)
            {
                this.BackColor = Color.FromArgb(239, 239, 239);
            }
            //else
            //{
            //    this.BackColor = Color.FromArgb(234, 242, 251);
            //}
        }
        private void SKComboBox_Layout(object sender, LayoutEventArgs e)
        {
            

        }

        void SKComboBox_Leave(object sender, EventArgs e)
        {

            C1.Win.C1List.C1Combo cbo = sender as C1.Win.C1List.C1Combo;

            if (cbo.ListCount > 0 && cbo.SelectedIndex == -1)
            {
                cbo.Focus();
            }
        }

        /// <summary>
        /// 사용자 정의
        /// Combo 초기화
        /// </summary>
        public void Clear()
        {
            this.DataSource = null;
            this.Text = "";
        }

        /// <summary>
        /// 사용자 정의
        /// Combo 데이터 바인딩
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="display">보여지는 값</param>
        /// <param name="value">실제 값</param>
        public void DataBinding(DataTable dt, string display, string value)
        {
            DataBinding(dt, display, value, false);
        }
        /// <summary>
        /// 사용자 정의
        /// Combo 데이터 바인딩
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="display">보여지는 값</param>
        /// <param name="value">실제 값</param>
        /// <param name="addAllRow">"전체" 여부</param>
        public void DataBinding(DataTable dt, string display, string value, bool addAllRow)
        {
            DataBinding(dt, display, value, addAllRow, true);
        }

        /// <summary>
        /// 사용자 정의
        /// Combo 데이터 바인딩
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="display">보여지는 값</param>
        /// <param name="value">실제 값</param>
        /// <param name="addAllRow">"전체" 여부</param>
        /// <param name="selected">첫번째 행 선택 여부</param>
        public void DataBinding(DataTable dt, string display, string value, bool addAllRow, bool selected)
        {
            DataBinding(dt, display, value, addAllRow, true, false);
        }

        /// <summary>
        /// 사용자 정의
        /// Combo 데이터 바인딩
        /// </summary>
        /// <param name="dt">DataTable</param>
        /// <param name="display">보여지는 값</param>
        /// <param name="value">실제 값</param>
        /// <param name="addAllRow">"전체" 여부</param>
        /// <param name="selected">첫번째 행 선택 여부</param>
        public void DataBinding(DataTable dt, string display, string value, bool addAllRow, bool selected, bool addBlank)
        {
            this.DisplayMember = display;
            this.ValueMember = value;

            if (addAllRow)
            {
                DataRow dr = dt.NewRow();
                dr[display] = "전체";
                dr[value] = "";
                dt.Rows.InsertAt(dr, 0);
            }

            if (addBlank)
            {
                DataRow dr = dt.NewRow();
                dr[display] = "";
                dr[value] = "";
                dt.Rows.InsertAt(dr, 0);
            }

            this.DataSource = dt;


            for (int i = 0; i < this.Splits[0, 0].DisplayColumns.Count; i++)
            {
                if (!this.Splits[0, 0].DisplayColumns[i].Name.Equals(display))
                    this.Splits[0, 0].DisplayColumns[i].Visible = false;
            }


            if (this.ListCount >= this.MaxDropDownItems)
                this.ColumnWidth = this.Width - 20;
            else
                this.ColumnWidth = this.Width - 3;

            if (selected)
            {
                this.SelectedIndex = 0;
            }
        }
    }
}
