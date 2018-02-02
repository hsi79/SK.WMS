using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Timers;
using System.Diagnostics;

using System.Windows.Threading;

namespace NEXCORE.Components.ComponentManager
{
    //public class AppDomainMgr
    //{
    //    private static int MAX_MANAGER_LENGTH = 0;

    //    private static AppDomain mainAppDomain = null;
    //    private static AppDomain[] AppDomainQueue = null;

    //    private static ComponentManager mainCmpMgr = null;
    //    private static ComponentManager[] CmpMgrQueue = null;

    //    // 0 - 1 - 2 - 0 - 1 - 2 - 0 - 1 - 2 - ...
    //    private static int curMgrIdx = 0;

    //    private const string COMPONENT_MANAGER_NAME = "NEXCORE.Components.ComponentManager.dll";
    //    private static FileSystemWatcher _watcherFileSystem;
    //    private const string COMPONENT_POOL_PATH = "COMPONENT_POOL_PATH";
    //    /// <summary>
    //    /// Create new appDomain & componentManager & Unload previous one 20 mins later
    //    /// </summary>
    //    public static void UnLoadComponentDomain()
    //    {
    //        // Create new AppDomain & switch with old one
    //        // Authority should be assigned to system administrator to maintain system stability
    //        // but, can reload under MAX_MANAGER_LENGTH times at the same (need more test)
    //        curMgrIdx++;
    //        if (curMgrIdx >= MAX_MANAGER_LENGTH)
    //        {
    //            // 0 - 1 - 2 - 0 - 1 - 2 - 0 - 1 - 2 - ...
    //            curMgrIdx = 0;
    //        }
    //        CreateNewCmpMgr();
    //    }

    //    /// <summary>
    //    /// 새로 생성된 도메인에서 ComponentMgr을 반환 한다.
    //    /// </summary>
    //    /// <returns>Component Manager</returns>
    //    public static ComponentManager GetComponentMgr()
    //    {
    //        if (_watcherFileSystem == null)
    //        {

    //            string path = Skcc.Configuration.SkccFxConfigManager.GetString(COMPONENT_POOL_PATH);

    //            //현재 폴더에서 Dll을 찾는다.
    //            if (string.IsNullOrEmpty(path))
    //            {
    //                path = ".";
    //            }


    //            //파일 시스템 감시를 위한 Watcher 초기화
    //            _watcherFileSystem = new FileSystemWatcher(path);
    //            _watcherFileSystem.Changed += new FileSystemEventHandler(_watcherFileSystem_Changed);
    //            _watcherFileSystem.EnableRaisingEvents = true;
    //            _watcherFileSystem.IncludeSubdirectories = true;

    //        }
    //        if (mainAppDomain == null)
    //        {
    //            // 최초 로딩하는 시점.
    //            curMgrIdx = 0;

    //            int number = -1;
    //            try
    //            {
    //                number = Skcc.Configuration.SkccFxConfigManager.GetInt32("APPDOMAIN_POOL_COUNT");
    //            }
    //            catch { }

    //            MAX_MANAGER_LENGTH = (number <= 0) ? 3 : number;
    //            AppDomainQueue = new AppDomain[MAX_MANAGER_LENGTH];
    //            CmpMgrQueue = new ComponentManager[MAX_MANAGER_LENGTH];
    //            CreateNewCmpMgr();

    //        }
    //        return mainCmpMgr;
    //    }

    //    private static AppDomain CreateNewAppDomain()
    //    {

    //        AppDomain appDomain = null;
    //        try
    //        {
    //            //도메인 명은 임시 유일한 값으로 설정한다.
    //            string strDomainName = string.Format("{0}{1}{2}{3}{4}{5}_{6}", DateTime.Now.Year.ToString(),
    //                                                                        DateTime.Now.Month.ToString().PadLeft(2, '0'),
    //                                                                        DateTime.Now.Day.ToString().PadLeft(2, '0'),
    //                                                                        DateTime.Now.Hour.ToString().PadLeft(2, '0'),
    //                                                                        DateTime.Now.Minute.ToString().PadLeft(2, '0'),
    //                                                                        DateTime.Now.Second.ToString().PadLeft(2, '0'),
    //                                                                        Guid.NewGuid().ToString());

