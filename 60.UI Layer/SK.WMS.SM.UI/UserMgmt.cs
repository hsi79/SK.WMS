using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;

using NEXCORE.Utility;
using NEXCORE.Utility.GlobalVariable;

namespace SK.WMS.SM.UI
{
    public partial class UserMgmt : SKUserControlBase
    {
        DataRow dr = null;

        public UserMgmt()
        {
            InitializeComponent();

        }

        private void UserMgmt_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
        }
        public override void InitControls()
        {
            
            

            if (!btnInit.Enabled) btnInit.Image = NEXCORE.Common.Properties.Resources.main_btn_disable;
        }





        public override void InitializeGrid()
        {


            GridHelper.DefaultGrid(fxUserList,true);
            GridHelper.InitColumn(fxUserList, "UserId", "사용자 ID", 80);
            GridHelper.InitColumn(fxUserList, "UserName", "사용자 명", 80);

            
            GridHelper.InitColumn(fxUserList, "Tel", "전화번호", 100);
            GridHelper.InitColumn(fxUserList, "Mobile", "휴대폰", 100);
            GridHelper.InitColumn(fxUserList, "Email", "이메일", 100);
            GridHelper.InitColumn(fxUserList, "LoginId", "", 80,false,false);
            GridHelper.InitColumn(fxUserList, "IsLock", "사용금지", 60);
            //GridHelper.InitColumn(fxUserList, "DeptCd", "부서", 100,false,false);
            //GridHelper.InitColumnButton(fxUserList, "Mobile", "", 20, evt);
            GridHelper.InitColumn(fxUserList, "USER_BAN", "반", 80, false, false);


        }
        public override void InitializeLocalization()
        {
            
        }


        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
          
