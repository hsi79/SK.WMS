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
using System.Collections;

namespace SK.WMS.WinControls
{
    public partial class productWindow : UserControl
    {
        public productWindow()
        {
            InitializeComponent();


        }
        [Category("SK helpWindow")]
        [Description("텍스트 Display값")]
        [Browsable(true)]
        [DefaultValue("")]
        public string helpDisplay
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }
        [Category("SK helpWindow")]
        [Description("텍스트 Value 값")]
        [Browsable(true)]
        [DefaultValue("")]
        public string helpValue
        {
            get
            {
                return txtValue.Text;
            }
            set
            {
                txtValue.Text = value;
            }
        }
        [Category("SK helpWindow")]
        [Description("조회 패키지 명")]
        [DefaultValue("")]
        [Browsable(true)]
        public string PakageName
        {
            get;
            set;
        }
        [Category("SK helpWindow")]
        [Description("조회 HashTable")]
        [DefaultValue("")]
        [Browsable(true)]
        public string InParam
        {
            get;
            set;
        }
        [Category("SK helpWindow")]
        [Description("조회 DisplayName")]
        [DefaultValue("")]
        [Browsable(true)]
        public string DisplayName
        {
            get;
            set;
        }
        [Category("SK helpWindow")]
        [Description("조회 ValueName")]
        [DefaultValue("")]
        [Browsable(true)]
        public string ValueName
        {
            get;
            set;
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            helpForm frm = new helpForm();
            frm.GetTextEvent += new helpForm.ChildEventHandler(frm_GetText);

            if (PakageName.Equals(""))
            {
                CommonHelper.CallMsgPopUp("오류", "패키지,프로시져 명이 없습니다.", "", "1", "패키지,프로시져명을 속성 PakageName 에 지정하세요. ");
                return;
            }
            if (DisplayName.Equals(""))
            {
                CommonHelper.CallMsgPopUp("오류", "Display 명이 없습니다.", "", "1", "Display 속성 DisplayName 에 컬럼명을 지정하세요");
                return;
            }
            if (ValueName.Equals(""))
            {
                CommonHelper.CallMsgPopUp("오류", "Value 명이 없습니다.", "", "1", "Value 속성 ValueName 에 컬럼명을 지정하세요");
                return;
            } 
            frm.pakageName = PakageName;
            frm.inParm = InParam;
            frm.displayName = DisplayName;
            frm.valueName = ValueName;
            frm.ShowDialog();

        }

        void frm_GetText(string str)
        {
            string[] strs = str.Split(',');
            this.txtName.Text = strs[0];
            this.txtValue.Text = strs[1];
        }

        private void CommonButton_Load(object sender, EventArgs e)
        {


             this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

    }
}
