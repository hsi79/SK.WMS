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
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Utility;


namespace SK.WMS.SM.UI
{
    public partial class MsgMgmt : SKUserControlBase
    {
 
        public MsgMgmt()
        {
            InitializeComponent();

        }

        private void MsgMgmt_Load(object sender, EventArgs e)
        {

        }

        public override void InitControls()
        {
            base.InitControls();
        }

        public override void InitializeGrid()
        {
            base.InitializeGrid();
        }

        public override void InitializeLocalization()
        {
            base.InitializeLocalization();

            GridHelper.DefaultGrid(fxMessage,  false);
            GridHelper.InitColumn(fxMessage, "MessageId", "메세지", 100);
            GridHelper.InitColumn(fxMessage, "MessageKO", "메세지 내용", 500);
        }
 
        #region 조회/저장/삭제





        #region 그리드 이벤트



        private void RowColchange()
        {

            // get current row's DataIndex (skip nodes and fixed rows)
            int current = (fxMessage.Row > 0) ? fxMessage.Rows[fxMessage.Row].DataIndex : -1;

            // not a data row?
            if (current < 0)
            {

                return;
            }
            current = current + 1;
            txtMessageID.Text = GridHelper.GetText(fxMessage, current, 1);
            txtMessageKo.Text = GridHelper.GetText(fxMessage, current, "MessageKO");

            txtMessageID.Enabled = false;

        }
        private void fxMessage_RowColChange(object sender, EventArgs e)
        {
            RowColchange();
        }

        #endregion

       

        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                if (MessageBox.Show(CommonManager.GetMessage("M10005"), "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
                CommonManager.DeleteMessage(txtMessageID.Text);
                CommonManager.ReloadMessage();
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10002"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10004"), "", "1", ex.Message);
            }
            finally
            {

            }
        }

        private void commonButton1_OnExcelClick(object sender, EventArgs e)
        {

        }

        private void commonButton1_OnNewClick(object sender, EventArgs e)
        {
            txtMessageID.Enabled = true;
            txtMessageID.Text = "";
            txtMessageKo.Text = "";
        }

        private void commonButton1_OnPrintClick(object sender, EventArgs e)
        {

        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;

                if (txtMessageID.Enabled)
                {
                    if (!CheckDup(txtMessageID.Text)) return;
                    CommonManager.AddMessage(txtMessageID.Text, txtMessageKo.Text);
                }
                else
                {
                    CommonManager.UpdateMessage(txtMessageID.Text, txtMessageKo.Text);
                }

                CommonManager.ReloadMessage();
                txtMessageID.Enabled = false;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }

        }

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {
            try
            {


              GridHelper.DataBind(  fxMessage,UtilityHelper.ToDataSet(CommonManager.GetMessageList(searchMessage.Text, searchMessageNm.Text)));
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
            
        }

        public override void SearchMethod()
        {
            try
            {

                fxMessage.DataSource = CommonManager.GetMessageList(searchMessage.Text, searchMessageNm.Text);
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10007"));
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10006"), "", "1", ex.Message);

            }
        }
        public override void DbClickMethod()
        {
           
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
                if (CommonManager.DupCheck("MSG", value) > 0)
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
                if (txtMessageID.Text.Trim().Length == 0)
                {
                    txtMessageID.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "메세지 ID");
                    returnValue = false;
                }
                else
                {
                    txtMessageID.ErrorText = string.Empty;
                    returnValue = true;
                }
                if (txtMessageKo.Text.Trim().Length == 0)
                {
                    txtMessageKo.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "메세지 명");
                    returnValue = false;
                }
                else
                {
                    txtMessageKo.ErrorText = string.Empty;
                    returnValue = true;
                }
                

            }
            catch (Exception ex)
            {
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                CommonHelper.CallMsgPopUp("알림", "화면 로드중 오류가 발생하였습니다!!!", "", "1", msg); 
                returnValue = false;
            }

            return returnValue;
        }
        #endregion

        private void fxMessage_AfterDataRefresh(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(fxMessage.Rows.Count.ToString());
        }
        #endregion

    }
}
