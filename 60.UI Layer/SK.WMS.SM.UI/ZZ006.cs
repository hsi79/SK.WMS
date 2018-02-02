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
    public partial class ZZ006 : SKDialogBase
    {
        DataTable mgmtData;
        public ZZ006()
        {

            InitializeComponent();

            
        }

        private bool reload = false;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msg = null;
            bool ret = true;
            if (!CheckValue(ret)) return;
            if (tvF.Nodes.Count == 0) return;

            for (int i = 1; i < tvF.Nodes.Count; i++)
            {


                    NEXCORE.Common.Data.Menu menu = new NEXCORE.Common.Data.Menu();
                    menu.UserId = FormInterface.GetCurrentUser().UserId;
                    menu.PgmId = tvF.Nodes[i].Tag.ToString();
                    menu.MenuKorea = tvF.Nodes[i].Text; 
                    menu.SORT = i;

                    ret = CommonManager.UpdateMyMenu(menu);

            }
                if (ret)
                {
                    msg = "정상적으로 변경되었습니다.";
                    MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
                    reload = true;
                }
                else
                {
                    msg = "즐겨찾기 변경중 오류가 발생하였습니다.관리자에게 연락바랍니다.";
                    MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                    Cursor.Current = Cursors.Default;
                    return;
                }

            Cursor.Current = Cursors.Default;

        }

        private bool CheckValue(bool ret)
        {

            for (int i = 1; i < tvF.Nodes.Count; i++)
            {


                if (string.IsNullOrEmpty(tvF.Nodes[i].Text))
                {
                    string msg = "즐겨찾기이름은 필수 입니다.";
                    MessageBox.Show(this, msg, "Error Message", MessageBoxButtons.OK);
                    ret = false;
                    break;
                }

            }
            return ret;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (reload)
            {
                DialogResult = DialogResult.Retry;
            }
            else
            {
                DialogResult = DialogResult.Cancel;

            }
        }

        private void ZZ006_Load(object sender, EventArgs e)
        {
            DataSet ds = UtilityHelper.ToDataSet(CommonManager.GetMyMenuList(FormInterface.GetCurrentUser().UserId));
            mgmtData = ds.Tables[0];
            CompositeMenu();

            tvF.AllowDrop = true;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvF.SelectedNode == null) return;
                if (tvF.SelectedNode.Index < 0) return;

                if (MessageBox.Show(CommonManager.GetMessage("M10005"), "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
                NEXCORE.Common.Data.Menu menu = new NEXCORE.Common.Data.Menu();

                menu.UserId = FormInterface.GetCurrentUser().UserId;
                menu.PgmId = tvF.SelectedNode.Tag.ToString();

                bool ret = CommonManager.DeleteMyMenu(menu);


                string msg = "정상적으로 변경되었습니다.";
                MessageBox.Show(this, msg, "Info Message", MessageBoxButtons.OK);
                reload = true;

            }
            catch (Exception ex)
            {
                CommonHelper.CallMsgPopUp("오류", CommonManager.GetMessage("M10003"), "", "1", ex.Message);

            }
        }
        /// <summary>
        /// 동적으로 Menu를 구성합니다.
        /// </summary>
        public void CompositeMenu()
        {
            tvF.Nodes.Clear();

            if (mgmtData != null)
            {
                string query = "";
                DataRow[] drTopMenu = mgmtData.Select(query, "SORT");

                for (int rowIdx = 0; rowIdx < drTopMenu.Length; rowIdx++)
                {
                    TreeNode parentNode = new TreeNode();
                    parentNode.Text = drTopMenu[rowIdx]["MenuKorea"].ToString() ;
                    parentNode.Tag = drTopMenu[rowIdx]["PgmId"].ToString();
                    parentNode.ToolTipText = drTopMenu[rowIdx]["PgmId"].ToString();
                    tvF.Nodes.Add(parentNode);

                }

            }
        }

        private void tvF_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void tvw_ItemDrag(object sender, ItemDragEventArgs e)
        {

            tvF.DoDragDrop(e.Item, DragDropEffects.Move);

        }



        private void tvw_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;

        }



        private void tvw_DragDrop(object sender, DragEventArgs e)
        {

            Point loc = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));

            TreeNode node = (TreeNode)e.Data.GetData(typeof(TreeNode));

            TreeNode destNode = ((TreeView)sender).GetNodeAt(loc);

            if (destNode == null) return;

            if (node.Parent == null)

                node.TreeView.Nodes.Remove(node);

            else

                node.Parent.Nodes.Remove(node);



            if (destNode.Parent == null)

                destNode.TreeView.Nodes.Insert(destNode.Index + 1, node);

            else

                destNode.Parent.Nodes.Insert(destNode.Index + 1, node);

        }


        private void tvF_DoubleClick(object sender, EventArgs e)
        {
            tvF.LabelEdit = true;
            tvF.Nodes[tvF.SelectedNode.Index].BeginEdit(); //
        }


    }
}