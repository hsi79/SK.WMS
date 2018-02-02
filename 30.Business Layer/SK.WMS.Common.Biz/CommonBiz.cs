using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;
using NEXCORE.Common;
using System.Collections;
using Skcc.Transactions;
using System.Diagnostics;
using System.IO;
using NEXCORE.Utility;
using SK.WMS.Common.Dac;

namespace SK.WMS.Common.Biz
{
    /// <summary>
    /// Common Biz Class for SK.WMS Project
    /// </summary>

    /// </history>
    public class CommonBiz : SKBizBase
    {
        #region Local Variables
        /// <summary>
        /// Server IP Address
        /// </summary>
        private static string _serverIp = string.Empty;
        #endregion

        public static void Initialize()
        {
        }

        /// <summary>
        /// General Common Function
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData CommonFunction(NEXCOREData data)
        {
            return new NEXCOREData();
        }

        #region Logging History related to Table - THIS*
        /// <summary>
        /// Insert the log of invoking biz-component into THISCOMP
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData AddHistoryComponent(NEXCOREData data)
        {
            NEXCOREData retValue = new NEXCOREData();

            try
            {
                if (string.IsNullOrEmpty(_serverIp))
                {
                    _serverIp = System.Net.Dns.GetHostName();
                }

                data.Hashtable["connectedServer"] = _serverIp;

                //HistoryRepository hisRepo = new HistoryRepository();
                //retValue.Object = hisRepo.InsertTHISCOMPInfo(data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return retValue;
        }

 
        
        /// <summary>
        /// Insert the log of loading program (content, popup, etc) into THISCOMP
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData AddHistoryProgram(NEXCOREData data)
        {
            NEXCOREData retValue = new NEXCOREData();

            try
            {
                if (string.IsNullOrEmpty(_serverIp))
                {
                    _serverIp = System.Net.Dns.GetHostName();
                }

                data.Hashtable["connectedServer"] = _serverIp;

                retValue.Object = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return retValue;
        }

        /// <summary>
        /// Insert the log of login/out into THISLOGIN
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData AddHistoryLogin(NEXCOREData data)
        {
            NEXCOREData retValue = new NEXCOREData();

            try
            {
                if (string.IsNullOrEmpty(_serverIp))
                {
                    _serverIp = System.Net.Dns.GetHostName();
                }

                data.Hashtable["connectedServer"] = _serverIp;

                
                retValue.Object = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return retValue;
        }

        /// <summary>
        /// Get Prerequisite's DirectoryInfo
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData GetPrerequisitesDirectoryInfo(NEXCOREData data)
        {
            NEXCOREData retValue = new NEXCOREData();
            string retStr = string.Empty;
            int totalFileCount = 0;

            try
            {
                string prerequisitesPath = Skcc.Configuration.SkccFxConfigManager.GetString("PREREQUISITES_PATH");
                GetRecursiveDirectoryInfo(new DirectoryInfo(prerequisitesPath), ref retStr, ref totalFileCount, prerequisitesPath.Length);
                retValue.Object = retStr;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            string[] s = retValue.Object.ToString().Split('?');

            return retValue;
        }

        private static void GetRecursiveDirectoryInfo(DirectoryInfo dirInfo, ref string fileNames, ref int fileCount, int subStringLength)
        {
            string prerequisitesPath = Skcc.Configuration.SkccFxConfigManager.GetString("PREREQUISITES_PATH");
            FileInfo[] fi = dirInfo.GetFiles();
            
            foreach (FileInfo f in fi)
            {
                fileNames += f.FullName.Substring(subStringLength, f.FullName.Length - prerequisitesPath.Length);
                fileNames += "?";
                fileCount++;
            }

            DirectoryInfo[] di = dirInfo.GetDirectories();
            if (di.Length > 0)
            {
                foreach (DirectoryInfo d in di)
                {
                    GetRecursiveDirectoryInfo(d, ref fileNames, ref fileCount, subStringLength);
                }
            }
        }

        /// <summary>
        /// 데이터 암호화 호출용
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData Encrypt(NEXCOREData data)
        {
            NEXCOREData retValue = new NEXCOREData();

            try
            {
                retValue.Object = null;//UtilityHelper.encrypt_encode_base64(.Encrypt_SKNWMS(data.Object as string);
            }
            catch (Exception ex)
            {
                string msg = UtilityHelper.GetFinalInnerException(ex).Message;
                UtilityHelper.WriteLog(msg, UtilityHelper.eLogCategory.Component, System.Diagnostics.TraceEventType.Error);
            }

            return retValue;
        }
        #endregion

        private CommonDac dac;

        protected override void Activate()
        {
            base.Activate();
            dac = new CommonDac();
        }

        protected override void Deactivate()
        {
            base.Deactivate();
            if (dac != null)
                dac = null;
        }

        /// <summary>
        /// combobox 결과를 가져온다
        /// </summary>
        [Transaction(TransactionOption.None)]
        public static NEXCOREData GetT_SELECT(NEXCOREData data)
        {
            using (CommonDac dac = new CommonDac())
            {
                NEXCOREData retValue = new NEXCOREData();

                retValue.DataSet = dac.Select(data.Hashtable);
                return retValue;
            }
        }

        /// <summary>
        /// INB2010헤더정보변경테스트
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static NEXCOREData GetT_KSMTEST_SELECT(NEXCOREData data)
        {
            using (CommonDac dac = new CommonDac())
            {
                NEXCOREData retValue = new NEXCOREData();

                retValue.DataSet = dac.KSMTEST_Select(data.Hashtable);
                return retValue;
            }
        }
    }
}