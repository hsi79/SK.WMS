using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using System.Runtime.Serialization;

namespace NEXCORE.Common.Data
{
    [KnownType(typeof(Files))]
    [KnownType(typeof(DBNull))]
    [Serializable]
    [DataContract]
    public class Files 
    {
        private string _chk;
        private string _fileId;
        private string _filePath;
        private string _fileName;
        private Int64 _fileSize;
        private string _fileSizeMB;
        private string _fileExt;
        private string _fileKey;
        private string _fileFullName;
        private string _fileSaveName;
        private string _fileSaveDir;
        #region IFiles 멤버
        [DataMember]
        public string Chk
        {
            get { return _chk; }
            set { _chk = value; }
        }
        [DataMember]
        public string FileId
        {
            get { return _fileId; }
            set { _fileId = value; }
        }
        [DataMember]
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }        
        [DataMember]
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        [DataMember]
        public string FileSizeMB
        {
            get { return _fileSizeMB; }
            set { _fileSizeMB = value; }
        }
        [DataMember]
        public Int64 FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        [DataMember]
         public string FileExt
        {
            get { return _fileExt; }
            set { _fileExt = value; }
        }
        [DataMember]
        public string FileKey
        {
            get { return _fileKey; }
            set { _fileKey = value; }
        }
        [DataMember]
        public string FileFullName
        {
            get { return _fileFullName; }
            set { _fileFullName = value; }
        }
        [DataMember]
        public string FileSaveName
        {
            get { return _fileSaveName; }
            set { _fileSaveName = value; }
        }
        [DataMember]
        public string FileSaveDir
        {
            get { return _fileSaveDir; }
            set { _fileSaveDir = value; }
        }
        #endregion
    }
}
