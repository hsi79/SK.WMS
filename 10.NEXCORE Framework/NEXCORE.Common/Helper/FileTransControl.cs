using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NEXCORE.Service.ServiceManager;
using System.IO;
using System.Threading;
using NEXCORE.Common.Data;


namespace NEXCORE.Common
{
    public partial class FileTransControl : Form
    {
        public List<Files> FileList = new List<Files>();
       private FileServiceProxy WebService;
       Thread th;
       public int ChunkSize = 16 * 1024;
       private string LocalFileName;
       public string SaveDirPath = string.Empty;
       private string tempFileName;
       private string TotFileSizeDescription;
       private bool ret = true;
       delegate void Ctrl_Involk(Control ctrl, string text);
       delegate void Progressbar_Involk(ProgressBar ctrl, int num);
       delegate void SetView_Involk(ListView ctrl, int row, int col, string val);
       delegate bool Check_Involk(CheckBox ctrl);
       delegate void Button_Involk(Button ctrl, bool text);
       public void setText(Control ctrl, string txtValue)
       {



           if (ctrl.InvokeRequired)
           {
               Ctrl_Involk CI = new Ctrl_Involk(setText);
               ctrl.Invoke(CI, ctrl, txtValue);
           }
           else
           {
               ctrl.Text = txtValue;
           }


       }
       public void setValue(ProgressBar ctrl, int intValue)
       {



           if (ctrl.InvokeRequired)
           {
               Progressbar_Involk CI = new Progressbar_Involk(setValue);
               ctrl.Invoke(CI, ctrl, intValue);
           }
           else
           {
               ctrl.Value = intValue;
           }

       }
       public void setView(ListView ctrl, int row, int col, string val)
       {



           if (ctrl.InvokeRequired)
           {
               SetView_Involk CI = new SetView_Involk(setView);
               ctrl.Invoke(CI, ctrl, row, col, val);
           }
           else
           {
               ctrl.Items[row].SubItems[col].Text = val;
           }


       }
       public bool getCheck(CheckBox ctrl)
       {

           if (ctrl.InvokeRequired)
           {
               Check_Involk CI = new Check_Involk(getCheck);
               return (bool)ctrl.Invoke(CI, ctrl);
           }
           else
           {
               return ctrl.Checked;
           }




       }
       public void setButton(Button ctrl, bool enValue)
       {



           if (ctrl.InvokeRequired)
           {
               Button_Involk CI = new Button_Involk(setButton);
               ctrl.Invoke(CI, ctrl, enValue);
           }
           else
           {
               ctrl.Enabled = enValue;
           }


       }
        public FileTransControl()
        {
            InitializeComponent();
        }

        public FileTransControl(List<Files> transfile)
        {
            InitializeComponent();

            FileList = transfile;
        }

        private void FileTransControl_Load(object sender, EventArgs e)
        {
            //FileTransUtility ft = new FileTransUtility();
            //ft.filelist = file;

            try
            {
                ExtractAssociatedIconEx();

                lblFileCnt.Text = FileList.Count.ToString();

                th = new Thread(new ThreadStart(this.UpLoad));      // 쓰레드 클래스의 새 인스턴스를 초기화
                th.Start();

            }
            catch (Exception ex)
            {
                setButton(btnClose, true);
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ret)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.No;
            }
        }
        public void UpLoad()
        {

            setButton(btnClose, false);
            long TotFileSize = 0;
            long TotSendBytes = 0;
            for (int i = 0; i < FileList.Count; i++)
            {

                long FileSize = new FileInfo(FileList[i].FileFullName).Length;

                TotFileSize += FileSize;
            }

            TotFileSizeDescription = GetFileSize(TotFileSize);
            WebService = new FileServiceProxy();

            try
            {
                

                for (int i = 0; i < FileList.Count; i++)
                {

                    setText(this.lblFileCnt, (i + 1).ToString() + " / " + FileList.Count.ToString());
                    SaveDirPath = FileList[i].FileSaveDir;

                    int numIterations = 0;

                    this.LocalFileName = Path.GetFileName(FileList[i].FileFullName);

                    if (!File.Exists(FileList[i].FileFullName))
                        throw new Exception(String.Format("Could not find file {0}", FileList[i]));

                    long FileSize = new FileInfo(FileList[i].FileFullName).Length;

                    string FileSizeDescription = GetFileSize(FileSize); // e.g. "2.4 Gb" instead of 240000000000000 bytes etc...
                    long SendBytes = 0;   // this variable is used to inform the user interface of the upload progress
                    byte[] Buffer = new byte[ChunkSize];    // this buffer stores each chunk, for sending to the web service via MTOM
                    tempFileName = FileList[i].FileSaveName;
                    using (FileStream fs = new FileStream(FileList[i].FileFullName, FileMode.Open, FileAccess.Read))
                    {
                        int BytesRead = fs.Read(Buffer, 0, ChunkSize);	// read the first chunk in the buffer

                        while (BytesRead > 0)
                        {
                            try
                            {

                                WebService.AppendChunk(SaveDirPath, tempFileName, Buffer, SendBytes, BytesRead);
                                SendBytes += BytesRead;
                                TotSendBytes += BytesRead;

                                setValue(this.progressFile, (int)(TotSendBytes * 100 / TotFileSize));
                                setText(this.lblPercent, (int)(TotSendBytes * 100 / TotFileSize) + "%");
                                setText(this.lblFileSize, GetFileSize(TotSendBytes) + " / " + TotFileSizeDescription);
                                setView(listView1, i, 2, "전송중");
                                setView(listView1, i, 1, GetFileSize(SendBytes) + " / " + FileSizeDescription);

                            }
                            catch (Exception e)
                            {
                                ret = false;
                                MessageBox.Show(e.Message);
                                setButton(btnClose, true);
                                break;
                            }
                            BytesRead = fs.Read(Buffer, 0, ChunkSize);	// read the next chunk (if it exists) into the buffer.  the while loop will terminate if there is nothing left to read
                            numIterations++;
                        }


                        setView(listView1, i, 2, "전송완료");
                    }
                    if (FileList[i].FileExt.ToLower() == ".dwg") // 확장자가 도면 파일일 경우 
                    {
                        SaveDirPath = "DWG\\" + FileList[i].FileSaveName + "\\";
                        tempFileName = FileList[i].FileName;
                        SendBytes = 0;
                        using (FileStream fs1 = new FileStream(FileList[i].FileFullName, FileMode.Open, FileAccess.Read))
                        {
                            int BytesRead1 = fs1.Read(Buffer, 0, ChunkSize);	// read the first chunk in the buffer

                            while (BytesRead1 > 0)
                            {
                                try
                                {

                                    WebService.AppendChunk(SaveDirPath, tempFileName, Buffer, SendBytes, BytesRead1);
                                    SendBytes += BytesRead1;



                                }
                                catch (Exception e)
                                {
                                    ret = false;
                                    MessageBox.Show(e.Message);
                                    setButton(btnClose, true);
                                    break;
                                }
                                BytesRead1 = fs1.Read(Buffer, 0, ChunkSize);	// read the next chunk (if it exists) into the buffer.  the while loop will terminate if there is nothing left to read

                            }
                        }
                    }

                }

                if (getCheck(chkClose))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                setButton(btnClose, true);
                th.Abort();

            }
            catch (Exception e)
            {
                th.Abort();
                ret = false;
                MessageBox.Show(e.Message);
                btnClose.Enabled = true;
                DialogResult = DialogResult.Cancel;
            }
            ret = true;
            btnClose.Enabled = true;
            WebService = null;
            return;

        }

