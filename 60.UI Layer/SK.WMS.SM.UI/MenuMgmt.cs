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

using System.Drawing.Drawing2D;
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Utility;



namespace SK.WMS.SM.UI
{
    public partial class MenuMgmt : SKUserControlBase
    {
         DataTable mgmtData;

        public MenuMgmt()
        {
            InitializeComponent();
            
        }

        private void MenuMgmt_Load(object sender, EventArgs e)
        {
            BindData();
            setTree();
        
        }


        public override void InitializeGrid()
        {

        }
        public override void InitControls()
        {
            //CommonHelper.BindingComboBox(ref cmbModule, "Module");
            //ComboBinding_cmbModule();

            List<Program> programList = CommonManager.GetProgramList();
            Program item = new Program();
            item.PgmId = "";
            item.PgmName = "선택";
            programList.Insert(0, item);
            cmbProgram.MismatchValueErrorText = "선택한 '{0}' 프로그램이 아닙니다.";
            cmbProgram.DisplayMember = "PgmName";
            cmbProgram.ValueMember = "PgmId";

            cmbProgram.DataSource = programList;

            cmbProgram.SelectedValue = "";

        }
        public override void InitializeLocalization()
        {
            
        }


        #region 조회/저장/삭제



        /// <summary>
        /// 메뉴 바인딩 
        /// </summary>
        private void BindData()
        {
            //if (cmbModule.SelectedValue == null) return;
            mgmtData = null;
            DataSet mgmtDataSet = null;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                mgmtDataSet = UtilityHelper.ToDataSet( CommonManager.GetAllMenu( ""));

                mgmtData = mgmtDataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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
                if (CommonManager.DupCheck("MENU", value) > 0)
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
        /// 상위 메뉴 체크
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckUpMenu(string value)
        {
            bool returnValue = true;

            try
            {
                if (CommonManager.DupCheck("MENU", value) > 0)
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
            //menu.MenuId = txtMenu.Text;
            //menu.MenuKorea = txtMenuKor.Text;
            //menu.SysId = cmbModule.SelectedValue.ToString();
            //menu.SORT = txtOrder.Text;
            //menu.Use = chkUse.Checked ? "Y" : "N";
            //menu.PgmId = txtProgram.Text;
            //menu.ParentMenuId = txtUpMenu.Text;
            //menu.SearchMenu = chkSearchMenu.Checked ? "Y" : "N";
            //menu.SearchMenuName = txtSearchName.Text;
            try
            {
                if (txtMenu.Text.Trim().Length == 0)
                {
                    txtMenu.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "메뉴 ID");
                    returnValue = false;
                }
                else
                {
                    txtMenu.ErrorText = string.Empty;
                    returnValue = true;
                }

                if (txtMenuKor.Text.Trim().Length == 0)
                {
                    txtMenuKor.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "메뉴 명");
                    returnValue = false;
                }
                else
                {
                    txtMenuKor.ErrorText = string.Empty;
                    returnValue = true;
                }

                if (txtUpMenu.Text.Trim().Length == 0)
                {
                    txtUpMenu.ErrorText = string.Format(CommonManager.GetMessage("M10009"), "상위 메뉴명");
                    returnValue = false;
                }
                else
                {
                    txtUpMenu.ErrorText = string.Empty;
                    returnValue = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                returnValue = false;
            }

            return returnValue;
        }
        #endregion

        #endregion

        private void commonButton1_OnSearchClick(object sender, EventArgs e)
        {


            BindData();
            setTree();
        }

        private void setTree()
        {
            CompositeMenu();
            txtMenu.Enabled = false;
            tvMenu.ExpandAll();
        }
        private void getTreeMenu(string menu)
        {

            if (mgmtData != null)
            {
                string query = "MenuId = '" + menu + "'";
                DataRow[] drTopMenu = mgmtData.Select(query, "SORT");
            

            txtMenu.Text = drTopMenu[0]["MenuId"].ToString();
            if (drTopMenu[0]["PgmId"].ToString() == "")
            {
                cmbProgram.Text = "";
                cmbProgram.SelectedValue = "";
            }
            else
            {
                cmbProgram.SelectedValue = drTopMenu[0]["PgmId"].ToString();
            }
            txtMenuEng.Text = drTopMenu[0]["MenuEnglish"].ToString();
            txtMenuKor.Text = drTopMenu[0]["MenuKorea"].ToString();
            txtUpMenuId.Text = drTopMenu[0]["ParentMenuId"].ToString();
            txtUpMenu.Text = drTopMenu[0]["ParentMenuName"].ToString();
            txtOrder.Text = drTopMenu[0]["SORT"].ToString();
            chkUse.Checked = drTopMenu[0]["Use"].ToString() == "Y" ? true : false;

            }

            txtMenu.Enabled = false;
        }

        /// <summary>
        /// 동적으로 Menu를 구성합니다.
        /// </summary>
        public void CompositeMenu()
        {
            tvMenu.Nodes.Clear();

            if (mgmtData != null)
            {
                string query = "ParentMenuId = 'ROOT'";
                DataRow[] drTopMenu = mgmtData.Select(query, "SORT");

                for (int rowIdx = 0; rowIdx < drTopMenu.Length; rowIdx++)
                {
                    TreeNode parentNode = new TreeNode();
                    parentNode.Text = drTopMenu[rowIdx]["MenuKorea"].ToString() + "( " + drTopMenu[rowIdx]["MenuId"].ToString() + " )";
                    parentNode.Tag = drTopMenu[rowIdx]["MenuId"].ToString();
                    parentNode.ToolTipText = drTopMenu[rowIdx]["MenuId"].ToString();
                    SelfCompositMenu(parentNode, drTopMenu[rowIdx]["MenuId"].ToString());
                    tvMenu.Nodes.Add(parentNode);


                }

            }
        }

        /// <summary>
        /// 재귀호출을 통해 하위 Menu를 생성하고 Menu 정보를 Tag에 저장합니다.
        /// </summary>
        /// <param name="pmenuItem">상위 Menu Item</param>
        /// <param name="topMenuCode">상위 Menu Code</param>
        private void SelfCompositMenu(TreeNode parentNode, string topMenuCode)
        {
            string query = string.Format("ParentMenuId = '{0}'", topMenuCode);
            DataRow[] drMenuItem = mgmtData.Select(query, "SORT");

            if (drMenuItem.Length > 0)
            {
                for (int rowIdx = 0; rowIdx < drMenuItem.Length; rowIdx++)
                {
                    TreeNode curNode = new TreeNode();
                    curNode.Text = drMenuItem[rowIdx]["MenuKorea"].ToString() + "( " + drMenuItem[rowIdx]["MenuId"].ToString() + " )";
                    curNode.Tag = drMenuItem[rowIdx]["MenuId"].ToString();
                    curNode.ToolTipText = drMenuItem[rowIdx]["MenuId"].ToString();
                    parentNode.Nodes.Add(curNode);

                    // 재귀호출
                    SelfCompositMenu(curNode, drMenuItem[rowIdx]["MenuId"].ToString());
                }

            }
        }


        private void TrMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            getTreeMenu(tvMenu.SelectedNode.Tag.ToString());
        }



