using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using Skcc.Configuration;

namespace NEXCORE.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FileService" in code, svc and config file together.
    public class FileService : IFileService
    {
    private string UploadPath;

    public FileService()
    {
        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");
        UploadPath = path;// +saveDir;
        if (!Directory.Exists(UploadPath))
        {
            Directory.CreateDirectory(UploadPath);
        }
    }




    #region 프로퍼티
    public string UploadPathAttribute
    {
        get
        {
            return this.UploadPath;
        }
    }
    #endregion

    #region 폴더 편집
    public int DeleteDirectory(string realPath, bool isForce)
    {
        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");

        try
        {
            if (!Directory.Exists(path + realPath)) return 1; //이미 폴더가 없으면, 정상처리된 것으로 처리
            Directory.Delete(path + realPath, isForce);
            return 1;
        }
        catch
        {
            //throw new Exception("디렉토리 삭제 에러");
        }
        return -1;
    }
    public string MoveDirectory(string realPath, string newPath)
    {
        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");

 
        try
        {
            Directory.Move(path + realPath, path + newPath);
            return "0";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public bool CheckDirectoryExist(string fullPath)
    {
        return Directory.Exists(fullPath);
    }
    public int EnsureDirectory(string dirPath)
    {
        try
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            return 1;
        }
        catch { }
        return 0;
    }
    public void CreateFolder(string saveDir)
    {
        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");
        UploadPath = path + saveDir;// server.MapPath("VR");
        if (!Directory.Exists(UploadPath))
        {
            Directory.CreateDirectory(UploadPath);
        }

    }
    public void CreateFullFolder(string saveDir)
    {
        if (!Directory.Exists(saveDir))
        {
            Directory.CreateDirectory(saveDir);
        }

    }

    #endregion


    #region 파일 편집
    public string MoveFile(string sourceFileName, string destFileName)
    {
        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");

        try
        {
            FileInfo fi = new FileInfo(path + destFileName);
            CreateFullFolder(fi.DirectoryName);
            System.IO.File.Move(path + sourceFileName, path + destFileName);
            return "0";
        }
        catch 
        {
            return path;
        }

    }
    public string CopyFile(string sourceFileName, string destFileName)
    {
        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");

        try
        {
            FileInfo fi = new FileInfo(path + "EdmsViewTemp\\" + destFileName);
            CreateFullFolder(fi.DirectoryName);
            System.IO.File.Copy(path + sourceFileName, path + "EdmsViewTemp\\" + destFileName);
            return "0";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }

    public int RemoveFile(string tempFileName)
    {
        try
        {
            if (!System.IO.File.Exists(UploadPath + tempFileName)) return 1; //이미 파일이 없으면, 정상처리된 것으로 처리
            System.IO.File.Delete(UploadPath + tempFileName);
            return 1;
        }
        catch
        { }
        return 0;
    }
    public long GetFileSize(string fullPath)
    {
        if (!System.IO.File.Exists(UploadPath + fullPath))
        {
            return 0;
        }

        return new FileInfo(UploadPath + fullPath).Length;
    }
    #endregion


    public void AppendChunk(string saveDir, string tempFileName, byte[] buffer, long Offset, int BytesRead)
    {
        CreateFolder(saveDir);
        string FilePath = this.UploadPathAttribute + "\\" + tempFileName;

        // make sure that the file exists, except in the case where the file already exists and offset=0, i.e. a new upload, in this case create a new file to overwrite the old one.
        bool FileExists = System.IO.File.Exists(FilePath);
        if (!FileExists || (System.IO.File.Exists(FilePath) && Offset == 0))
            System.IO.File.Create(FilePath).Close();
        long FileSize = new FileInfo(FilePath).Length;

        // if the file size is not the same as the offset then something went wrong....
        if (FileSize != Offset)
        {
            return;
            //CustomSoapException("Transfer Corrupted", String.Format("The file size is {0}, expected {1} bytes", FileSize, Offset));
        }
        else
        {
            // offset matches the filesize, so the chunk is to be inserted at the end of the file.
            using (FileStream fs = new FileStream(FilePath, FileMode.Append))
                fs.Write(buffer, 0, BytesRead);
        }
    }
    public void Write(byte[] buffer, long Offset, int BytesRead,string Paramdelimiter)
    {

        string[] param = Paramdelimiter.Split(',');
        string saveDir = string.Empty;
        string tempFileName = string.Empty;
        string mbr_id = string.Empty;
        if (param.Length > 0)
        {
            mbr_id = param[0].Trim();
            saveDir = param[1].Trim();
        }
        CreateFolder(saveDir);

        string FilePath = this.UploadPathAttribute + "\\" + tempFileName;

        // make sure that the file exists, except in the case where the file already exists and offset=0, i.e. a new upload, in this case create a new file to overwrite the old one.
        bool FileExists = System.IO.File.Exists(FilePath);
        if (!FileExists || (System.IO.File.Exists(FilePath) && Offset == 0))
            System.IO.File.Create(FilePath).Close();
        long FileSize = new FileInfo(FilePath).Length;

        // if the file size is not the same as the offset then something went wrong....
        if (FileSize != Offset)
        {
            return;
            //CustomSoapException("Transfer Corrupted", String.Format("The file size is {0}, expected {1} bytes", FileSize, Offset));
        }
        else
        {
            // offset matches the filesize, so the chunk is to be inserted at the end of the file.
            using (FileStream fs = new FileStream(FilePath, FileMode.Append))
                fs.Write(buffer, 0, BytesRead);
        }
    }

    public void DivideFile(string saveDir, string tempFileName)
    {
        CreateFolder(saveDir);

        string FilePath = this.UploadPathAttribute + "\\" + tempFileName;
        FileInfo FileName = new FileInfo(FilePath);
        string strFile = FileName.Name;

        try
        {
            string[] dirs = Directory.GetFiles(UploadPath, strFile + "_*");
            foreach (string dir in dirs)
            {
                System.IO.File.Delete(dir);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }

    public byte[] DownloadChunk(string fullPath, long Offset, int BufferSize)
    {
        string FilePath = this.UploadPathAttribute + "\\" + fullPath;// +"\\" + FileName;

        // check that requested file exists
        if (!System.IO.File.Exists(FilePath))
        {
            return null;
            //CustomSoapException("File not found", "The file " + FilePath + " does not exist");
        }

        long FileSize = new FileInfo(FilePath).Length;

        // if the requested Offset is larger than the file, bail out.
        if (Offset > FileSize)
        {
            return null;
            //CustomSoapException("Invalid Download Offset", String.Format("The file size is {0}, received request for offset {1}", FileSize, Offset));
        }

        // open the file to return the requested chunk as a byte[]
        byte[] TmpBuffer;
        int BytesRead;
        using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
        {
            fs.Seek(Offset, SeekOrigin.Begin);	// this is relevent during a retry. otherwise, it just seeks to the start
            TmpBuffer = new byte[BufferSize];
            BytesRead = fs.Read(TmpBuffer, 0, BufferSize);	// read the first chunk in the buffer (which is re-used for every chunk)
        }
        if (BytesRead != BufferSize)
        {
            // the last chunk will almost certainly not fill the buffer, so it must be trimmed before returning
            byte[] TrimmedBuffer = new byte[BytesRead];
            Array.Copy(TmpBuffer, TrimmedBuffer, BytesRead);
            return TrimmedBuffer;
        }
        else
            return TmpBuffer;
    }

    public string FileView(string remoteFileName)
    {

        string path = SkccFxConfigManager.TryGetString("UPLOADPATH");
        int i  = path.IndexOf("\\");
        path = path.Substring(i);
        remoteFileName = path + remoteFileName;
        remoteFileName = remoteFileName.Replace("\\", "/");
        
        return remoteFileName;
    }






    private void FileDelete(string filePath)
    {
        if (System.IO.File.Exists(filePath))
            System.IO.File.Delete(filePath);
    }




    }
}
