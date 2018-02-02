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
using System.IO;


namespace SK.WMS.WinControls
{
    public partial class FileUpControl : UserControl
    {
        List<Files> file = new List<Files>();

        public FileUpControl()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        [Category("FileUpControl Event")]
        public event EventHandler OnAddClick;
        [Browsable(true)]
        [Category("FileUpControl Event")]
        public event EventHandler OnDeleteClick;
        [Browsable(true)]
        [Category("FileUpControl Event")]
        public event EventHandler OnUploadClick;
        private string saveDir;
        [Category("File Save Folder")]
        [Description("파일 저장 폴더")]
        [Browsable(true)]
        [DefaultValue("")]
        public string SaveDir
        {
            get
            {
                return saveDir;
            }
            set
            {
                saveDir = value;
            }
        }
        private void btnFileAdd_Click(object sender, EventArgs e)
        {

            OnClickAdd(sender, e);
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            bool isExist = false;
            string strExit = string.Empty;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        string fullname = openFileDialog.FileNames[i];
                        FileInfo finfo = new FileInfo(fullname);                        


                        for (int j = 0; j < listFile.Items.Count; j++)
                        {
                            if (listFile.Items[j].ToString() == finfo.Name)
                            {

                                isExist = true;
                                strExit += finfo.Name + " : ";
                                return;
                            }
                        }
                        if (isExist)
                        {
                            MessageBox.Show(string.Format("{0} 파일은  이미 추가되어 있습니다.", strExit));
                            return;
                        }


                        Files item = new Files();

                        item.FileName = finfo.Name;
                        item.FileFullName = finfo.FullName;
                        item.FileSaveDir = saveDir;
                       
                        item.FileExt = finfo.Extension;
                        item.FileSize = finfo.Length;
                        item.FileSizeMB = GetFileSize(finfo.Length);
                        file.Add(item);

                        listFile.Items.Add(item.FileName);
                        
                    }


                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }



        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            OnClickDelete(sender, e);
            int selected = listFile.SelectedIndices.Count;

            // Find a book by its ID.
            

            if (listFile.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < selected; i++)
                {
                    Files result = file.Find(
                    delegate(Files fi)
                    {
                        return fi.FileName == listFile.SelectedItems[0].ToString();
                    }
                    );

                    if (result != null) file.Remove(result);
            

                    listFile.Items.Remove(listFile.SelectedItems[0]);

                }
                
            }
        }


        private void FileUpControl_Load(object sender, EventArgs e)
        {

            btnFileAdd.BackgroundImage = Properties.Resources.main_btn_up;
            btnFileDelete.BackgroundImage = Properties.Resources.main_btn_up;
            btnUpload.BackgroundImage = Properties.Resources.main_btn_up; 
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            OnClickUpload(sender, e);

            FileTransControl ft = new FileTransControl(file);
            
            if (DialogResult.OK == ft.ShowDialog())
            {

                MessageBox.Show("파일 업로드에 성공하였습니다.");
            }

        }
        public void OnClickAdd(object sender, EventArgs args)
        {

            if (OnAddClick != null)
            {

                Invoke(OnAddClick, null);

            }

        }
        public void OnClickUpload(object sender, EventArgs args)
        {

            if (OnUploadClick != null)
            {

                Invoke(OnUploadClick, null);

            }

        }
        public void OnClickDelete(object sender, EventArgs args)
        {

            if (OnDeleteClick != null)
            {

                Invoke(OnDeleteClick, null);

            }

        }
        public string GetFileSize(Int64 numBytes)
        {
            string fileSize = "";

            if (numBytes > 1073741824)
                fileSize = String.Format("{0:0.00} Gb", (double)numBytes / 1073741824);
            else if (numBytes > 1048576)
                fileSize = String.Format("{0:0.00} Mb", (double)numBytes / 1048576);
            else
                fileSize = String.Format("{0:0} Kb", (double)numBytes / 1024);

            if (fileSize == "0 Kb")
                fileSize = "1 Kb";	// min.							
            return fileSize;
        }


    }
}
