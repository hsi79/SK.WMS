using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;
using NEXCORE.Utility;

namespace SK.WMS.SM.UI
{
    public partial class ZZ004 : SKDialogBase
    {
        DataTable mgmtData;
       public string menuId = string.Empty;
       public string menuName = string.Empty;
        public ZZ004()
        {

            InitializeComponent();

            
        }


        private void btnComfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            

        }

        private void ZZ004_Load(object sender, EventArgs e)
        {
            BindData();
            CompositeMenu();
        }
        /// <summary>
        /// 메뉴 바인딩 
        /// </summary>
        private void BindData()
        {
            mgmtData = (DataTable)this.Tag;

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

        private void getTreeMenu(string menu)
        {

            if (mgmtData != null)
            {
                string query = "MenuId = '" + menu + "'";
                DataRow[] drTopMenu = mgmtData.Select(query, "SORT");

                menuId = drTopMenu[0]["MenuId"].ToString();

                menuName = drTopMenu[0]["MenuKorea"].ToString();
            }

        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            getTreeMenu(tvMenu.SelectedNode.Tag.ToString());
            DialogResult = DialogResult.OK; 
        }


    }
}