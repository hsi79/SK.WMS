using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using System.ComponentModel;
using System.Drawing;
using NEXCORE.Utility.GlobalVariable;
using System.Reflection;

namespace NEXCORE.Common
{
    [ToolboxItem(false)]
    public class SKUserControlBase : UserControl, ISKBase
    {
        #region Member Property
        private IUserInterface _UIInterface;
        public bool CheckAuthority = true;
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

        public SKUserControlBase()
        {
            FormInterface = NEXCORE.Common.UIInterface.GetUIInterface();
            this.Load += new EventHandler(SKUserControlBase_Load);

        }

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

        public virtual void InitializeGrid()
        {
        }

        public virtual void InitializeLocalization()
        {
        }
        public virtual void SearchMethod()
        {
        }
        public virtual void DbClickMethod()
        {
        }
        #endregion

        #region Event Property



        [Browsable(true)]
        [Category("SK Form Event")]
        public event FormClose OnFormClose;


        
        [Category("SK Form Event")]
        public event ReceiveMessage OnReceiveMessage;




        #endregion

        #region Event Method
        private void AddEvent()
        {
            Delegate tempDel = null;

            try
            {
                //tempDel = new BroadCast(parentForm_OnBroadCast);
            }
            catch { }

            if (tempDel == null)
                return;
            
            if (this.ThisProgram == null)
                return;

            FormInterface.AddChildFormEvent(this.ThisProgram.PgmId, new ReceiveMessage(OnReceiveMessage_Handler));
            //FormInterface.AddBroadCastEvent((BroadCast)tempDel);
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

        #region Event 발생

        public void FireOnClose(object sender, ref NEXCOREData param)
        {
            if (this.OnFormClose != null)
            {
                OnFormClose(sender, param);
            }
        }

        #endregion

        #region Form Load Event
        void SKUserControlBase_Load(object sender, EventArgs e)
        {
            try
            {


            if (this.HadLoaded)
                return;

            this.HadLoaded = true;

            if (CheckAuthority == true)
                SetAuthority();

            SetFont();
            //Control 초기화
            Initilize();
            InitializeGrid();
            InitializeLocalization();
            InitControls();
            RegisterSKControls();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                CommonHelper.CallMsgPopUp("알림", CommonManager.GetMessage("M10011"), "", "1", msg);
            }
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

        #endregion
        #region 폰트 설정
        private void SetFont()
        {
            //TODO:권한 관련 로직을 WindowsForm에 맞도록 수정

            if (this.FormInterface == null)
            {
                return;
            }




            foreach (Control control in this.Controls)
            {
                SetFontControl(control);
            }


        }

        private void SetFontControl(Control control)
        {
            try
            {
                //#region  Code
                 
                if (!string.IsNullOrEmpty(control.Name))
                {
                    Font ft = control.Font;
                    string font = WMSVar.FT;
                    float s = ft.Size;
                    if (!(control  is  UserControl))
                    {
                        if (ft.Bold)
                        {
                            control.Font = new Font(font, s, FontStyle.Bold);
                        }
                        else
                        {
                            control.Font = new Font(font, s);
                        }

                    }
                    if (control is UserControl)
                    {
                        if (control.GetType().Name == "GridTitleButton")
                        {
                            control.BackColor = WMSVar.Backcol;
                            control.ForeColor = WMSVar.Forecol;
                            foreach (Label c in control.Controls)
                            {
                                if (c.GetType().Name == "Label")
                                {
                                    c.BackColor = WMSVar.Backcol;
                                    c.ForeColor = WMSVar.Forecol;
                                }



                            }
                        }


                    }
                    if (  control is C1.Win.C1InputPanel.C1InputPanel )
                    {
                        C1.Win.C1InputPanel.C1InputPanel cc = (C1.Win.C1InputPanel.C1InputPanel)control;
                        foreach (C1.Win.C1InputPanel.InputComponent c in cc.Items)
                        {
                            if (c.GetType().Name == "InputGroupHeader")
                            {
                                C1.Win.C1InputPanel.InputGroupHeader g = (C1.Win.C1InputPanel.InputGroupHeader)c;
                                g.BackColor = WMSVar.Backcol;
                                g.ForeColor = WMSVar.Forecol;
                            }
                                


                        }
                    }
                    
                    foreach (Control ctrlChild in control.Controls)
                    {
                        SetFontControl(ctrlChild);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
       
        }

        #endregion
        #region 권한 설정
        private void SetAuthority()
        {
            //TODO:권한 관련 로직을 WindowsForm에 맞도록 수정

            if (this.FormInterface == null)
            {
                return;
            }

            //User user = this.FormInterface.GetCurrentUser();
            //List<ButtonAuthority> authBtnList = CommonManager.GetButtonAuthority(user.UserId, ThisProgram.PgmId);
            //List<AuthorityButton> authExtBtnList = CommonManager.GetUserButtonList(user.UserId, ThisProgram.PgmId);
            //if (authBtnList.Count <= 0)
            //{
            //    return;
            //}



            //foreach (Control control in this.Controls)
            //{
            //    if (control.Enabled)
            //    SetButtonAuthority(control, authBtnList);
            //}


            //if (authExtBtnList.Count <= 0)
            //{
            //    return;
            //}

            //foreach (Control control in this.Controls)
            //{
            //    if (control.Enabled)
            //        SetExtButtonAuthority(control, authExtBtnList);
            //}
        }

        private void SetButtonAuthority(Control control, List<ButtonAuthority> authBtnList)
        {
            try
            {
                //#region  Code

                if (!string.IsNullOrEmpty(control.Name))
                {



                    foreach (ButtonAuthority ba in authBtnList)
                    {
                        if (control.Tag == null) break;
                        if (!control.Enabled)
                        {
                            control.BackgroundImage = Properties.Resources.main_btn_disable;
                            break;
                        }
                        switch (control.Tag.ToString())
                        {
                            case "S" :
                                if (ba.C == "Y")
                                {
                                    control.Enabled = true;
                                }
                                else
                                {
                                    control.Enabled = false;
                                    control.BackgroundImage = Properties.Resources.main_btn_disable;
                                }
                                break;
                            case "R":
                                if (ba.R == "Y")
                                {
                                    control.Enabled = true;
                                }
                                else
                                {
                                    control.Enabled = false;
                                    control.BackgroundImage = Properties.Resources.main_btn_disable;
                                }
                                break;
                            case "D":
                                if (ba.D == "Y")
                                {
                                    control.Enabled = true;
                                }
                                else
                                {
                                    control.Enabled = false;
                                    control.BackgroundImage = Properties.Resources.main_btn_disable;
                                }
                                break;
                            case "P":
                                if (ba.P == "Y")
                                {
                                    control.Enabled = true;
                                }
                                else
                                {
                                    control.Enabled = false;
                                    control.BackgroundImage = Properties.Resources.main_btn_disable;
                                }
                                break;
                            case "E":
                                if (ba.E == "Y")
                                {
                                    control.Enabled = true;
                                }
                                else
                                {
                                    control.Enabled = false;
                                    control.BackgroundImage = Properties.Resources.main_btn_disable;
                                }
                                break;
                            default:
                                    control.Enabled = false;
                                    control.BackgroundImage = Properties.Resources.main_btn_disable;
                                break;
                        }
                    }

                }
               
                //#endregion

                foreach (Control ctrlChild in control.Controls)
                {
                    SetButtonAuthority(ctrlChild, authBtnList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SetExtButtonAuthority(Control control, List<AuthorityButton> authExtBtnList)
        {
            try
            {
                //#region  Code
                bool enable = false;
                if (!string.IsNullOrEmpty(control.Name))
                {



                    foreach (AuthorityButton ba in authExtBtnList)
                    {

                        if (ba.ButtonId == control.Name)
                        {
                            if (ba.AuthYN == "Y" ) enable = true;

                            control.Enabled = enable;

                            if (!control.Enabled) control.BackgroundImage = Properties.Resources.main_btn_disable;
                        }
                    }

                }

                //#endregion

                foreach (Control ctrlChild in control.Controls)
                {
                    SetExtButtonAuthority(ctrlChild, authExtBtnList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SKUserControlBase
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "SKUserControlBase";
            this.Size = new System.Drawing.Size(760, 683);
            this.ResumeLayout(false);

        }


        
        #region 내부 Function

        public void RegisterSKControls()
        {
            foreach (Control c in this.Controls)
            {
                AddControlEvent(c);
            }
        }

        public void AddControlEvent(Control pControl)
        {
            if (pControl.GetType().Name.Contains("SK"))
            {
                // SK Control
                FormInterface.AddChildControlEventHandler(this.ThisProgram.PgmId, pControl);
            }

            foreach (Control c in pControl.Controls)
            {
                AddControlEvent(c);
            }
        }

        public void RemoveControlEvent(Control pControl)
        {
            foreach (Control c in pControl.Controls)
            {
                AddControlEvent(c);

                if (c is ISKControls)
                {
                    // SK Control
                    //FormInterface.RemoveChildControlEventHandler(this.ThisProgram.PgmId, c);
                }
            }
        }

        #endregion

        protected bool CheckMandatoryField()
        {
            Dictionary<System.Windows.Forms.Control, string> controlList = FormInterface.GetMandatoryControls(this.ThisProgram.PgmId);
            string strInvalidControl = string.Empty;

            foreach (System.Windows.Forms.Control control in controlList.Keys)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    string labelname = GetLabelName(control.Name);
                    if (control.GetType().Name == "SKComboBox")
                        ((C1.Win.C1List.C1Combo)control).EditorBackColor = Color.Red;

                    else
                        control.BackColor = Color.Red;

                    if (string.IsNullOrEmpty(strInvalidControl))
                        //strInvalidControl += controlList[control];
                        strInvalidControl += labelname;
                    else
                        //strInvalidControl += Environment.NewLine + controlList[control];
                        strInvalidControl += Environment.NewLine + labelname;
                }




            }

            string uiMsg = CommonManager.GetMessage("M10009");
            //string uiMsg = "{0} " + Environment.NewLine + "는필수 입력 필드입니다.";
            if (string.IsNullOrEmpty(strInvalidControl) == false)
            {
                MessageBox.Show(string.Format(uiMsg, " ( " + strInvalidControl + " ) "), "Information");
                //CommonHelper.CallMsgPopUp("Information", string.Format(uiMsg, " ( " + strInvalidControl + " ) "), "", "1", "");
                return false;
            }

            return true;
        }
        private string GetLabelName(string control)
        {
            string ret = string.Empty;
            foreach (Control controls in this.Controls)
            {
                    ret = GetChildLableName(control, controls);
                    if (string.IsNullOrEmpty(ret) == false)
                    {
                        return ret;
                    }
            }
            return ret;
        }

        private string GetChildLableName(string control,Control controls)
        {
            string ret = string.Empty;
            int len = 0;
            if (controls.GetType().Name == "SKLabel")
            {
                len = control.ToUpper().Substring(3).Length;
                if (control.ToUpper().Substring(3) == controls.Name.ToUpper().Substring(controls.Name.Length - len))
                {
                    Type t = controls.GetType();
                    PropertyInfo pInfoText = t.GetProperty("Text");

                    ret = (string)pInfoText.GetValue(controls, null);
                    
                    return ret;
                }

            }
            foreach (Control ctrlChild in controls.Controls)
            {
                ret = GetChildLableName(control, ctrlChild);
                if (string.IsNullOrEmpty(ret) == false)
                {
                    return ret;
                }
            }
            return ret;
        }


        #region WMS SKUserControlBase's Memeber

        /// <summary>
        /// UserControl 기본 세팅1
        /// </summary>
        /// <param name="uc"></param>
        public static void SetDefault(UserControl uc)
        {
            uc.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            uc.Width = Skcc.Configuration.SkccFxConfigManager.GetInt32("ucWidth1");
            uc.Height = Skcc.Configuration.SkccFxConfigManager.GetInt32("ucHeight1");

        }

        #endregion
    }
}