        public void Download(string filePath, string fileName)
        {
            //WebService = new FileServiceProxy();

            //long offSet = 0;
            //int bufferSize = (int)WebService.GetFileSize(@"R\01\11\R01110000000010001");
            
            //byte[] data = WebService.DownloadChunk(@"R\01\11\R01110000000010001", offSet, bufferSize);

            // 사용자의 Downloads 폴더 C:\Users\Administrator\Downloads
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string pathDownload = Path.Combine(pathUser, "Downloads");


            FileTransUtility ft = new FileTransUtility();
            ft.LocalFilePath = pathDownload + @"\" + "R01110000000010001"; // 다운로드 받을 파일명
            ft.RemoteFileName = @"R\01\11\R01110000000010001"; // 업로드된 파일명
            ft.DownLoad();

            // 바로 열기를 하고 싶으면 사용
            //System.Diagnostics.Process.Start(pathDownload + @"\test.doc");
        }

        public long GetFileSize(string fullPath)
        {
            if (!File.Exists(fullPath))
            {
                return 0;
            }

            return new FileInfo(fullPath).Length;
        }
        public string GetFileSize(long numBytes)
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
        public void ExtractAssociatedIconEx()
        {


            for (int i = 0; i < FileList.Count; i++)
            {
                // 리스트뷰 아이템을 업데이트 하기 시작.
                // 업데이트가 끝날 때까지 UI 갱신 중지.
                listView1.BeginUpdate();

                // 뷰모드 지정
                listView1.View = View.Details;

                // 아이콘을 위해 이미지 지정
                listView1.LargeImageList = imageList1;

                FileInfo fi = new FileInfo(FileList[i].FileFullName);

                    // 각 파일별로 ListViewItem객체를 하나씩 만듦
                    // 파일명, 사이즈, 날짜 정보를 추가
                    Icon iconForFile = SystemIcons.WinLogo;
                    iconForFile = Icon.ExtractAssociatedIcon(fi.FullName);
                    ListViewItem lvi = new ListViewItem(fi.Name, 1);
                    lvi.SubItems.Add(fi.Length.ToString());
                    lvi.SubItems.Add(fi.LastWriteTime.ToString());


                    if (!imageList1.Images.ContainsKey(fi.Extension))
                    {            // If not, add the image to the image list.            
                        iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName);
                        imageList1.Images.Add(fi.Extension, iconForFile);
                    }
                    lvi.ImageKey = fi.Extension;
                    // ListViewItem객체를 Items 속성에 추가
                    listView1.Items.Add(lvi);
                


                // 리스뷰를 Refresh하여 보여줌
                listView1.EndUpdate();



            }
                // 컬럼명과 컬럼사이즈 지정
                listView1.Columns.Add("파일명", 300, HorizontalAlignment.Left);
                listView1.Columns.Add("전송량", 150, HorizontalAlignment.Left);
                listView1.Columns.Add("전송상태", 90, HorizontalAlignment.Center);
        }


    }
}
