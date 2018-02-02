using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web;
using Skcc.Configuration;
using Skcc.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using NEXCORE.Common.Data;
using System.Threading;
using System.Net;
using NEXCORE.Service.ServiceManager;
/// <summary>
///  파일을 업로드하는 클래스
/// </summary>
namespace NEXCORE.Common
{
    public class FileTransUtility
    {
        public int ChunkSize = 16 * 1024;		// 16k by default
        public int MaxRetries = 50;				// max number of corrupted chunks to allow before giving up
        protected int NumRetries = 0;
        public int AverageSample = 5;			// number of chunks to sample the average transfer time for, to use with AutoSetChunkSize
        public bool IncludeHashVerification = false;	// checks the local file hash against the uploaded file hash to verify that the files are identical
        public int PreferredTransferDuration = 1500;	// miliseconds, the timespan the class will attempt to achieve for each chunk
        protected string LocalFileName;
        protected DateTime StartTime;
        protected Thread HashThread;
        public string SaveDirPath;
        public string tempFileName;
        public List<string> filelist;
        public string serverFileFolder;
        public string RemoteFileName;
        public string LocalFilePath;
        public bool fileDivide = false;
        private FileServiceProxy WebService;
        private string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;

        public FileTransUtility()
        {

        }

        /// <summary>
        /// This method starts the uplaod process. It supports cancellation, reporting progress, and exception handling.
        /// </summary>
        public bool UpLoad()
        {

            
            WebService = new FileServiceProxy();
            int numIterations = 0;
            this.LocalFileName = Path.GetFileName(this.LocalFilePath);

            if (!File.Exists(LocalFilePath))
                throw new Exception(String.Format("Could not find file {0}", LocalFilePath));

            long FileSize = new FileInfo(LocalFilePath).Length;
            string FileSizeDescription = GetFileSize(FileSize); // e.g. "2.4 Gb" instead of 240000000000000 bytes etc...
            long SentBytes = 0;   // this variable is used to inform the user interface of the upload progress
            byte[] Buffer = new byte[ChunkSize];    // this buffer stores each chunk, for sending to the web service via MTOM

            using (FileStream fs = new FileStream(LocalFilePath, FileMode.Open, FileAccess.Read))
            {
                int BytesRead = fs.Read(Buffer, 0, ChunkSize);	// read the first chunk in the buffer

                // send the chunks to the web service one by one, until FileStream.Read() returns 0, meaning the entire file has been read.
                while (BytesRead > 0)
                {
                    try
                    {

                        // send this chunk to the server.  it is sent as a byte[] parameter, but the client and server have been configured to encode byte[] using MTOM. 
                        WebService.AppendChunk(SaveDirPath, tempFileName, Buffer, SentBytes, BytesRead);

                        // sentBytes is only updated AFTER a successful send of the bytes. so it would be possible to build in 'retry' code, to resume the upload from the current SentBytes position if AppendChunk fails.
                        SentBytes += BytesRead;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Exception: " + ex.ToString());
                        return false;
                    }
                    BytesRead = fs.Read(Buffer, 0, ChunkSize);	// read the next chunk (if it exists) into the buffer.  the while loop will terminate if there is nothing left to read
                    numIterations++;
                }
            }
            if (fileDivide)
            {
                WebService.DivideFile(SaveDirPath, tempFileName);
            }

            WebService = null;
            return true;

        }
        public bool UpLoadHttp(string lblSource, string lblTarget)
        {


            FileStream fs;
            string sFileName;

            //int result;
            Byte[] buffer = new Byte[ChunkSize];
            HttpWebRequest wReq;
            long lngFileSize;
            //long lngDownlodFileSize;
            Stream _stream;
            int _readData;
            //int iProgress;
            //string aPath;
            //string filePath;

            //string fileName;

            //        //fileName = lbl
            FileInfo fi = new FileInfo(lblSource);
            sFileName = fi.Name;

            wReq = (HttpWebRequest)WebRequest.Create("http://168.154.150.246/" + "");
            wReq.Credentials = CredentialCache.DefaultCredentials;

            wReq.UserAgent = "UPLOADER";//   ' User-Agent HTTP 헤더값

            wReq.KeepAlive = true;

            wReq.Method = "PUT";

            //buffer =  buffer[2096];

            _stream = wReq.GetRequestStream();

            lngFileSize = fi.Length;

            if (fi.Exists)
            {


                fs = new FileStream(sFileName, FileMode.Open, FileAccess.Read);
                //lngDownlodFileSize = 0;

                while (true)
                {
                    _readData = fs.Read(buffer, 0, 4096);

                    if (_readData > 0)
                    {
                        _stream.Write(buffer, 0, _readData);
                        //lngDownlodFileSize += _readData
                        //iProgress = CType(Format(lngDownlodFileSize / lngFileSize, "#.00"), Double) * 100
                        //lblTitle.Text = (Int(lngDownlodFileSize / 1000)).ToString + "KB /" + (Int(lngFileSize / 1000)).ToString + "KB " + iProgress.ToString + " % "
                        //lblSource.Text = fileName
                        //lblTarget.Text = DownUrl & sFileName

                        //progBar.Value = iProgress

                        //Application.DoEvents()
                    }
                    else
                    {
                        fs.Close();
                        _stream.Close();
                        System.Threading.Thread.Sleep(50);
                    }
                }

            }
            else
            {
                _stream.Close();
                System.Threading.Thread.Sleep(50);
            }



            HttpWebResponse myResponse = (HttpWebResponse)wReq.GetResponse();

            if (myResponse.StatusCode == HttpStatusCode.Created || myResponse.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;

            }


        }