    //            AppDomainSetup ads = new AppDomainSetup();

    //            ads.ApplicationBase = AppDomain.CurrentDomain.RelativeSearchPath;
    //            ads.ConfigurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

    //            string domainFolder = Skcc.Configuration.SkccFxConfigManager.GetString("SHADOW_COPY_CACHE_PATH");
    //            // If not exist, create 'AppDomainCache' folder
    //            if (!Directory.Exists(domainFolder))
    //                Directory.CreateDirectory(domainFolder);

    //            ads.CachePath = string.Format(@"{0}\{1}", domainFolder, strDomainName);
    //            ads.ApplicationName = "NEXCORE.Domain";
    //            ads.ShadowCopyFiles = "true";

    //            NEXCORE.Utility.UtilityHelper.WriteLog("AppDomainSetup : ApplicationBase : " + ads.ApplicationBase, Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Information);
    //            NEXCORE.Utility.UtilityHelper.WriteLog("AppDomainSetup : ConfigurationFile : " + ads.ConfigurationFile, Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Information);
    //            NEXCORE.Utility.UtilityHelper.WriteLog("AppDomainSetup : CachePath : " + ads.CachePath, Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Information);
    //            NEXCORE.Utility.UtilityHelper.WriteLog("AppDomainSetup : ApplicationName : " + ads.ApplicationName, Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Information);
    //            NEXCORE.Utility.UtilityHelper.WriteLog("AppDomainSetup : ShadowCopyFiles : " + ads.ShadowCopyFiles, Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Information);
    //            NEXCORE.Utility.UtilityHelper.WriteLog("AppDomainSetup : FriendlyName : " + strDomainName, Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Information);

    //            appDomain = AppDomain.CreateDomain(strDomainName, null, ads);

    //            // Delete old appDomains - manage within (APPDOMAIN_POOL_COUNT + 1) EAs
    //            DirectoryInfo[] dirInfo = new DirectoryInfo(domainFolder).GetDirectories();

    //            int appDomainNumber = Skcc.Configuration.SkccFxConfigManager.GetInt32("APPDOMAIN_POOL_COUNT");
    //            // 2 * appDomainNumber : because of External Interface (use NETWORK SERVICE Procee ID - Same IIS applicaion's home directory)
    //            int toDelNumber = dirInfo.Length - (2 * appDomainNumber);
    //            if (toDelNumber > 0)
    //            {
    //                // Remain current (APPDOMAIN_POOL_COUNT + 1) EAs
    //                foreach (DirectoryInfo di in dirInfo)
    //                {
    //                    if (toDelNumber-- <= 0)
    //                        break;
    //                    di.Delete(true);
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            string msg = NEXCORE.Utility.UtilityHelper.GetFinalInnerException(ex).Message;
    //            Debug.WriteLine(msg);
    //            NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Critical);
    //        }

    //        return appDomain;
    //    }

    //    private static void CreateNewCmpMgr()
    //    {

    //        // Unload very old one
    //        if (AppDomainQueue[curMgrIdx] != null)
    //        {
    //            AppDomain.Unload(AppDomainQueue[curMgrIdx]);
    //            AppDomainQueue[curMgrIdx] = null;
    //            CmpMgrQueue[curMgrIdx] = null;
    //        }

    //        // 2. Component Manager 생성
    //        //      2.1 Component Manager의 경로는 IIS에서 실행 될 경우 IIS의 Bin
    //        //          Local에서 실행 될 경우, Portal UI가 실행 되는 폴더로 될 것으로 예상.ㅋ
    //        string strCmpManagerPath = string.Empty;
    //        if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("ServiceTarget"))
    //            strCmpManagerPath = Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath, COMPONENT_MANAGER_NAME);
    //        else
    //            strCmpManagerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, COMPONENT_MANAGER_NAME);

