using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;       //INI관련
using System.Windows.Forms;
using NEXCORE.Common;
using NEXCORE.Common.Data;


namespace NEXCORE.Utility
{
    /// <summary>
    /// 자주 사용되는 Function으로 좀 더 편리하게 사용하고자 작성된 Method
    /// </summary>
    /// <remarks>
    /// Grid와 Editor에 대한 유틸은 별도로 구현
    /// 문자열 처리, DataSet, DataTable 체크, 데이터형 체크 등
    /// </remarks>
    public static class CommonUtils
    {
        /// <summary>
        /// INI 읽기/쓰기 관련
        /// </summary>
        /// <param name="lpAppName"></param>
        /// <param name="lpKeyName"></param>
        /// <param name="lpString"></param>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        [DllImport("kernel32")]
        public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        public static string StrFormat(string sHead, string sStr )
        {
            string result = "";
            if (sStr.Length == 1)
            {
                result = sHead + sStr;
            }
            else
            {
                result = sStr;
            }

            return result;
        }

        /// <summary>
        /// 한글입력여부 체크
        /// </summary>
        /// <param name="data">입력값</param>
        /// <returns></returns>
        public static bool ChkHangul(string data)
        {
            bool Ret = false;
            string result = "";

            foreach (char ch in data)
            {
                if (char.GetUnicodeCategory(ch) == System.Globalization.UnicodeCategory.OtherLetter)
                    result += ch;
            }

            if (result.Trim().Length != 0)
                Ret = true;

            return Ret;
        }

        /// <summary>
        /// 문자열 왼쪽부터 자르기
        /// </summary>
        /// <param name="sourceStr">원본 문자열</param>
        /// <param name="len">잘라올 길이(문자수)</param>
        /// <returns>String - 값</returns>
        public static string Left(string sourceStr, int len)
        {
            string result = "";

            if (String.IsNullOrEmpty(sourceStr) || sourceStr == "" || len < 0)
            {
                result = "";
            }
            else if (sourceStr.Length < len)
            {
                result = sourceStr;
            }
            else
            {
                result = sourceStr.Substring(0, len);
            }

            return result;
        }

        /// <summary>
        /// 문자열 오른쪽부터 자르기
        /// </summary>
        /// <param name="sourceStr">원본 문자열</param>
        /// <param name="len">잘라올 길이(문자수)</param>
        /// <returns>String - 값</returns>
        public static string Right(string sourceStr, int len)
        {
            string result = "";

            if (String.IsNullOrEmpty(sourceStr) || sourceStr == "" || len < 0)
            {
                result = "";
            }
            else if (sourceStr.Length < len)
            {
                result = sourceStr;
            }
            else
            {
                int start = sourceStr.Length - len;
                result = sourceStr.Substring(start, len);
            }

            return result;
        }

        /// <summary>
        /// 문자열을 왼쪽부터 바이트로 자르기
        /// </summary>
        /// <param name="sourceStr">원본 문자열</param>
        /// <param name="len">잘라올 길이(Byte단위)</param>
        /// <returns>String - 값</returns>
        public static string LeftByte(string sourceStr, int len)
        {
            string isTmpStrValue = string.Empty;
            string isReturnValue = string.Empty;
            int iByteCont = 0;

            try
            {
                sourceStr = sourceStr.PadRight(len, ' ');

                for (int i = 0; i < sourceStr.Length; i++)
                {
                    isTmpStrValue = isTmpStrValue + sourceStr.Substring(i, 1);
                    iByteCont = Encoding.Default.GetByteCount(isTmpStrValue);

                    if (iByteCont == len)
                    {
                        isReturnValue = isTmpStrValue.ToString();
                        break;
                    }
                    else if (iByteCont > len)
                    {
                        isReturnValue = isTmpStrValue.Substring(0, isTmpStrValue.Length - 1);
                        isReturnValue = isReturnValue + string.Empty.PadRight(1, ' ').ToString();
                        break;
                    }
                }
            }
            catch
            {
                isReturnValue = "";
            }

            return isReturnValue.Trim();
        }

        /// <summary>
        /// 문자열을 Byte로 자르기
        /// </summary>
        /// <param name="src">원본 문자열</param>
        /// <param name="start">시작 Index</param>
        /// <param name="byteCount">가져올 길이</param>
        /// <returns></returns>
        private static string GetWordByByte(string src, int start, int byteCount)
        {
            //GetEncoding("ks_c_5601_1987")
            System.Text.Encoding enc = System.Text.Encoding.Default;
            byte[] buf = enc.GetBytes(src);
            return enc.GetString(buf, start, byteCount);
        }

