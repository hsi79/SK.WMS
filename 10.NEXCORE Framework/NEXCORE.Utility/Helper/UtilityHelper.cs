using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web;
using Skcc.Configuration;
using Skcc.Diagnostics;
using Skcc.IoC;
using Skcc.Security.Cryptography;
using System.Security.Cryptography;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using NEXCORE.Common.Data;
using System.Runtime.InteropServices;
using System.Xml;
using System.Net;
using NEXCORE.Utility.GlobalVariable;

namespace NEXCORE.Utility
{
    public static class UtilityHelper
    {
        public enum eLogCategory
        {
            Component = 0,
            Framework,
            UI
        }

        public enum KeyModifiers        //enum to call 3rd parameter of RegisterHotKey easily
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        //API Imports
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
            IntPtr hWnd, // handle to window    
            int id, // hot key identifier    
            KeyModifiers fsModifiers, // key-modifier options    
            System.Windows.Forms.Keys vk    // virtual-key code    
            );

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd, // handle to window    
            int id      // hot key identifier    
            );

        [DllImport("C:\\SK.WMS\\Assembly\\Issac.dll")]
        public static extern int Open(string addr, int port);
        [DllImport("C:\\SK.WMS\\Assembly\\Issac.dll")]
        public static extern int GetErrorMessage(int handle, StringBuilder sc);
        [DllImport("C:\\SK.WMS\\Assembly\\Issac.dll")]
        public static extern int encrypt_encode_base64(int handle, String src, StringBuilder desc);
        [DllImport("C:\\SK.WMS\\Assembly\\Issac.dll")]
        public static extern int decode_base64_decrypt(int handle, String src, StringBuilder desc);
        [DllImport("C:\\SK.WMS\\Assembly\\Issac.dll")]
        public static extern int hashing_encode_base64(int handle, String src, StringBuilder desc);
        [DllImport("C:\\SK.WMS\\Assembly\\Issac.dll")]
        public static extern int Close(int handle);


        const string FRAMEWORK_LOG_CATEGORY = "Framework";
        public static  string COMPONENT_CATEGORY = "ComponentManager";
        private static Dictionary<string, Stopwatch> lstStopwatch = new Dictionary<string, Stopwatch>();

        public static void GetMaskString()
        {
            throw new NotImplementedException();
        }

        #region Logging

        //Critical     : 심각한 오류 또는 응용 프로그램 충돌 
        //Error        : 복구할 수 있는 오류 
        //Warning      : 단순한 문제 
        //Information  : 알림 메시지 
        //Verbose      : 추적 디버깅 
        //Start        : 논리 작업의 시작 
        //Stop         : 논리 작업의 중지 
        //Suspend      : 논리 작업의 일시 중단 
        //Resume       : 논리 작업의 다시 시작 
        //Transfer     : 상관 관계 ID의 변경 


        // 1. Critical        ==> Critical

        // 2. Error           ==> Critical, Error

        // 3. Warning         ==> Criticla ,Error, Warning

        // 4. Information     ==> Critical, Error, Information, Warning
       
        // 5. Verbose         ==> Critical, Error, Information, Warning, Verbose

        // 6. ActivityTracing ==> Resume, Start, Stop, Suspend, Transfer
        public static void WriteTimeLog(string timerName, string msg)
        {
            try
            {
                long timeTick = lstStopwatch[timerName].ElapsedMilliseconds;

                Skcc.Diagnostics.LogWrapper.Write(
                    string.Format("Processing Time Checker{0} : {1} : {2}", timerName, msg, timeTick.ToString()), FRAMEWORK_LOG_CATEGORY, TraceEventType.Information);
            }
            catch { }
        }

        public static string WriteTimeLogStart(string name, string msg)
        {
            string guid = string.Empty;

            try
            {
                Stopwatch sw = new Stopwatch();
                guid = Guid.NewGuid().ToString();

                lstStopwatch.Add(guid, sw);

                sw.Start();
                Skcc.Diagnostics.LogWrapper.Write(
                    string.Format("Start Timer Checker{0} : {1}", guid, msg), FRAMEWORK_LOG_CATEGORY, TraceEventType.Information);
            }
            catch { }
            return guid;
        }

        public static void WriteEndTimeLog(string name, string msg)
        {
            try
            {
                long timeTick = lstStopwatch[name].ElapsedMilliseconds;

                Skcc.Diagnostics.LogWrapper.Write(
                    string.Format("End Timer Checker{0} : {1} : {2}", name, timeTick.ToString(), msg), FRAMEWORK_LOG_CATEGORY, TraceEventType.Information);

                lstStopwatch[name].Stop();
                lstStopwatch.Remove(name);
            }
            catch { }
        }

        public static void WriteLog(string message)
        {
            try
            {
                Debug.WriteLine(message);
                WriteLog(message, TraceEventType.Information);
            }
            catch { }
        }

        public static void WriteLog(string message, TraceEventType traceType)
        {
            try
            {
                Debug.WriteLine(message);
                Skcc.Diagnostics.LogWrapper.Write(message, FRAMEWORK_LOG_CATEGORY, traceType);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public static void WriteLog(string message, string category)
        {
            try
            {
                Debug.WriteLine(message);
                WriteLog(message, category, TraceEventType.Information);
            }
            catch { }
        }

        public static void WriteLog(string message, string category, TraceEventType traceType)
        {
            try
            {
                Debug.WriteLine(message);
                Skcc.Diagnostics.LogWrapper.Write(message, category, traceType);
            }
            catch { }
        }

        public static void WriteLog(string message, eLogCategory category, TraceEventType traceType)
        {
            WriteLog(message, category.ToString(), traceType);
        }

        public static string WriteNEXCOREDataLog(string header, NEXCOREData skdata)
        {
             StringBuilder sb = new StringBuilder();

            try
            {
                if (skdata == null)
                    return header;

                sb.AppendLine(header);
                sb.AppendLine(string.Format(
                    "NAME : [{0}], MethodName : [{1}], ObjectType : [{2}]",
                    skdata.Name, skdata.MethodName, skdata.Object == null ? "null" : skdata.Object.GetType().ToString()));

                if (skdata.Hashtable != null && skdata.Hashtable.Count > 0)
                {
                    sb.AppendLine("Hashtable Count : " + skdata.Hashtable.Count.ToString());

                    foreach (object key in skdata.Hashtable.Keys)
                    {
                        sb.AppendLine(string.Format("KEY[{0}] : {1}", key.ToString(), skdata.Hashtable[key].ToString()));
                    }
                }

                if (skdata.DataSet != null)
                {
                    sb.AppendLine("DataSet Table Count = " + skdata.DataSet.Tables.Count.ToString());

                    int i = 0;
                    foreach (DataTable dt in skdata.DataSet.Tables)
                    {
                        sb.AppendLine(string.Format("DataSet.DataTable[{0}] = {1}", i.ToString(), dt.TableName));
                        i++;
                    }
                }

                if (skdata.DataTable != null)
                {
                    sb.AppendLine("DataTable Name = " + skdata.DataTable.TableName);
                    int i = 0;
                    foreach (DataColumn c in skdata.DataTable.Columns)
                    {
                        sb.AppendLine(string.Format("DataColumn[{0}] = {1}", i.ToString(), c.ColumnName));
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityHelper.WriteLog(ex.ToString(), eLogCategory.Framework, TraceEventType.Warning);
            }

            return sb.ToString();
        }

        public static void WriteHashTableLog(string header, Hashtable ht)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(header);


                if (ht != null && ht.Count > 0)
                {
                    sb.AppendLine("Hashtable Count : " + ht.Count.ToString());

                    foreach (object key in ht.Keys)
                    {
                        sb.AppendLine(string.Format("KEY[{0}] : {1}", key.ToString(), ht[key].ToString()));
                    }
                }
                UtilityHelper.WriteLog(sb.ToString(), eLogCategory.Framework, TraceEventType.Information);
            }
            catch (Exception ex)
            {
                UtilityHelper.WriteLog(ex.ToString(), eLogCategory.Framework, TraceEventType.Warning);
            }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetLinkURL()
        {
            return "http://168.154.150.190/SK.WMS/Deploy/SK.WMS.UI.application?";
        }

        public static string GetConfig(string key)
        {
            return ConfigManager.TryGetString(key);
        }

        public static string GetNEXCOREConfig(string key)
        {
            return SkccFxConfigManager.TryGetString(key);
        }

        public static string GetConfigAppSettings(string name)
        {
            return CustomConfigManager.GetString(name);
        }

        /// <summary>
        /// ClickOnce의 버전 가져오기
        /// </summary>
        /// <param name="strDeployUrl"></param>
        /// <returns></returns>
        public static string GetCurrentVersion(string strDeployUrl)
        {
            string version = "";

            XmlDocument xmlDoc = new XmlDocument();

            Uri site = new Uri(strDeployUrl);

            try
            {
                HttpWebRequest wReq = (HttpWebRequest)WebRequest.Create(site);
                wReq.ReadWriteTimeout = 1000;
                wReq.UserAgent = "WMS";

                HttpWebResponse wResp = (HttpWebResponse)wReq.GetResponse();

                Stream respStream = wResp.GetResponseStream();
                StreamReader reader = new StreamReader(respStream, Encoding.Default);

                String respHTML = reader.ReadToEnd();

                reader.Close();
                wResp.Close();

                xmlDoc.LoadXml(respHTML);

                version = xmlDoc.ChildNodes[1].FirstChild.Attributes["version"].Value;

                xmlDoc = null;
            }
            catch (Exception ex)
            {
                version = "";
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.UI, System.Diagnostics.TraceEventType.Error);
            }

            return version;
        }

        //private const string symmetricProvider = "RijndaelManaged";

        #region NEXCORE Encryption/Decryptio Algorithm
        /// <summary>
        /// Encrypt using NEXCORE Encryption Algorithm
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string Encrypt(string plainText)
        {
            string password = string.Empty;//SkccFxConfigManager.GetString("EncryptKey");
            password = "RijndaelManaged";
            RijndaelManaged managed = new RijndaelManaged();
            byte[] buffer = Encoding.Unicode.GetBytes(plainText);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(password.Length.ToString());
            PasswordDeriveBytes bytes = new PasswordDeriveBytes(password, rgbSalt);
            ICryptoTransform transform = managed.CreateEncryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
            MemoryStream stream = new MemoryStream();
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
            stream2.Write(buffer, 0, buffer.Length);
            stream2.FlushFinalBlock();
            byte[] inArray = stream.ToArray();
            stream.Close();
            stream2.Close();
            return Convert.ToBase64String(inArray);

            //return CryptoWrapper.EncryptSymmetric(symmetricProvider, plainText);
        }

        /// <summary>
        /// Decrypt using NEXCORE Encryption Algorithm
        /// </summary>
        /// <param name="encryptedText"></param>
        /// <returns></returns>
        public static string Decrypt(string encryptedText)
        {
            string password = string.Empty;// SkccFxConfigManager.GetString("EncryptKey");
            password = "RijndaelManaged";
            RijndaelManaged managed = new RijndaelManaged();
            byte[] buffer = Convert.FromBase64String(encryptedText);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(password.Length.ToString());
            PasswordDeriveBytes bytes = new PasswordDeriveBytes(password, rgbSalt);
            ICryptoTransform transform = managed.CreateDecryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
            MemoryStream stream = new MemoryStream(buffer);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            byte[] buffer3 = new byte[buffer.Length];
            int count = stream2.Read(buffer3, 0, buffer3.Length);
            stream.Close();
            stream2.Close();
            return Encoding.Unicode.GetString(buffer3, 0, count);
            //return CryptoWrapper.DecryptSymmetric(symmetricProvider, encryptedText);
        }

        public static Hashtable DecryptPara(string encryptedText)
        {
            Hashtable ht = new Hashtable();

            //빈값일경우 암호화 하지않음
            if (encryptedText.Equals("")) return ht;

            encryptedText = encryptedText.Replace(" ", "+");
            string password = SkccFxConfigManager.GetString("EncryptKey");
            RijndaelManaged managed = new RijndaelManaged();
            byte[] buffer = Convert.FromBase64String(encryptedText);
            byte[] rgbSalt = Encoding.ASCII.GetBytes(password.Length.ToString());
            PasswordDeriveBytes bytes = new PasswordDeriveBytes(password, rgbSalt);
            ICryptoTransform transform = managed.CreateDecryptor(bytes.GetBytes(0x20), bytes.GetBytes(0x10));
            MemoryStream stream = new MemoryStream(buffer);
            CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
            byte[] buffer3 = new byte[buffer.Length];
            int count = stream2.Read(buffer3, 0, buffer3.Length);
            stream.Close();
            stream2.Close();

            string[] arrTo = Encoding.Unicode.GetString(buffer3, 0, count).Split('&');

            for (int i = 0; i < arrTo.Length; i++)
            {
                string[] arrPara = arrTo[i].Split('=');
                if (arrPara.Length > 1)
                    ht.Add(arrPara[0].ToString(), arrPara[1].ToString());
            }
            return ht;
            //return CryptoWrapper.DecryptSymmetric(symmetricProvider, encryptedText);
        }

        private const string hashProvider = "SHA256Managed";

        /// <summary>
        /// Encrypt Hashing using NEXCORE Encryption Algorithm
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        public static string CreateHash(string plainText)
        {
            return CryptoWrapper.CreateHash(hashProvider, plainText);
        }

        /// <summary>
        /// Compare HashText with PlainText using NEXCORE Encryption Algorithm
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="hashedText"></param>
        /// <returns></returns>
        public static bool CompareHash(string plainText, string hashedText)
        {
            return CryptoWrapper.CompareHash(hashProvider, plainText, hashedText);
        }
        #endregion

        public static NEXCOREData getNEXCOREData(string pgmid)
        {
            NEXCOREData nexData = new NEXCOREData();
            if (!WMSVar.dicDataList.ContainsKey(pgmid)) return nexData;
            return WMSVar.dicDataList[pgmid];
        }

        public static void SendMail()
        {
        }

        #region DataSet, DataTable, DataRow 파싱
        public static string GetString(DataRow row, string colName)
        {
            return GetString(row, colName, string.Empty);
        }

        public static string GetString(DataRow row, string colName, string nullValue)
        {

            // Row가 null 인지 확인
            if (row == null)
                return nullValue;

            if (row.Table.Columns.Contains(colName) == true)
            {
                //컬럼이 존재 한다면

                if (row[colName] == null || row[colName] == DBNull.Value)
                {
                    //Cell이 널이가 DB Null일경우
                    return nullValue;
                }

                //값 반환
                return row[colName].ToString();
            }

            return nullValue;
        }

        public static bool GetBoolean(DataRow row, string colName)
        {
            return GetBoolean(row, colName, false);
        }

        public static bool GetBoolean(DataRow row, string colName, bool nullValue)
        {
            // Row가 null 인지 확인
            if (row == null)
                return nullValue;

            if (row.Table.Columns.Contains(colName) == true)
            {
                //컬럼이 존재 한다면

                if (row[colName] == null || row[colName] == DBNull.Value)
                {
                    //Cell이 널이가 DB Null일경우
                    return nullValue;
                }

                //값 반환

                bool retValue = nullValue;
                try
                {
                    retValue = (bool)row[colName];
                }
                catch { }

                return retValue;
            }

            return nullValue;
        }

        public static bool GetBooleanYN(DataRow row, string colName, bool nullValue)
        {
            // Row가 null 인지 확인
            if (row == null)
                return nullValue;

            if (row.Table.Columns.Contains(colName) == true)
            {
                //컬럼이 존재 한다면

                if (row[colName] == null || row[colName] == DBNull.Value)
                {
                    //Cell이 널이가 DB Null일경우
                    return nullValue;
                }

                //값 반환

                string strRet = row[colName].ToString();

                if (strRet.ToUpper() == "Y")
                    return true;
                else if (strRet.ToUpper() == "N")
                    return false;
                else
                    return nullValue;
            }

            return nullValue;
        }

        public static DateTime GetDatetime(DataRow row, string colName)
        {
            return GetDatetime(row, colName, DateTime.Now);
        }

        public static DateTime GetDatetime(DataRow row, string colName, DateTime nullValue)
        {
            // Row가 null 인지 확인
            if (row == null)
                return nullValue;

            if (row.Table.Columns.Contains(colName) == true)
            {
                //컬럼이 존재 한다면

                if (row[colName] == null || row[colName] == DBNull.Value)
                {
                    //Cell이 널이가 DB Null일경우
                    return nullValue;
                }

                //값 반환

                DateTime retValue = nullValue;
                try
                {
                    retValue = (DateTime)row[colName];
                }
                catch { }

                return retValue;
            }

            return nullValue;
        }

        public static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
        #endregion

        public static Exception GetFinalInnerException(Exception ex)
        {
            do
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(string.Format("{0} - Start : NEXCORE.Utility.UtilityHelper - GetFinalInnerException", DateTime.Now.ToString()));
                sb.AppendLine("Exception\r\n\t" + ex.ToString());
                sb.AppendLine("Exception Message\r\n\t" + ex.Message);
                sb.AppendLine("Exception Stack Trace\r\n\t" + ex.StackTrace);
                sb.AppendLine(string.Format("{0} - End : NEXCORE.Utility.UtilityHelper - GetFinalInnerException", DateTime.Now.ToString()));

                WriteLog(sb.ToString(), eLogCategory.Framework, TraceEventType.Error);

                if (ex.InnerException == null)
                    break;
                else
                    ex = ex.InnerException;

            } while (ex != null);

            return ex;
        }
    }
}