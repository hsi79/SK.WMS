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
    public partial class ZZ007 : SKDialogBase
    {
        DataTable mgmtData;
       public string deptId = string.Empty;
       public string deptName = string.Empty;
        public ZZ007()
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

        private void ZZ007_Load(object sender, EventArgs e)
        {
            BindData();
            CompositeMenu();

            tvDept.ExpandAll();
        }
        /// <summary>
        /// 메뉴 바인딩 
        /// </summary>
        private void BindData()
        {
            mgmtData = null;
            DataSet mgmtDataSet = null;
            try
            {
                

                mgmtDataSet = UtilityHelper.ToDataSet(CommonManager.GetWMSDeptList());

                mgmtData = mgmtDataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// 동적으로 Menu를 구성합니다.
        /// </summary>
        public void CompositeMenu()
        {
            tvDept.Nodes.Clear();

            if (mgmtData != null)
            {
                string query = "ParentDeptId = 'ROOT'";
                DataRow[] drTopMenu = mgmtData.Select(query, "SORT");

                for (int rowIdx = 0; rowIdx < drTopMenu.Length; rowIdx++)
                {
                    TreeNode parentNode = new TreeNode();
                    parentNode.Text = drTopMenu[rowIdx]["DeptName"].ToString() + "( " + drTopMenu[rowIdx]["DeptId"].ToString() + " )";
                    parentNode.Tag = drTopMenu[rowIdx]["DeptId"].ToString();
                    parentNode.ToolTipText = drTopMenu[rowIdx]["DeptId"].ToString();
                    SelfCompositMenu(parentNode, drTopMenu[rowIdx]["DeptId"].ToString());
                    tvDept.Nodes.Add(parentNode);


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
            string query = string.Format("ParentDeptId = '{0}'", topMenuCode);
            DataRow[] drMenuItem = mgmtData.Select(query, "SORT");

            if (drMenuItem.Length > 0)
            {
                for (int rowIdx = 0; rowIdx < drMenuItem.Length; rowIdx++)
                {
                    TreeNode curNode = new TreeNode();
                    curNode.Text = drMenuItem[rowIdx]["DeptName"].ToString() + "( " + drMenuItem[rowIdx]["DeptId"].ToString() + " )";
                    curNode.Tag = drMenuItem[rowIdx]["DeptId"].ToString();
                    curNode.ToolTipText = drMenuItem[rowIdx]["DeptId"].ToString();
                    parentNode.Nodes.Add(curNode);

                    // 재귀호출
                    SelfCompositMenu(curNode, drMenuItem[rowIdx]["DeptId"].ToString());
                }

            }
        }


        private void TrMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            getTreeMenu(tvDept.SelectedNode.Tag.ToString());
        }

        private void getTreeMenu(string menu)
        {

            if (mgmtData != null)
            {
                string query = "DeptId = '" + menu + "'";
                DataRow[] drTopMenu = mgmtData.Select(query, "SORT");

                deptId = drTopMenu[0]["DeptId"].ToString();

                deptName = drTopMenu[0]["DeptName"].ToString();
            }

        }

        private void tvMenu_DoubleClick(object sender, EventArgs e)
        {
            getTreeMenu(tvDept.SelectedNode.Tag.ToString());
            DialogResult = DialogResult.OK; 
        }


    }
}