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
using System.Net;
using System.Net.Sockets;

namespace NEXCORE.Utility
{
    public static class FTPHelper
    {
        public static void Connect(Socket ftpSock, string ip, int port)
        {
            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            ftpSock.SendTimeout = 3000;
            ftpSock.ReceiveTimeout = 3000;

            ftpSock.Connect(ip, port);

            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "220")
                throw new Exception("Connect Error : " + recvString);
        }

        public static void Login(Socket ftpSock, string loginID, string loginPassword)
        {
            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "USER " + loginID + "\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "331")
                throw new Exception("Login Error : " + recvString);

            tempString = "pass " + loginPassword + "\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "230")
                throw new Exception("Login Error : " + recvString);
        }

        public static void SwitchingBinaryMode(Socket ftpSock)
        {
            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "TYPE I\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "200")
                throw new Exception("SwitchingMode Error : " + recvString);
        }

        public static void SwitchingASCIIMode(Socket ftpSock)
        {
            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "TYPE A\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "200")
                throw new Exception("SwitchingMode Error : " + recvString);
        }

        public static void ChangeDirectory(Socket ftpSock, string directory)
        {
            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "CWD " + directory + "\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "250")
                throw new Exception("ChangeDirectory Error : " + recvString);
        }

        public static void MakeDirectory(Socket ftpSock, string directory)
        {
            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "MKD " + directory + "\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "257")
                throw new Exception("MakeDirectory Error : " + recvString);
        }

        public static bool FindDirectoryFile(Socket ftpSock, string file)
        {
            Socket ftpChannelSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "PASV\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "227")
                throw new Exception("FindDirectory Error : " + recvString);

            // Passive Mode 채널 접속 찾기...
            char[] sep = { ',', ')', ':' };
            string[] portFind = recvString.Split(sep);
            int port = Convert.ToInt32(portFind[portFind.Length - 3]) * 256 + Convert.ToInt32(portFind[portFind.Length - 2]);
            portFind = ftpSock.RemoteEndPoint.ToString().Split(sep);
            string ip = portFind[0];
            ftpChannelSock.Connect(ip, port);

            tempString = "LIST\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "150")
                throw new Exception("FindDirectory Error : " + recvString);

            int count = 0;
            recvString = "";
            do
            {
                count = ftpChannelSock.Receive(recvByte, recvByte.Length, 0);
                recvString += Encoding.Default.GetString(recvByte, 0, count);
            } while (count > 0);
            ftpChannelSock.Close();


            char[] sep2 = { '\n', '\r' };
            string[] fileDicArray = recvString.Split(sep2);
            List<string> fileDicList = new List<string>();

            for (count = 0; count < fileDicArray.Length; count++)
            {
                if (fileDicArray[count].Length > 0)
                    fileDicList.Add(fileDicArray[count].Substring(56));
            }

            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "226")
                throw new Exception("FindDirectory Error : " + recvString);

            if (fileDicList.Contains(file))
                return true;
            else
                return false;
        }

        public static void UploadFile(Socket ftpSock, string filePath, string fileName)
        {
            Socket ftpChannelSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Byte[] recvByte = new Byte[1024];
            string recvString = string.Empty;
            string tempString = string.Empty;

            tempString = "PASV\r\n";
            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "227")
                throw new Exception("UploadFile Error : " + recvString);

            // Passive Mode 채널 접속 찾기...
            char[] sep = { ',', ')', ':' };
            string[] portFind = recvString.Split(sep);
            int port = Convert.ToInt32(portFind[portFind.Length - 3]) * 256 + Convert.ToInt32(portFind[portFind.Length - 2]);
            portFind = ftpSock.RemoteEndPoint.ToString().Split(sep);
            string ip = portFind[0];
            ftpChannelSock.Connect(ip, port);

            tempString = "STOR " + fileName + "\r\n";

            ftpSock.Send(Encoding.Default.GetBytes(tempString), Encoding.Default.GetByteCount(tempString), 0);
            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "150")
                throw new Exception("UploadFile Error : " + recvString);

            FileStream file = new FileStream(filePath, FileMode.Open);
            Byte[] fileByte = new Byte[file.Length];
            int numToRead = (int)file.Length;
            int numRead = 0;

            while (numToRead > 0)
            {
                int n = file.Read(fileByte, numRead, numToRead);

                if (n == 0) break;

                ftpChannelSock.Send(fileByte);

                numRead += n;
                numToRead -= n;
            }

            ftpChannelSock.Close();
            file.Close();

            ftpSock.Receive(recvByte, recvByte.Length, 0);
            recvString = Encoding.Default.GetString(recvByte);

            if (recvString.Substring(0, 3) != "226")
                throw new Exception("UploadFile Error : " + recvString);
        }
    }
}