        private void txtUpMenu_Leave(object sender, EventArgs e)
        {
            //if (!txtUpMenu.Text.ToUpper().Equals( "START"))
            if (tvMenu.Text.Length > 0 && !txtUpMenu.Text.ToUpper().Equals("ROOT"))
            {
                //SK.SMG.Common.Dac.CommonDac prxy = new SK.SMG.Common.Dac.CommonDac();
                //DataSet menuCnt = prxy.GetMenuInfo(txtUpMenu.Text);

                //if (menuCnt.Tables[0].Rows.Count == 0)
                //{
                //    MessageBox.Show("상위 메뉴 오류 - 상위 메뉴 없음", "SK.SMG Platform", MessageBoxButtons.OK);
                //    //MessageBox.Show("Up Menu Id is not property");
                //    txtUpMenu.Focus();
                //}
            }
        }



        private void commonButton1_OnDeleteClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                if (MessageBox.Show(CommonManager.GetMessage("M10005"), "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
                NEXCORE.Common.Data.Menu menu = new NEXCORE.Common.Data.Menu();
                menu.MenuId = txtMenu.Text;
                menu.MenuKorea = txtMenuKor.Text;
                menu.SysId = "";
                CommonManager.DeleteMenu(menu, true);
                CommonManager.ReloadMenu();
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10002"));

                BindData();
                setTree();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10004"), "", "1", ex.Message);
            }
            finally
            {

            }
        }

        private void commonButton1_OnNewClick(object sender, EventArgs e)
        {
            txtMenu.Enabled = true;
            txtMenu.Text = "";
            txtDesc.Text = "";

            txtMenuEng.Text = "";
            txtMenuKor.Text = "";
            txtOrder.Text = "";
            cmbProgram.Text = "";

            chkUse.Checked = false;
            txtUpMenu.Text = "";

        }

        private void commonButton1_OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValue()) return;
                NEXCORE.Common.Data.Menu menu = new NEXCORE.Common.Data.Menu();

                menu.MenuId = txtMenu.Text;
                menu.MenuKorea = txtMenuKor.Text;
                menu.SysId = "";
                menu.SORT = int.Parse(txtOrder.Text);
                menu.Use = chkUse.Checked ? "Y" : "N";
                menu.PgmId = cmbProgram.SelectedValue.ToString();
                menu.ParentMenuId = txtUpMenuId.Text;
                menu.UserId = FormInterface.GetCurrentUser().UserId;

                if (txtMenu.Enabled)
                {
                    if (!CheckDup(menu.MenuId)) return;
                    CommonManager.AddMenu(menu);
                }
                else
                {
                    CommonManager.UpdateMenu(menu);
                }
                CommonManager.ReloadMenu();
                txtMenu.Enabled = false;
                FormInterface.WriteStatusBar(this, CommonManager.GetMessage("M10001"));

                BindData();
                setTree();
            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);
            }

        }

        private void btnUpMenu_Click(object sender, EventArgs e)
        {
            ZZ004 form = new ZZ004();

            form.Tag = mgmtData;
            if (DialogResult.OK == form.ShowDialog())
            {
                txtUpMenu.Text = form.menuName;
                txtUpMenuId.Text = form.menuId;

            }

        }





        
    }
}