    //        //      2.2 Component Manager 생성 
    //        //          반환 된 Component Manager는 새로 생성된 AppDomain에서 동작 된다.
    //        //          따라서 _cmpManager는 MarshaByRefObj를 상속 받아야 한다.(.NET Remoting)
    //        AppDomain newDomain = CreateNewAppDomain();
    //        if (newDomain != null)
    //        {
    //            ComponentManager cmpMgr = (ComponentManager)newDomain.CreateInstanceFromAndUnwrap(
    //                                                    strCmpManagerPath,
    //                                                    typeof(ComponentManager).FullName);
    //            cmpMgr.Initilize();
    //            cmpMgr.Setup();

    //            AppDomainQueue[curMgrIdx] = newDomain;
    //            CmpMgrQueue[curMgrIdx] = cmpMgr;

    //            mainAppDomain = newDomain;
    //            mainCmpMgr = cmpMgr;
    //        }
    //    }

    //    static void _watcherFileSystem_Changed(object sender, FileSystemEventArgs e)
    //    {
    //        UnLoadComponentDomain();


    //    }
    //}

    public class AppDomainMgr
    {
        private static int MAX_MANAGER_LENGTH = 3;

        private static AppDomain mainAppDomain = null;

        private static ComponentManager mainCmpMgr = null;

        // 0 - 1 - 2 - 0 - 1 - 2 - 0 - 1 - 2 - ...
        private static int curMgrIdx = 0;

        private const string COMPONENT_MANAGER_NAME = "NEXCORE.Components.ComponentManager.dll";

        private static FileSystemWatcher fsw = new FileSystemWatcher();
        private static int interval = 10000;//Skcc.Configuration.SkccFxConfigManager.TryGetInt32("COMPONENT_POOL_RELOAD_TIME") * 1000;
        private static Timer oneMinTimer = new Timer(interval);

        private static string domainFolder = Skcc.Configuration.SkccFxConfigManager.GetString("SHADOW_COPY_CACHE_PATH");
        private static int maxCount = Convert.ToInt32(Skcc.Configuration.SkccFxConfigManager.GetString("APPDOMAIN_POOL_COUNT"));

        //private static Dictionary<AppDomain, ComponentManager> dicAppDomain = new Dictionary<AppDomain, ComponentManager>();
        //private static List<string> AppDomainDirList = new List<string>();

        /// <summary>
        /// 기존 AppDomain을 내리고, 새로운 객체를 생성하여 바인딩한다.
        /// </summary>
        //public static void UnLoadComponentDomain()
        //{
        //    foreach (AppDomain key in dicAppDomain.Keys)
        //    {
        //        if (key != null)
        //        {
        //            string folder = key.SetupInformation.CachePath;
        //            DirectoryInfo dirInfo = new DirectoryInfo(folder);
        //            Directory.Delete(folder, true);
        //            //DeleteOldAppDomainCache(dirInfo);
        //            //dirInfo.Delete(true);

        //            dicAppDomain[key] = null;
        //        }
        //    }

        //    AppDomain[] toDelete = new AppDomain[dicAppDomain.Count];
        //    for (int k = 0; k < dicAppDomain.Count; k++)
        //        dicAppDomain.Remove(toDelete[k]);
        //}

        /// <summary>
        /// 새로 생성된 도메인에서 ComponentMgr을 반환 한다.
        /// </summary>
        /// <returns>Component Manager</returns>
        public static ComponentManager GetComponentMgr()
        {
            try
            {
                if (mainAppDomain == null)
                {
                    // 최초 로딩하는 시점.
                    curMgrIdx = 0;

                    int number = -1;
                    number = Skcc.Configuration.SkccFxConfigManager.GetInt32("APPDOMAIN_POOL_COUNT");
                    MAX_MANAGER_LENGTH = (number <= 0) ? 3 : number;

                    CreateNewCmpMgr();

                    // Add FileSystemWatcher
                    fsw.Path = Skcc.Configuration.SkccFxConfigManager.TryGetString("COMPONENT_POOL_PATH");
                    fsw.Changed += new FileSystemEventHandler(fsw_Changed);
                    fsw.EnableRaisingEvents = true;
                    fsw.IncludeSubdirectories = false;

                    oneMinTimer.Enabled = false;
                    oneMinTimer.Elapsed += new ElapsedEventHandler(oneMinTimer_Elapsed);
                }
            }
            catch (Exception ex)
            {
                string msg = NEXCORE.Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Debug.WriteLine(msg);
                NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Critical);
            }