          try
          {

              
              User[] user = CommonManager.GetUsers(searchUserNm.Text);
              DataSet ds = UtilityHelper.ToDataSet(user);
              GridHelper.DataBind(fxUserList, ds);
              string[] key = { "UserId", "UserName" };
              GridHelper.SelectGridRow(fxUserList, dr, key);
              FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
              skCtitleLabel3.Text = "조회 건수 : " + (fxUserList.Rows.Count - 1).ToString();

          }
          catch (Exception ex)
          {
              CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

          }
        }

        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            if (!CheckValue()) return;
            if (MessageBox.Show(CommonManager.GetMessage("M10005"), "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            try
            {


                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("USER_ID", txtUserID.Text);
                data.Hashtable.Add("PASSWORD", UtilityHelper.Encrypt(txtUserID.Text));
                data.Hashtable.Add("USER_NM", txtUserNm.Text);
                data.Hashtable.Add("EMAIL", txtEmail.Text);
                data.Hashtable.Add("TEL_WORK", txtTel.Text);
                data.Hashtable.Add("TEL_MOBILE", txtMobile.Text);
                
                data.Hashtable.Add("USE_YN", chkLock.Checked ? "N" : "Y");
                data.Hashtable.Add("REG_ID", FormInterface.GetCurrentUser().LoginId);


                CommonManager.DeleteUser(data);
                CommonManager.ReloadMenu();
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10002"));            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10004"), "", "1", ex.Message);
            }


        }

        private void commonButton1_OnNewClick(object sender, EventArgs e)
        {
            txtUserID.Enabled = true;

            txtUserID.Text = "";
            txtUserNm.Text = "";
            chkLock.Checked = false;
            
            txtEmail.Text = "";
            txtTel.Text = "";

        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {

            try
            {
                if (!CheckValue()) return;
                 dr = GridHelper.SaveGridRow(fxUserList);
                
                NEXCOREData data = new NEXCOREData();

                data.Hashtable.Add("USER_ID", txtUserID.Text);
                data.Hashtable.Add("PASSWORD", UtilityHelper.Encrypt(txtUserID.Text));
                data.Hashtable.Add("USER_NM", txtUserNm.Text);
                data.Hashtable.Add("EMAIL", txtEmail.Text);
                data.Hashtable.Add("TEL_WORK", txtTel.Text);
                data.Hashtable.Add("TEL_MOBILE", txtMobile.Text);
                



                data.Hashtable.Add("USE_YN", chkLock.Checked ? "Y" : "N");
                data.Hashtable.Add("REG_ID", FormInterface.GetCurrentUser().LoginId);

                if (txtUserID.Enabled)
                {
                    if (!CheckDup(txtUserID.Text)) return;
                        CommonManager.AddUser(data);
                }
                else
                {
                    CommonManager.UpdateUser(data);
                }

                txtUserID.Enabled = false;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {

                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }


        }



        private void RowColchange()
        {


            int current = (fxUserList.Row > 0) ? fxUserList.Rows[fxUserList.Row].DataIndex : -1;

            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;

            txtUserID.Text = GridHelper.GetText(fxUserList, current, "UserId");
            txtUserNm.Text = GridHelper.GetText(fxUserList, current, "UserName");

            txtTel.Text = GridHelper.GetText(fxUserList, current, "Tel");
            txtMobile.Text = GridHelper.GetText(fxUserList, current, "Mobile");
            txtEmail.Text = GridHelper.GetText(fxUserList, current, "Email");




            chkLock.Checked = GridHelper.GetText(fxUserList, current, "IsLock") == "Y" ? true : false;
            txtLoginId.Text = GridHelper.GetText(fxUserList, current, "LoginId");

            txtUserID.Enabled = false;






            //GridHelper.SetButtonImage(fxUserList, current,GridHelper.ButtonImage.glasses , 14);

        }
        private void fxUserList_RowColChange(object sender, EventArgs e)
        {
            RowColchange();

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
          string msg = null;

          if (!CheckValue()) return;
          if (DialogResult.Yes == MessageBox.Show(this, "선택한 사용자의 비밀번호를 초기화 하시겠습니까 ?","비밀번호 초기화",  MessageBoxButtons.YesNo))
          {

              if (txtUserID.Enabled)
              {
                  msg = "비밀번호를 초기화 할 사용자를 선택하십시요.";
                  MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
                  return;
              }
              bool ret = CommonManager.ChangePassword(txtUserID.Text.Trim(), NEXCORE.Utility.UtilityHelper.Encrypt(txtUserID.Text.Trim()));

              if (ret)
              {
                  msg = "비밀번호가 초기화 되었습니다.";
                  MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
              }
              else
              {
                  msg = "비밀번호 초기화중 오류가 발생하였습니다..";
                  MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);

              }
          }
        }

        #region Validation Check
        /// <summary>
        /// 프로그램ID 중복 체크
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckDup(string value)
        {
            bool returnValue = true;

            try
            {
                if (CommonManager.DupCheck("USER", value) > 0)
                {
                    MessageBox.Show(this, string.Format(CommonManager.GetMessage("M10008"), value), "오류", MessageBoxButtons.OK); //메세지 등록
                    returnValue = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                returnValue = false;
            }

            return returnValue;
        }
        /// <summary>
        /// 입력값 체크
        /// </summary>
        /// <returns></returns>
        private bool CheckValue()
        {
            bool returnValue = true;

            try
            {
                //필수 입력값 체크 (공통모듈)
                if (!CheckMandatoryField())
                {
                    returnValue = false;
                }
                //if (txtUserID.Text.Trim().Length == 0)
                //{
                //    txtUserID.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "사용자 ID");
                //    returnValue = false;
                //}
                //else
                //{
                //    txtUserID.ErrorText = string.Empty;
                //    returnValue = true;
                //}
                //if (txtUserNm.Text.Trim().Length == 0)
                //{
                //    txtUserNm.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "사용자 명");
                //    returnValue = false;
                //}
                //else
                //{
                //    txtUserNm.ErrorText = string.Empty;
                //    returnValue = true;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                returnValue = false;
            }

            return returnValue;
        }
        #endregion

        private void btnDept_Click(object sender, EventArgs e)
        {
            ZZ007 form = new ZZ007();

            if (DialogResult.OK == form.ShowDialog())
            {
                //txtDeptNm.Text = form.deptName;
                //txtDeptCd.Text = form.deptId;

            }
        }

        private void btnInit_MouseHover(object sender, EventArgs e)
        {
            ((C1.Win.C1Input.C1Button)sender).Image = NEXCORE.Common.Properties.Resources.main_btn_over;
        }

        private void btnInit_MouseLeave(object sender, EventArgs e)
        {
            ((C1.Win.C1Input.C1Button)sender).Image = NEXCORE.Common.Properties.Resources.main_btn_up;
        }

        
    }
}
