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
using System.Windows.Controls;
using NEXCORE.Service.ServiceManager;
using NEXCORE.Common.Data;
using System.Collections.Generic;
using System.Globalization;
using NEXCORE.Common.Helper;
using System.Diagnostics;


namespace NEXCORE.Common
{
    public static class CommonHelper
    {
        /// <summary>
        /// 메세지팝업 호출
        /// </summary>
        /// <param name="msgTitle">메세지제목</param>
        /// <param name="msg1">메세지1</param>
        /// <param name="msg2">메세지2</param>
        /// <param name="msgType">메세지구분(1:확인, 2:예/아니오)</param>
        /// <param name="msgDetail">메세지상세(에러등)</param>
        /// <returns></returns>
        public static string CallMsgPopUp(string msgTitle, string msg1, string msg2, string msgType,string msgDetail)
        {


            string msgData = "";

            frmMessage frm = new frmMessage(msgTitle, msg1, msg2, msgType, msgDetail);
            frm.BringToFront();
            frm.Focus();
            frm.ShowDialog();
            msgData = frm.ReturnMsg;
            frm.Dispose();

            return msgData;
        }

        public static void WriteLog(string message)
        {
            Logger.Write(message, "Framework");
        }

        //public static void WriteDebug(string message)
        //{
        //    //Logger.Write(message, "Debug Category", 1, 500, LogLevel.DEBUG);
        //}

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

        //private const string symmetricProvider = "RijndaelManaged";

        public static string Encrypt(string plainText)
        {
            string password = SkccFxConfigManager.GetString("EncryptKey");
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

        public static string Decrypt(string encryptedText)
        {
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
            return Encoding.Unicode.GetString(buffer3, 0, count);
            //return CryptoWrapper.DecryptSymmetric(symmetricProvider, encryptedText);
        }

        private const string hashProvider = "SHA256Managed";

        public static string CreateHash(string plainText)
        {
            return CryptoWrapper.CreateHash(hashProvider, plainText);
        }

        public static bool CompareHash(string plainText, string hashedText)
        {
            return CryptoWrapper.CompareHash(hashProvider, plainText, hashedText);
        }

        #region Binding Combobox

        public static void BindingComboBox(ref C1.Win.C1Input.C1DropDownControl cmb, string codeId)
        {
            List<Code> codeList = CodeServiceProxy.GetCodes(codeId);

            
            
            //cmb.DataField = "Name";
            cmb.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            cmb.DataSource = codeList;
            
        }


        public static void BindingComboBox(ref System.Windows.Forms.ComboBox cmb, string codeId)
        {
            List<Code> codeList = CodeServiceProxy.GetCodes(codeId);

            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Id";
            cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb.Height = 20;
            cmb.MaxDropDownItems = 10;
            cmb.DataSource = codeList;
        }
        public static void BindingComboBox(ref C1.Win.C1InputPanel.InputComboBox cmb, string codeId)
        {
            List<Code> codeList = CodeServiceProxy.GetCodes(codeId);

            cmb.MismatchValueErrorText = "값 '{0}' 은 이 옵션에 일치하지 않는 값입니다.";
            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Id";
            cmb.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDown;
            cmb.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest;
            //cmb.Height = 20;
            cmb.MaxDropDownItems = 10;
            cmb.DataSource = codeList;
        }
        /// <summary>
        /// 데이터셋을 inputpanel combobox 에 셋팅
        /// </summary>
        /// <param name="cmb">inputpanel combobox</param>
        /// <param name="ds">Dataset</param>
        /// <param name="display"></param>
        /// <param name="value"></param>
        public static void BindingComboBox(ref C1.Win.C1InputPanel.InputComboBox cmb, DataSet ds, string display,string value)
        {

            cmb.MismatchValueErrorText = "값 '{0}' 은 이 옵션에 일치하지 않는 값입니다.";
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
            cmb.DropDownStyle = C1.Win.C1InputPanel.InputComboBoxStyle.DropDown;
            cmb.AutoCompleteMode = C1.Win.C1InputPanel.InputAutoCompleteMode.Suggest;
            //cmb.Height = 20;
            cmb.MaxDropDownItems = 10;
            cmb.DataSource = ds;
        }
        public static List<Code> SearchItem( string codeId)
        {
            List<Code> List = CodeServiceProxy.GetCodes(codeId);


            return List;

        }


        #endregion

        public static string GetMenuTitleByLocale(NEXCORE.Common.Data.Menu menu, CultureInfo culInfo)
        {
            string menuTitle = menu.MenuKorea;
            switch (culInfo.Name)
            {
                case "ko-KR":
                    menuTitle = menu.MenuKorea;
                    break;
                case "en-US":
                    menuTitle = menu.MenuEnglish;
                    break;
                case "zh-CN":
                    menuTitle = menu.MenuChina;
                    break;
            }
            return menuTitle;
        }

        /// <summary>
        /// Check Is Null Or Empty
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpry(NEXCOREData data)
        {
            bool retValue = true;

            if (data != null)
            {
                if (data.DataSet != null)
                {
                    if (data.DataSet.Tables != null && data.DataSet.Tables.Count >= 0)
                    {
                        retValue = false;
                    }
                }
            }
            return retValue;
        }

        /// <summary>
        /// Null 값 처리
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static DateTime NvlDateTime(object obj)
        {
            if (obj == null)
            {
                return DateTime.Now;
            }
            if (obj == DBNull.Value)
            {
                return DateTime.Now;
            }
            if (obj.ToString() == "")
            {
                return DateTime.Now;
            }

            return Convert.ToDateTime(obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string NvlString(object obj)
        {
            if (obj == null)
            {
                return "";
            }
            if (obj == DBNull.Value)
            {
                return "";
            }
            if (obj.ToString() == "")
            {
                return "";
            }

            return obj.ToString();
        }

        public static int NvlInt(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            if (obj == DBNull.Value)
            {
                return 0;
            }
            if (obj.ToString() == "")
            {
                return 0;
            }

            return Convert.ToInt32(obj);
        }

        public static double NvlDouble(object obj)
        {
            if (obj == null)
            {
                return 0;
            }
            if (obj == DBNull.Value)
            {
                return 0;
            }
            if (obj.ToString() == "")
            {
                return 0;
            }

            return Convert.ToDouble(obj);
        }
    }
}