using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace NEXCORE.Utility
{
    //<summary>
    //현재 설정된 Language List를 가져 오고, 관리 한다.
    //</summary>
    public class CultureResources
    {
        private static bool bFoundInstalledCultures = false;

        private static List<CultureInfo> pSupportedCultures = new List<CultureInfo>();
        /// <summary>
        /// List of available cultures, enumerated at startup
        /// </summary>
        public static List<CultureInfo> SupportedCultures
        {
            get
            {
                return new List<CultureInfo>()
            {
                new CultureInfo("ko-kr"),new CultureInfo("en-us")
            };

            }
        }

        public CultureResources()
        {
            if (!bFoundInstalledCultures)
            {
                //사용 가능한 Culture List를 가져온다.
                //CultureInfo tCulture = new CultureInfo("");
                //foreach (string dir in Directory.GetDirectories(Application.StartupPath))
                //{
                //    try
                //    {
                //        DirectoryInfo dirinfo = new DirectoryInfo(dir);
                //        tCulture = CultureInfo.GetCultureInfo(dirinfo.Name);

                //        if (dirinfo.GetFiles(Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".resources.dll").Length > 0)
                //        {
                //            pSupportedCultures.Add(tCulture);
                //        }
                //    }
                //    catch (ArgumentException) //ignore exceptions generated for any unrelated directories in the bin folder
                //    {
                //    }
                //}

                //TODO: 우선 강제로 한글과 영어를 세팅 할 수 있게 한다. 차후 File에서 동적으로 읽어 올수 있도록 위 주석을 해제한다.

                pSupportedCultures.Add(new CultureInfo("ko-kr"));
                pSupportedCultures.Add(new CultureInfo("en-us"));
                bFoundInstalledCultures = true;
            }
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public Properties.Resources GetResourceInstance()
        //{
        //    return new Properties.Resources();
        //}

        //private static ObjectDataProvider m_provider;
        //public static ObjectDataProvider ResourceProvider
        //{
        //    get
        //    {
        //        if (m_provider == null)
        //            m_provider = (ObjectDataProvider)App.Current.FindResource("Resources");
        //        return m_provider;
        //    }
        //}

        /// <summary>
        /// Change the current culture used in the application.
        /// If the desired culture is available all localized elements are updated.
        /// </summary>
        /// <param name="culture">Culture to change to</param>
        //public static void ChangeCulture(CultureInfo culture)
        //{
        //    remain on the current culture if the desired culture cannot be found
        //     - otherwise it would revert to the default resources set, which may or may not be desired.
        //    if (pSupportedCultures.Contains(culture))
        //    {
        //        Properties.Resources.Culture = culture;
        //        ResourceProvider.Refresh();
        //    }
        //    else
        //        Debug.WriteLine(string.Format("Culture [{0}] not available", culture));
        //}
    }
}