        /// <summary>
        /// DB null , null -> string.Empty
        /// </summary>
        /// <param name="obj">Object - 입력 값</param>
        /// <returns>string - 값</returns>
        public static string CheckNull(Object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return string.Empty;
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// DataSet 확인
        /// </summary>
        /// <param name="ds">DataSet - 확인할 DataSet</param>
        /// <param name="tableName">string - 테이블명</param>
        /// <returns>bool - 확인여부</returns>
        public static bool CheckDataSet(DataSet ds, string tableName)
        {
            bool retVal = false;

            if (ds != null &&
                ds.Tables[tableName] != null)
            {
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// DataSet 확인
        /// </summary>
        /// <param name="ds">DataSet - 확인할 DataSet</param>
        /// <returns>bool - 확인여부</returns>
        public static bool CheckDataSet(DataSet ds)
        {
            bool retVal = false;

            if (ds != null && ds.Tables.Count > 0)
            {
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// Data 확인
        /// </summary>
        /// <param name="ds">Data - 확인할 Data</param>
        /// <returns>bool - 확인여부</returns>
        public static bool CheckData(int ds)
        {
            bool retVal = false;

            if ( ds > 0           )
            {
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// CheckBox Data 확인
        /// </summary>
        /// <param name="ds">Data - 확인할 Data</param>
        /// <returns>bool - 확인여부</returns>
        public static int CheckBoxData(CheckState chk)
        {
            int retVal = 0;

            if (CheckState.Checked == chk)
            {
                retVal = 1;
            }
            else
            {
                retVal = 0;
            }

            return retVal;
        }

        /// <summary>
        /// DataTable 확인
        /// </summary>
        /// <param name="dt">DataTable - 확인할 DataTable</param>
        /// <returns>bool - 확인여부</returns>
        public static bool CheckDataTable(DataTable dt)
        {
            bool retVal = false;

            if (dt != null &&
                dt.Rows.Count > 0
                )
            {
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// 쿼리문 필터링
        /// </summary>
        /// <param name="quertyStr">쿼리문</param>
        /// <returns></returns>
        public static string FilterQueryStr(string quertyStr)
        {
            quertyStr = Regex.Replace(quertyStr, @"[\n\t\r]+", " ");
            quertyStr = Regex.Replace(quertyStr, @" +", " ");

            return quertyStr;
        }

        /// <summary>
        /// 숫자형(Number)인지 체크한다.
        /// </summary>
        /// <param name="obj">체크할 객체</param>
        /// <returns>숫자일때만 true, 이외 false</returns>
        public static bool CheckNumber(object obj)
        {
            if (obj == null || obj == DBNull.Value || Convert.ToString(obj) == "")
                return false;

            string str = Convert.ToString(obj);
            str = str.Replace(",", "");

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    continue;
                else
                    return false;       //문자일때 false
            }

            return true;                //숫자일때만 true;
        }

        
        /// <summary>
        /// 숫자 필드 일 경우 숫자인지 체크
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        public static bool intCheck(string cont)
        {
            if (string.IsNullOrEmpty(cont))
            {
                return false;
            }
            else
            {
                Regex numericPattern = new Regex(@"^(\+|-)?\d+$");
                return numericPattern.IsMatch(cont);
            }
        }

        /// <summary>
        /// Decimal 형식인지 체크한다.
        /// </summary>
        /// <param name="obj">체크할 객체</param>
        /// <returns>숫자일때만 true, 이외 false</returns>
        public static bool CheckDecimal(object obj)
        {
            if (obj == null || obj == DBNull.Value || Convert.ToString(obj) == "")
                return false;

            string str = Convert.ToString(obj);

            for (int i = 0; i < str.Length; i++)
            {
                // 음수
                if (i == 0 && str[i] == '-')
                    continue;

                if (char.IsDigit(str[i]) || str[i] == '.' || str[i] == ',' || str[i] == '\\')
                    continue;
                else
                    return false;       // 문자일때 false
            }

            return true;                //숫자일때 true;
        }

        /// <summary>
        /// byte Length 구하기
        /// </summary>
        /// <param name="src">원본 문자열</param>
        /// <returns>int - byte 길이</returns>
        public static int GetByteLength(string src)
        {
            int bytePos = 0;
            int charWidth = 0;

            Encoding unicode = Encoding.Unicode;
            byte[] buf = unicode.GetBytes(src);

            for (int i = 1; i < buf.LongLength; i = i + 2)
            {
                if (buf[i] == 0)
                    charWidth = 1;
                else
                    charWidth = 2;

                bytePos = bytePos + charWidth;
            }

            return bytePos;
        }

        /// <summary>
        /// 날짜형식 반환 : 값이 없을 때 현재 날짜를 반환할지 공백을 반환할지 선택
        /// </summary>
        /// <param name="orgVal">원본 날짜</param>
        /// <param name="retType">1:yyyy-MM-dd, 2:yyyy-MM-dd HH:mm:ss</param>
        /// <param name="retNullYN">Y:공백 return, N:현재날짜 반환</param>
        /// <returns></returns>
        public static string ReturnDateTimeType(object orgVal, string retType, string retNullYN)
        {
            string retStr = "";
            DateTime orgDT;

            if (orgVal == null || orgVal.ToString() == "")
            {
                if (retNullYN.Equals("Y"))
                {
                    retStr = "null";
                }
                else
                {
                    if (retType.Equals("1"))    //yyyy-MM-dd
                        retStr = DateTime.Now.ToString("yyyy-MM-dd");
                    else
                        retStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            else
            {
                orgDT = Convert.ToDateTime(orgVal);

                if (retType.Equals("1"))    //yyyy-MM-dd
                {
                    retStr = orgDT.ToString("yyyy-MM-dd");
                }
                else
                {
                    retStr = orgDT.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }

            return retStr;
        }

        /// <summary>
        /// 공급원가 - 부가세를 뺀 금액
        /// </summary>
        /// <param name="amount">부가세 포함된 금액</param>
        /// <returns>double - 값</returns>
        public static double SupplyCost(Double amount)
        {
            double returnValue = 0D;

            if (amount == 0)
            {
                returnValue = 0;
            }
            else
            {
                double vat = (amount / 11);

                //절사
                vat = Math.Floor(vat);
                returnValue = amount - vat;
            }

            return returnValue;
        }

        /// <summary>
        /// 부가세
        /// </summary>
        /// <param name="amount">부가세 포함된 금액</param>
        /// <returns>double - 값</returns>
        public static double ValueAddTax(Double amount)
        {
            double returnValue = 0D;

            if (amount == 0)
            {
                returnValue = 0;
            }
            else
            {
                double vat = (amount / 11);

                //절사
                returnValue = Math.Floor(vat);
            }

            return returnValue;
        }

        /// <summary>
        /// INI읽기
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="IpAppName"></param>
        /// <param name="IpKeyName"></param>
        /// <returns></returns>
        public static string getIni(string fileName, string IpAppName, string IpKeyName)
        {
            string inifile = fileName;    //Path + File

            StringBuilder result = new StringBuilder(255);
            GetPrivateProfileString(IpAppName, IpKeyName, "error", result, 255, inifile);

            return result.ToString();

        }

        /// <summary>
        /// INI쓰기
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="IpAppName"></param>
        /// <param name="IpKeyName"></param>
        /// <param name="IpValue"></param>
        /// <returns></returns>
        public static Boolean setIni(string fileName, string IpAppName, string IpKeyName, string IpValue)
        {
            string inifile = fileName;    //Path + File
            WritePrivateProfileString(IpAppName, IpKeyName, IpValue, inifile);

            return true;
        }

        /// <summary>
        /// 오라클 쿼리문 중 IN절에 들어갈 문자열 생성
        /// </summary>
        /// <param name="arrStr">스트링 배열</param>
        /// <returns></returns>
        public static string MakeOracleQueryINStr(string[] arrStr)
        {
            string returnStr = "";

            if (arrStr == null || arrStr.Length == 0)
            {
                returnStr = "";
            }
            else
            {
                foreach (string str in arrStr)
                {
                    if (str != "")
                        returnStr += "'" + str + "',";
                }
                returnStr = returnStr.EndsWith(",") ? returnStr.Remove(returnStr.Length - 1) : returnStr;
            }

            return returnStr;
        }

        /// <summary>
        /// 입력된 값이 숫자인지 판단
        /// </summary>
        /// <param name="tableName">string - 키값</param>
        /// <returns>bool - 숫자여부</returns>
        public static bool CheckNumberTextBox(string keydata)
        {
            bool retVal = false;

            //0 : 96, 1 : 97, 2 : 98, 3 : 99, 4 : 100, 5 : 101, 6 : 102, 7 : 103, 8 : 104, 9 : 105, <- : 8, Del : 46, - : 109
            if (!(keydata == "48" || keydata == "49" || keydata == "50" || keydata == "51" || keydata == "52" ||
                  keydata == "53" || keydata == "54" || keydata == "55" || keydata == "56" || keydata == "57" || 
                  keydata == "8" || keydata == "96" || keydata == "97" || keydata == "98" || keydata == "99" ||
                  keydata == "100" || keydata == "101" || keydata == "102" || keydata == "103" || keydata == "104" ||
                  keydata == "105" || keydata == "46" || keydata == "109"))
            {
                retVal = false;
            }
            else
            {
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// 로딩폼 띄우기
        /// </summary>
        public static void ShowLoading()
        {
            Process[] process = Process.GetProcessesByName("SK.WMS.Loading");

            try
            {
                if (process.Length < 1)
                {
                    Process.Start("SK.WMS.Loading.exe");
                }
            }
            catch
            {
                //추후 처리..
            }
        }

        /// <summary>
        /// 로딩폼 죽이기
        /// </summary>
        public static void KillLoading()
        {
            Process[] process = Process.GetProcessesByName("SK.WMS.Loading");

            try
            {
                foreach (Process proc in process)
                {
                    proc.Kill();
                }
            }
            catch
            {
                //추후 처리..
            }
        }

        /// <summary>
        /// 8자리 스트링일자 하이픈 붙여서 리턴
        /// </summary>
        /// <param name="arrDate"></param>
        /// <returns></returns>
        public static string HyphenDate(string arrDate)
        {
            string returnStr = "";

            returnStr = arrDate.Substring(0, 4) + "-" + arrDate.Substring(4, 2) + "-" + arrDate.Substring(6, 2);

            return returnStr;
        }

        /// <summary>
        /// 텍스트박스 auto select
        /// </summary>
        /// <param name="sender">컨트롤</param>
        public static void AutoSelect(object sender)
        {
            if (sender.GetType().Name != "TextEdit") return;

            //TextEdit edit = sender as TextEdit;
            //edit.SelectAll();
        }

        /// <summary>
        /// 상품코드 받아서 0붙여서 18자리 만들기
        /// </summary>
        /// <param name="itmcd">상품코드</param>
        /// <returns></returns>
        public static string FullItmCd(string itmcd)
        {
            string returnStr = itmcd;
            int lenItm = itmcd.Length;

            for (int i = 0; i < 18 - lenItm; i++)
            {
                returnStr = "0" + returnStr;
            }

            return returnStr;
        }

        /// <summary>
        /// 상품코드 받아서 숫자로만 된경우 0을 삭제하여 6 또는 7자리 코드로 만든다
        /// </summary>
        /// <param name="itmcd">상품코드</param>
        /// <returns></returns>
        public static string DeleteItmCd(string itmcd)
        {
            string returnStr = itmcd;
            string returnStrCopy = "";
            int lenItm = itmcd.Length;
            int chk = 0;

            //for (int i = 0; i < lenItm; i++)
            //{
            //    char c = returnStr[i];

            //    if (!char.IsNumber(c))
            //    {
            //        return returnStr;
            //    }

            //    if (returnStr[i].ToString() != "0")
            //    {
            //        returnStrCopy = returnStrCopy + returnStr[i];
            //    }
            //}

            if (CheckDecimal(itmcd) == true)
            {
                for (int i = 0; i < lenItm; i++)
                {
                    if (itmcd.Substring(i, 1) != "0")
                    {
                        chk = i;
                        break;
                    }
                }
            }

            returnStrCopy = itmcd.Substring(11, lenItm - chk);

            returnStr = returnStrCopy.Trim();

            return returnStr;
        }

        /// <summary>
        /// 암호화
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string XorEnc(string code)
        {
            string retVal = "";
            int j = 0;

            //암호화 키
            byte[] keyChar = { 0x01, 0x03, 0x05, 0x07, 0x05, 0x03, 0x01, 0x09, 0x02 };

            //암호화할 대상
            byte[] codeChar = Encoding.UTF8.GetBytes(code);

            //XOR연산
            for (int i = 0; i < codeChar.Length; i++)
            {
                codeChar[i] = (byte)(codeChar[i] ^ keyChar[j]);
                j = ++j;
                j = (j < keyChar.Length) ? j : 0;
            }

            retVal = Convert.ToBase64String(codeChar);

            return retVal;
        }
    }
}
