using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;

namespace SK.WMS.WinControls
{
    public partial class CommonButton : UserControl
    {
        SKUserControlBase form = null;
        public CommonButton()
        {
            InitializeComponent();


        }
        [Category("SK CommandButton Visible")]
        [Description("공통 버튼 Visible")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool SearchVisible
        {
            get
            {
                return btnSearch.Visible;
            }
            set
            {
                btnSearch.Visible = value;
            }

        }
        [Category("SK CommandButton Enable")]
        [Description("공통 버튼 Enable")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool SearchEnable
        {
            get
            {
                return btnSearch.Enabled;
            }
            set
            {
                btnSearch.Enabled = value;
            }
        }
        [Category("SK CommandButton Visible")]
        [Description("공통 버튼 Visible")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool SaveVisible
        {
            get
            {
                return btnSave.Visible;
            }
            set
            {
                btnSave.Visible = value;
            }
        }
        [Category("SK CommandButton Enable")]
        [Description("공통 버튼 Enable")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool SaveEnable
        {
            get
            {
                return btnSave.Enabled;
            }
            set
            {
                btnSave.Enabled = value;
            }
        }
        [Category("SK CommandButton Visible")]
        [Description("공통 버튼 Visible")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool DeleteVisible
        {
            get
            {
                return btnDelete.Visible;
            }
            set
            {
                btnDelete.Visible = value;
            }
        }
        [Category("SK CommandButton Enable")]
        [Description("공통 버튼 Enable")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool DeleteEnable
        {
            get
            {
                return btnDelete.Enabled;
            }
            set
            {
                btnDelete.Enabled = value;
            }
        }
        [Category("SK CommandButton Visible")]
        [Description("공통 버튼 Visible")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool ExcelVisible
        {
            get
            {
                return btnExcel.Visible;
            }
            set
            {
                btnExcel.Visible = value;
            }
        }
        [Category("SK CommandButton Enable")]
        [Description("공통 버튼 Enable")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool ExcelEnable
        {
            get
            {
                return btnExcel.Enabled;
            }
            set
            {
                btnExcel.Enabled = value;
            }
        }
        [Category("SK CommandButton Visible")]
        [Description("공통 버튼 Visible")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool PrintVisible
        {
            get
            {
                return btnPrint.Visible;
            }
            set
            {
                btnPrint.Visible = value;
            }
        }
        [Category("SK CommandButton Enable")]
        [Description("공통 버튼 Enable")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool PrintEnable
        {
            get
            {
                return btnPrint.Enabled;
            }
            set
            {
                btnPrint.Enabled = value;
            }
        }
        [Category("SK CommandButton Visible")]
        [Description("공통 버튼 Visible")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool NewVisible
        {
            get
            {
                return btnNew.Visible;
            }
            set
            {
                btnNew.Visible = value;
            }
        }
        [Category("SK CommandButton Enable")]
        [Description("공통 버튼 Enable")]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool NewEnable
        {
            get
            {
                return btnNew.Enabled;
            }
            set
            {
                btnNew.Enabled = value;
            }
        }
        [Category("SK CommandButton Name")]
        [Description("공통 버튼 이름")]
        [Browsable(true)]
        [DefaultValue("조 회")]
        public string SearchName
        {
            get
            {
                return btnSearch.Text;
            }
            set
            {
                btnSearch.Text = value;
            }
        }
        [Category("SK CommandButton Name")]
        [Description("공통 버튼 이름")]
        [Browsable(true)]
        [DefaultValue("저 장")]
        public string SaveName
        {
            get
            {
                return btnSave.Text;
            }
            set
            {
                btnSave.Text = value;
            }
        }
        [Category("SK CommandButton Name")]
        [Description("공통 버튼 이름")]
        [Browsable(true)]
        [DefaultValue("삭 제")]
        public string DeleteName
        {
            get
            {
                return btnDelete.Text;
            }
            set
            {
                btnDelete.Text = value;
            }
        }
        [Category("SK CommandButton Name")]
        [Description("공통 버튼 이름")]
        [Browsable(true)]
        [DefaultValue("")]
        public string ExcelName
        {
            get
            {
                return btnExcel.Text;
            }
            set
            {
                btnExcel.Text = value;
            }
        }
        [Category("SK CommandButton Name")]
        [Description("공통 버튼 이름")]
        [Browsable(true)]
        [DefaultValue("")]
        public string PrintName
        {
            get
            {
                return btnPrint.Text;
            }
            set
            {
                btnPrint.Text = value;
            }
        }
        [Category("SK CommandButton Name")]
        [Description("공통 버튼 이름")]
        [Browsable(true)]
        [DefaultValue("")]
        public string NewName
        {
            get
            {
                return btnNew.Text;
            }
            set
            {
                btnNew.Text = value;
            }
        }

        [Category("SK Grid")]
        [Description(" Grid를 공통 아이콘에 설정 할것인가 여부")]
        [DefaultValue("")]
        [Browsable(true)]
        public bool BindingGrid
        {
            get;
            set;
        }
        [Category("SK Grid")]
        [Description(" 공통 아이콘에 설정 할 그리드 이름")]
        [Browsable(true)]
        public C1.Win.C1FlexGrid.C1FlexGrid BindingGridControl
        {
            get;
            set;
        }
        [Category("SK Grid")]
        [Description("그리드 삭제시 삭제 선택 컬럼")]
        [Browsable(true)]
        [DefaultValue(1)]
        public int DelCol
        {
            get;
            set;
        }


        [Browsable(true)]
        [Category("SK  CommonButton Event")]
        public event EventHandler OnSearchClick;
        [Browsable(true)]
        [Category("SK  CommonButton Event")]
        public event EventHandler OnSaveClick;
        [Browsable(true)]
        [Category("SK  CommonButton Event")]
        public event EventHandler OnDeleteClick;
        [Browsable(true)]
        [Category("SK  CommonButton Event")]
        public event EventHandler OnExcelClick;
        [Browsable(true)]
        [Category("SK  CommonButton Event")]
        public event EventHandler OnPrintClick;
        [Browsable(true)]
        [Category("SK  CommonButton Event")]
        public event EventHandler OnNewClick;
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            form = this.Parent as SKUserControlBase;
            OnClickSearch(sender, e);
            try
            {
                CommonManager.HistoryButton(form.FormInterface.GetCurrentUser().UserId, form.FormInterface.GetCurrentProgram().PgmId, "조회");

            }
            catch 
            {

                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            form = this.Parent as SKUserControlBase;
            OnClickSave(sender, e);
            try
            {
                CommonManager.HistoryButton(form.FormInterface.GetCurrentUser().UserId, form.FormInterface.GetCurrentProgram().PgmId, "저장");

            }
            catch 
            {

                
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            form = this.Parent as SKUserControlBase;
            OnClickDelete(sender, e);
            try
            {
                CommonManager.HistoryButton(form.FormInterface.GetCurrentUser().UserId, form.FormInterface.GetCurrentProgram().PgmId, "삭제");

            }
            catch 
            {

                
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            form = this.Parent as SKUserControlBase;
            if (this.BindingGrid == true && this.BindingGridControl != null)
            {
                C1.Win.C1FlexGrid.C1FlexGrid _fx = this.BindingGridControl as C1.Win.C1FlexGrid.C1FlexGrid;

                GridHelper.AddRow(_fx);
                //
            }
            else
            {
                OnClickNew(sender, e);
            }
            try
            {
                CommonManager.HistoryButton(form.FormInterface.GetCurrentUser().UserId, form.FormInterface.GetCurrentProgram().PgmId, "신규");

            }
            catch 
            {

                
            }

        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            form = this.Parent as SKUserControlBase;
            if (this.BindingGrid == true && this.BindingGridControl != null)
            {
                C1.Win.C1FlexGrid.C1FlexGrid _fx = this.BindingGridControl as C1.Win.C1FlexGrid.C1FlexGrid;

                GridHelper.PrintGrid(_fx);
                //
            }
            else
            {
                OnClickPrint(sender, e);
            }

            try
            {
                CommonManager.HistoryButton(form.FormInterface.GetCurrentUser().UserId, form.FormInterface.GetCurrentProgram().PgmId, "프린트");

            }
            catch 
            {

                
            }
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            form = this.Parent as SKUserControlBase;
            if (this.BindingGrid == true && this.BindingGridControl != null)
            {
                C1.Win.C1FlexGrid.C1FlexGrid _fx = this.BindingGridControl as C1.Win.C1FlexGrid.C1FlexGrid;

                GridHelper.ExportExcel(_fx);

            }
            else
            {
                OnClickExcel(sender, e);
            }
            try
            {
                CommonManager.HistoryButton(form.FormInterface.GetCurrentUser().UserId, form.FormInterface.GetCurrentProgram().PgmId, "엑셀");

            }
            catch 
            {

                
            }
        }

        public void OnClickSearch(object sender, EventArgs args)
        {

            if (OnSearchClick != null)
            {

                Invoke(OnSearchClick, null);

            }

        }
        public void OnClickSave(object sender, EventArgs args)
        {

            if (OnSaveClick != null)
            {

                Invoke(OnSaveClick, null);

            }

        }
        public void OnClickDelete(object sender, EventArgs args)
        {

            if (OnDeleteClick != null)
            {

                Invoke(OnDeleteClick, null);

            }

        }
        public void OnClickExcel(object sender, EventArgs args)
        {

            if (OnExcelClick != null)
            {

                Invoke(OnExcelClick, null);

            }

        }
        public void OnClickPrint(object sender, EventArgs args)
        {

            if (OnPrintClick != null)
            {

                Invoke(OnPrintClick, null);

            }

        }
        public void OnClickNew(object sender, EventArgs args)
        {

            if (OnNewClick != null)
            {

                Invoke(OnNewClick, null);

            }

        }

        private void CommonButton_Load(object sender, EventArgs e)
        {


            this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
              | System.Windows.Forms.AnchorStyles.Right)));

            btnSearch.Image = Properties.Resources.main_btn_up;
            btnNew.Image = Properties.Resources.main_btn_up;
            btnSave.Image = Properties.Resources.main_btn_up;
            btnDelete.Image = Properties.Resources.main_btn_up;
            btnExcel.Image = Properties.Resources.main_btn_up;
            btnPrint.Image = Properties.Resources.main_btn_up;

            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }




        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            ((C1.Win.C1Input.C1Button)sender).Image = Properties.Resources.main_btn_over;

        }

        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            ((C1.Win.C1Input.C1Button)sender).Image = Properties.Resources.main_btn_up;
        }
    }
}
