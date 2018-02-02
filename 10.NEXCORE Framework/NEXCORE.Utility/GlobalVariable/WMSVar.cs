using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Skcc.Configuration;

namespace NEXCORE.Utility.GlobalVariable
{
    public static class WMSVar
    {


        public static Dictionary<string, NEXCORE.Common.Data.NEXCOREData> dicDataList = new Dictionary<string,Common.Data.NEXCOREData>(); 

        //날씨관련
        //public static string WeatherURL = SkccFxConfigManager.TryGetString("WeatherURL");

        public static string FT = "Malgun Gothic";
        public static string FTNAME = "맑은고딕";

        public static string MSG = "Control";
        public static string MSGNAME = "기본색";

        public static string TH = "Gray";
        public static bool LoginPath = true; // 정상적 로그인 false 화면에서 멀티 로그인 실행

        public static System.Drawing.Color Backcol = System.Drawing.Color.WhiteSmoke;
        public static System.Drawing.Color Forecol = System.Drawing.Color.DimGray;


    }
}
