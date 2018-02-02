using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace NEXCORE.Service.ServiceManager
{
    public class FileServiceProxy
    {
        private static FileService.FileServiceClient _FileService;
        
        private static string FILE_SERVICE_URL = "FILE_SERVICE_URL";



        #region 폴더 편집
        public static int DeleteDirectory(string realPath, bool isForce)
        {
            try
            {
                if (!CheckConnection())
                    return -1;

                return _FileService.DeleteDirectory(realPath, isForce);
            }
            catch 
            {
                return -1;
            }

        }



        #endregion


 
        public int RemoveFile(string tempFileName)
        {
            try
            {
                if (!CheckConnection())
                    return -1;

                return _FileService.RemoveFile(tempFileName);
            }
            catch
            {
                return -1;
            }
        }
        public string CopyFile(string srcFileName,string desFileName)
        {
            try
            {
                if (!CheckConnection())
                    return "-1";

                return _FileService.CopyFile(srcFileName, desFileName);
            }
            catch
            {
                return "-1";
            }
        }
        public long GetFileSize(string fullPath)
        {
            try
            {
                if (!CheckConnection())
                    return -1;

                return _FileService.GetFileSize(fullPath);
            }
            catch
            {
                return -1;
            }
        }


        public void AppendChunk(string saveDir, string tempFileName, byte[] buffer, long Offset, int BytesRead)
        {
            try
            {
                if (!CheckConnection())
                    return ;

                 _FileService.AppendChunk(saveDir,tempFileName,buffer,Offset,BytesRead);
            }
            catch
            {
                return ;
            }
        }
        public void Write(byte[] buffer, long Offset, int BytesRead, string Paramdelimiter)
        {

            try
            {
                if (!CheckConnection())
                    return ;

                _FileService.Write(buffer, Offset, BytesRead, Paramdelimiter);
            }
            catch
            {
                return ;
            }
        }

        public void DivideFile(string saveDir, string tempFileName)
        {
            try
            {
                if (!CheckConnection())
                    return ;

                 _FileService.DivideFile(saveDir, tempFileName);
            }
            catch
            {
                return ;
            }
        }

        public byte[] DownloadChunk(string fullPath, long Offset, int BufferSize)
        {
            try
            {
                if (!CheckConnection())
                    return null;

                return _FileService.DownloadChunk(fullPath, Offset, BufferSize);
            }
            catch
            {
                return null;
            }
        }

        public string FileView(string remoteFileName)
        {

            try
            {
                if (!CheckConnection())
                    return "";

                return _FileService.FileView(remoteFileName);
            }
            catch
            {
                return "";
            }
        }
        
        private static bool CheckConnection()
        {
            if (_FileService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(FILE_SERVICE_URL);

                Binding wsBinding = new BasicHttpBinding();

                EndpointAddress address = new EndpointAddress(url);

                _FileService = new FileService.FileServiceClient(wsBinding, address);
            }

            return true;
        }


    }
}
