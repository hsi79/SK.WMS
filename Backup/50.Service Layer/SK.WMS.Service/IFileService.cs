using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NEXCORE.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFileService" in both code and config file together.
    [ServiceContract]
    public interface IFileService
    {
        [OperationContract]
        void AppendChunk(string saveDirPath, string tempFileName, byte[] buffer, long Offset, int BytesRead);
        [OperationContract]
        void Write(byte[] buffer, long Offset, int BytesRead, string param);
        [OperationContract]
        void DivideFile(string saveDirPath, string tempFileName);

        [OperationContract]
        byte[] DownloadChunk(string fullPath, long Offset, int BufferSize);
        [OperationContract]
        string FileView(string RemoteFileName);

        [OperationContract]
        long GetFileSize(string fullPath);


        [OperationContract]
        int RemoveFile(string tempFileName);

        string MoveDirectory(string srcDir, string desDir);
        [OperationContract]
        int DeleteDirectory(string srcDir, bool isForce);
        [OperationContract]
         string CopyFile(string srcFile, string desFile);
        [OperationContract]
         string MoveFile(string srcFile, string desFile);

    }
}
