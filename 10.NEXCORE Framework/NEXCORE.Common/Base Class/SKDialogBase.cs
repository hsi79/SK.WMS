using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

namespace NEXCORE.Common
{
    public partial class SKDialogBase : Form
    {
        public SKDialogBase()
        {
            InitializeComponent();

            FormInterface = NEXCORE.Common.UIInterface.GetUIInterface();
            //this.Load += new EventHandler(SKDialogBase_Load);
        }

        public NEXCOREData Data { get; set; }

        #region Member Property
        private IUserInterface _UIInterface;
        public bool CheckAuthority = false;
        private bool HadLoaded = false;


        private Program _ThisProgram;
        
        public Program ThisProgram
        {
            get
            {
                return _ThisProgram;
            }
            set
            {
                _ThisProgram = value;
            }
        }
        public IUserInterface FormInterface
        {
            get
            {
                return this._UIInterface;
            }
            set
            {
                this._UIInterface = value;
            }
        }

        #endregion
        
        public void Initilize()
        {
            AddEvent();
        }

        #region 추상 메소드


        public virtual void finalize()
        {
        }

        public virtual void InitControls()
        {

        }

        public virtual void InitilizeGrid()
        {
        }
        public virtual void InitilizeLocalization()
        {

        }
        #endregion

        #region Event Property

        [Category("SK Form Event")]
        public event BroadCast OnBroadCast;

        [Category("SK Form Event")]
        public event ReceiveMessage OnReceiveMessage;

     
        #endregion

        #region Event Method
        private void AddEvent()
        {
            Delegate tempDel = null;

            try
            {
                tempDel = new BroadCast(parentForm_OnBroadCast);
            }
            catch { }

            if (tempDel == null)
                return;

            if (this.ThisProgram == null)
                return;

            FormInterface.AddChildFormEvent(this.ThisProgram.PgmId, new ReceiveMessage(OnReceiveMessage_Handler));
            FormInterface.AddBroadCastEvent((BroadCast)tempDel);
        }

        private void RemoveEvent()
        {
            //if (this.MdiParent is SKCWPFMDIBase)
            //{
            //    SKCWPFMDIBase parentForm = this.MdiParent as SKCWPFMDIBase;

            //    parentForm.OnBroadCast -= new BroadCast(parentForm_OnBroadCast);
            //}
        }

        #endregion

        #region Form Load Event
        void SKDialogBase_Load(object sender, EventArgs e)
        {
            if (this.HadLoaded)
                return;

            this.HadLoaded = true;

            //버튼 관련 권한 체크여부
            if (CheckAuthority == true)
                SetAuthority();


            Initilize();
            InitilizeGrid();
            InitilizeLocalization();
            InitControls();
        }

        #endregion

        #region SK Event Handler
        private void OnReceiveMessage_Handler(object sender, NEXCORE.Common.Data.NEXCOREData e)
        {
            if (this.OnReceiveMessage != null)
            {
                OnReceiveMessage(sender, e);
            }
        }
        private void parentForm_OnBroadCast(object sender, BroadCastEventArgs e)
        {
            if (this.OnBroadCast != null)
            {
                OnBroadCast(sender, e);
            }
        }

        #endregion

        #region 권한 설정
        private void SetAuthority()
        {
            //TODO:버튼 권한 관련 로직
            if (this.FormInterface == null)
            {
                return;
            }

            User user = this.FormInterface.GetCurrentUser();
            List<ButtonAuthority> authBtnList = CommonManager.GetButtonAuthority(user.AuthId, ThisProgram.PgmId);

            if (authBtnList.Count <= 0)
            {
                return;
            }

            foreach (Control control in this.Controls)
            {
                SetButtonAuthority(control, authBtnList);
            }
        }

        private void SetButtonAuthority(Control control, List<ButtonAuthority> authBtnList)
        {
            try
            {
                //#region  Code

                //if (!string.IsNullOrEmpty(control.Name))
                //{


                //    ButtonAuthority btnAuth = null;

                //    foreach (ButtonAuthority ba in authBtnList)
                //    {
                //        if (ba.BtnId == control.Name)
                //        {
                //            btnAuth = ba;
                //            break;
                //        }

                //    }


                //    if (btnAuth != null)
                //    {

                //        if (btnAuth.VisibleYN == "Y")
                //            control.Visible = true;
                //        else
                //            control.Visible = false;

                //        if (btnAuth.EnableYN == "Y")
                //            control.Enabled = true;
                //        else
                //            control.Enabled = false;

                //    }
                //    //}
                //}

                //#endregion

                //foreach (Control ctrlChild in control.Controls)
                //{
                //    SetButtonAuthority(ctrlChild, authBtnList);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

    }
}