            return mainCmpMgr;
        }

        static void oneMinTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            oneMinTimer.Enabled = false;
            oneMinTimer.Stop();

            //UnLoadComponentDomain();
            CreateNewCmpMgr();
        }

        /// <summary>
        /// Event occurs when the file is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            //CommonHelper.WriteLog(LogTypes.LogAppender.FWKLogger, LogTypes.LogLevel.Debug, "fsw_Changed", null);
            if (!oneMinTimer.Enabled)
            {
                oneMinTimer.Enabled = true;
                oneMinTimer.Start();
            }
        }

        /// <summary>
        /// Delete old application domain cache
        /// </summary>
        /// <param name="dirInfo"></param>
        private static void DeleteOldAppDomainCache(DirectoryInfo dirInfo)
        {
            try
            {
                DirectoryInfo[] dInfo = dirInfo.GetDirectories();

                if (dInfo.Length <= 0)
                {
                    //NEXCORE.Utility.CommonHelper.WriteLog(string.Format("\tDelete application domain cache [{0}]", dirInfo.FullName),
                    //                                         NEXCORE.Utility.CommonHelper.eLogCategory.AppDomain, TraceEventType.Information);
                    //FileInfo[] files = dirInfo.GetFiles();
                    //foreach (FileInfo f in files)
                    //{
                    //    f.Delete();
                    //    //if (f.IsReadOnly)
                    //    //    f.IsReadOnly = false;
                    //}
                    dirInfo.Delete(true);
                }

                foreach (DirectoryInfo d in dInfo)
                    DeleteOldAppDomainCache(d);
            }
            catch (Exception ex)
            {
                string msg = NEXCORE.Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Debug.WriteLine(msg);
                NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Critical);
            }
        }

        /// <summary>
        /// Create new application domain
        /// </summary>
        /// <returns></returns>
        private static AppDomain CreateNewAppDomain()
        {
            AppDomain appDomain = null;
            try
            {
                //도메인 명은 임시 유일한 값으로 설정한다.
                string strDomainName = string.Format("{0}{1}{2}_{3}{4}{5}_{6}", DateTime.Now.Year.ToString(),
                                                                                DateTime.Now.Month.ToString().PadLeft(2, '0'),
                                                                                DateTime.Now.Day.ToString().PadLeft(2, '0'),
                                                                                DateTime.Now.Hour.ToString().PadLeft(2, '0'),
                                                                                DateTime.Now.Minute.ToString().PadLeft(2, '0'),
                                                                                DateTime.Now.Second.ToString().PadLeft(2, '0'),
                                                                                Guid.NewGuid().ToString());
                AppDomainSetup ads = new AppDomainSetup();

                ads.ApplicationBase = AppDomain.CurrentDomain.RelativeSearchPath;
                ads.ConfigurationFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

                string domainFolder = Skcc.Configuration.SkccFxConfigManager.GetString("SHADOW_COPY_CACHE_PATH");
                // If not exist, create 'AppDomainCache' folder
                if (!Directory.Exists(domainFolder))
                    Directory.CreateDirectory(domainFolder);

                ads.CachePath = string.Format(@"{0}\{1}", domainFolder, strDomainName);
                ads.ApplicationName = "NEXCORE.Domain";
                ads.ShadowCopyFiles = "true";

                appDomain = AppDomain.CreateDomain(strDomainName, null, ads);
            }
            catch (Exception ex)
            {
                string msg = NEXCORE.Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Debug.WriteLine(msg);
                NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Critical);
            }

            return appDomain;
        }

        /// <summary>
        /// Create new component manager
        /// </summary>
        private static void CreateNewCmpMgr()
        {
            try
            {
                // 2. Component Manager 생성
                //      2.1 Component Manager의 경로는 IIS에서 실행 될 경우 IIS의 Bin
                //          Local에서 실행 될 경우, Portal UI가 실행 되는 폴더로 될 것으로 예상.ㅋ
                //string strCmpManagerPath = Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath, COMPONENT_MANAGER_NAME);

                string strCmpManagerPath = string.Empty;
                if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("ServiceTarget"))
                    strCmpManagerPath = Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath, COMPONENT_MANAGER_NAME);
                else
                    strCmpManagerPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, COMPONENT_MANAGER_NAME);

                //      2.2 Component Manager 생성 
                //          반환 된 Component Manager는 새로 생성된 AppDomain에서 동작 된다.
                //          따라서 _cmpManager는 MarshaByRefObj를 상속 받아야 한다.(.NET Remoting)
                AppDomain newDomain = CreateNewAppDomain();
                if (newDomain != null)
                {
                    ComponentManager cmpMgr = (ComponentManager)newDomain.CreateInstanceFromAndUnwrap(
                                                            strCmpManagerPath,
                                                            typeof(ComponentManager).FullName);
                    cmpMgr.Initilize();
                    cmpMgr.Setup();

                    AppDomain tempAppDomain = mainAppDomain;
                    ComponentManager tempCompMgr = mainCmpMgr;

                    mainAppDomain = newDomain;
                    mainCmpMgr = cmpMgr;

                    if (tempAppDomain != null)
                    {
                        AppDomain.Unload(tempAppDomain);
                        tempAppDomain = null;
                    }
                    if (tempCompMgr != null)
                        tempCompMgr = null;

                    DirectoryInfo[] baseDirInfo = new DirectoryInfo(domainFolder).GetDirectories();

                    for (int k = baseDirInfo.Length, j = 0; k >= maxCount; k--, j++)
                        Directory.Delete(baseDirInfo[j].FullName, true);

                    //bool isFound = false;
                    //if (baseDirInfo.Length >= maxCount)
                    //{
                    //    foreach (DirectoryInfo d in baseDirInfo)
                    //    {
                    //        if (AppDomainDirList.Contains(d.FullName))
                    //        {
                    //            isFound = true;
                    //            Directory.Delete(d.FullName, true);
                    //            AppDomainDirList.Remove(d.FullName);
                    //            break;
                    //        }
                    //    }

                    //    if (!isFound)
                    //        Directory.Delete(baseDirInfo[0].FullName, true);
                    //}

                    ////dicAppDomain.Add(mainAppDomain, mainCmpMgr);
                    //AppDomainDirList.Add(mainAppDomain.SetupInformation.CachePath);
                }
            }
            catch (Exception ex)
            {
                string msg = NEXCORE.Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Debug.WriteLine(msg);
                NEXCORE.Utility.UtilityHelper.WriteLog(msg, NEXCORE.Utility.UtilityHelper.eLogCategory.Framework, TraceEventType.Critical);
            }
        }
        /// <summary>
        /// Create new appDomain & componentManager & Unload previous one 20 mins later
        /// </summary>
        public static void UnLoadComponentDomain()
        {
            // Create new AppDomain & switch with old one
            // Authority should be assigned to system administrator to maintain system stability
            // but, can reload under MAX_MANAGER_LENGTH times at the same (need more test)
            curMgrIdx++;
            if (curMgrIdx >= MAX_MANAGER_LENGTH)
            {
                // 0 - 1 - 2 - 0 - 1 - 2 - 0 - 1 - 2 - ...
                curMgrIdx = 0;
            }
            CreateNewCmpMgr();
        }
    }
}