        public string FileView(string RemoteFileName)
        {
            WebService = new FileServiceProxy();

            return WebService.FileView(RemoteFileName);

            //return WebService
        }
        public bool DownLoad()
        {
            WebService = new FileServiceProxy();

            int numIterations = 0;

            //int i = RemoteFileName.LastIndexOf("\\");

            //string LocalFile = RemoteFileName.Substring(i);



            if (File.Exists(this.LocalFilePath))   // create a new empty file
                File.Create(this.LocalFilePath).Close();

            long FileSize = WebService.GetFileSize(RemoteFileName);   // the file is on the server and we need to know how big it is before we start downloading, in order to give accurate feedback to the user.
            string FileSizeDescription = GetFileSize(FileSize);   // e.g. "2.4 Gb" instead of 24000000000000000 bytes etc.
            long ReceivedBytes = 0; // this variable is used to allow the code to know when to stop requesting chunks

            // open a file stream for the file we will write to in the start-up folder
            using (FileStream fs = new FileStream(LocalFilePath, FileMode.Append, FileAccess.Write))
            {
                // download the chunks from the web service one by one, until all the bytes have been read, meaning the entire file has been downloaded.
                while (ReceivedBytes < FileSize)
                {
                    //if (this.AutoSetChunkSize && numIterations == AverageSample)		// take an average of the first 5 transfers
                    //{
                    //    long timeForInitialChunks = (long)DateTime.Now.Subtract(StartTime).TotalMilliseconds;
                    //    long averageChunkTime = Math.Max(1, timeForInitialChunks / AverageSample);	// average of 5 chunks, in ms
                    //    this.ChunkSize = (int)Math.Min(4000000, this.ChunkSize * PreferredTransferDuration / averageChunkTime);	// set the chunk size so that it takes 2 seconds per chunk (estimate), but not greater than 4mb
                    //}

                    try
                    {
                        // although the DownloadChunk returns a byte[], it is actually sent using MTOM because of the configuration settings. 
                        byte[] Buffer = WebService.DownloadChunk(RemoteFileName, ReceivedBytes, ChunkSize);
                        fs.Write(Buffer, 0, Buffer.Length);
                        ReceivedBytes += Buffer.Length;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Exception: " + ex.ToString());
                        if (NumRetries++ < MaxRetries)
                        {
                            // swallow the exception and try again
                        }
                        else
                        {
                            fs.Close();
                            throw new Exception(String.Format("Error occurred during upload {0}, too many retries.", ex.Message));
                        }
                        return false;
                    }
                    // update the user interface by reporting progress.
                    string SummaryText = String.Format("Transferred {0} / {1}", GetFileSize(ReceivedBytes), FileSizeDescription);
                    numIterations++;
                }
            }
            WebService = null;
            return true;

        }

        public long GetFileSize(string fullPath)
        {
            if (!File.Exists(fullPath))
            {
                return 0;
            }

            return new FileInfo(fullPath).Length;
        }
        /// <summary>
        /// Returns a description of a number of bytes, in appropriate units.
        /// e.g. 
        ///		passing in 1024 will return a string "1 Kb"
        ///		passing in 1230000 will return "1.23 Mb"
        /// Megabytes and Gigabytes are formatted to 2 decimal places.
        /// Kilobytes are rounded to whole numbers.
        /// If the rounding results in 0 Kb, "1 Kb" is returned, because Windows behaves like this also.
        /// </summary>
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

        public int FileDelete(string tempFileName)
        {
            WebService = new FileServiceProxy();
            return WebService.RemoveFile(tempFileName);

        }
        public void CreateFolder(string saveDir)
        {
            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }

        }
        #region 파일 편집
        public string CopyFile(string srcFileName, string destFileName)
        {
            WebService = new FileServiceProxy();
            return WebService.CopyFile(srcFileName, destFileName);

        }

        public void CreateFullFolder(string saveDir)
        {
            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }

        }
        #endregion

    }
}