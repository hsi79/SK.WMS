using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;

using NEXCORE.Service.ServiceManager;
using System.Reflection;
using System.Data;
using System.IO;
using NEXCORE.Components.ComponentManager;
using NEXCORE.Utility;
using System.Diagnostics;
using SK.WMS.Launcher;
using NEXCORE.Utility.GlobalVariable;
using NEXCORE.Common.Helper;
using System.Runtime.InteropServices;
using NEXCORE.Common.Data;

namespace NEXCORE.Common
{
    public class UIInterface : IUserInterface
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        NEXCORE.Service.ServiceManager.ServiceLoader myService = new NEXCORE.Service.ServiceManager.ServiceLoader();
        private Dictionary<string, ReceiveMessage> _ChildEventHandlerList = new Dictionary<string, ReceiveMessage>();

        Dictionary<Menu, Program> dicMenuProgramList = new Dictionary<Menu, Program>();
        Dictionary<string, object> dicProgramContentList = new Dictionary<string, object>();


        public event BroadCast OnBroadCast;
        //public event ToolBarEvent OnToolBarClick;

        //MainForm mf;
        private static UIInterface _userInterface;
        private static IUserInterface _IUserInterface;

        public User CurrentUser { get; set; }
        public Program CurrentProgram { get; set; }

        public string CurrentApplicationPath { get; set; }
        public Program GetCurrentProgram()
        {
            return this.CurrentProgram;
        }
        #region Event Publishing
        public void Broadcast(object sender , BroadCastEventArgs args)
        {
            if (this.OnBroadCast != null)
                OnBroadCast(this, args);
        }

        public void SendMessage(string pgmId, NEXCORE.Common.Data.NEXCOREData e)
        {

            if (WMSVar.dicDataList.ContainsKey(pgmId))
            {
                WMSVar.dicDataList.Remove(pgmId);
            }
            WMSVar.dicDataList.Add(pgmId, e);

            if (this._ChildEventHandlerList.ContainsKey(pgmId))
            {
                ReceiveMessage msgHandler = this._ChildEventHandlerList[pgmId];
                msgHandler.Invoke(this, e);
            }
        }

        private void SendMessageResult(IAsyncResult ret)
        {
            CommonHelper.WriteLog("Send Message Success!");
        }
        #endregion

        #region Form Event 등록

        public void AddChildFormEvent(string pgmId, ReceiveMessage del)
        {
            if (!_ChildEventHandlerList.ContainsKey(pgmId))
            {
                _ChildEventHandlerList.Add(pgmId, del);
            }
        }

        public void RemoveChildFormEvent(string pgmId)
        {
            if (_ChildEventHandlerList.ContainsKey(pgmId))
            {
                _ChildEventHandlerList.Remove(pgmId);
            }
        }

        public void AddBroadCastEvent(BroadCast broadcastHandler)
        {
            this.OnBroadCast += broadcastHandler;

        }

        #endregion

        #region 사용자 인터페이스 노출


        
        public static UIInterface This()
        {
            if (_userInterface == null)
                _userInterface = new UIInterface();
            return _userInterface;
        }

        public static void SetUIInterface(IUserInterface iUserInterface)
        {
            _IUserInterface = iUserInterface;
        }

        public static IUserInterface GetUIInterface()
        {
            return _IUserInterface;
        }

        #endregion

        #region 초기화 및 생성자


        public UIInterface()
        {
            
        }

        protected void Initialize()
        {
            
        }
        #endregion

        #region IUserInterface 멤버

        public bool ShowAlert(eAlertTypes type, string message)
        {
            
            
            return false;
        }
        public void SendMessage(List<string> pgmIds, NEXCOREData data)
        {
            foreach (string pgmId in pgmIds)
            {
                this.SendMessage(pgmId, data);
            }
        }




        public bool CheckProgramAuthority(string pgmId)
        {
            User user = this.GetCurrentUser();
            List<Menu> lstMenu = null;
            try
            {
                lstMenu = MenuServiceProxy.GetAllMenuList(user.UserId,"");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            var varMenu = from m in lstMenu
                          where m.PgmId == pgmId
                          select m;

            if (varMenu != null && varMenu.Count() > 0)
                return true;

            return false;
        }

        public Menu GetMenu(string pgmId, string sysid)
        {
            User user = this.GetCurrentUser();


            List<Menu> lstMenu = MenuServiceProxy.GetAllMenuList(user.UserId,sysid);

            var varMenu = from m in lstMenu
                          where m.PgmId == pgmId
                          select m;

            if (varMenu != null && varMenu.Count() > 0)
            {
                return varMenu.First<Menu>();
            }

            return null;
        }

        public System.Windows.Forms.DialogResult ShowWindowsDialog(string pgmId, object form, NEXCOREData param)
        {
            string strMessage = string.Empty;

            object formObj = GetNewFormInstance(pgmId,ref strMessage);

             if (formObj is SKDialogBase)
            {
                SKDialogBase winDialog = formObj as SKDialogBase;
                //winDialog.MdiParent = 
                winDialog.FormInterface = this;
                winDialog.ThisProgram = CommonManager.GetProgram(pgmId);
                winDialog.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                winDialog.Data = param;
                return winDialog.ShowDialog();
            }

            return System.Windows.Forms.DialogResult.Abort;
        }

        public Object GetNewFormInstance(string pgmId, ref string strResultMessage)
        {

            var varPgm = from p in dicMenuProgramList.Values
                         where p.PgmId == pgmId
                         select p;

            if (varPgm != null && varPgm.Count() > 0)
            {
                return true;
            }

            Program pgm = ProgramServiceProxy.GetProgram(pgmId);
            Menu menu = GetMenu(pgmId,"");

            Assembly asm = null;

            try
            {
                string path = Path.Combine(UIInterface.This().CurrentApplicationPath, pgm.PgmPath);
                asm = Assembly.LoadFrom(path);
            }
            catch(Exception ex)
            {
                strResultMessage = ex.Message + pgm.PgmPath + "에서 화면을 다운 로드 할 수 없습니다.";
                return false;
            }

            //  use type name to get type from asm; note we WANT case specificity 

            Type typeInfo = null; ;

            try
            {
                typeInfo = asm.GetType(pgm.PgmName, true, false);
            }
            catch (Exception ex)
            {
                strResultMessage = ex.ToString();
                return false;
            }

            if (typeInfo == null)
                return false;

            object formInstance = null;

            try
            {
                formInstance = Activator.CreateInstance(typeInfo);

            }
            catch(Exception ex)
            {
                strResultMessage = ex.InnerException.Message + "화면을 다운 로딩 할 수 없습니다. 관리자에게 문의 하십시요";
                return false;
            }
            return formInstance;
        }

        public bool LoadForm(SKUserControlBase form, string pgmId, ref string strResultMessage)
        {
            //if (!CheckProgramAuthority(pgmId))
            //{
            //    //권한이 없는 경우
            //    string msg = CommonManager.GetMessage("0107");
            //    strResultMessage = string.Format(msg, pgmId);

            //    return false;
            //}


            Program pgm = ProgramServiceProxy.GetProgram(pgmId);
            Menu menu = GetMenu(pgmId, "");

            MainForm main = (MainForm)form.ParentForm;



            try
            {
                main.CreateTabPage(menu, pgm);

            }
            catch (Exception ex)
            {
                strResultMessage = ex.Message + pgm.PgmPath + "에서 화면을 다운 로드 할 수 없습니다.";
                return false;
            }
            this.dicMenuProgramList.Add(menu, pgm);

            this.CurrentProgram = pgm;


            //object wincontrol = null;
            //this.dicProgramContentList.Remove(pgm.PgmId);
            //this.dicProgramContentList.Add(pgm.PgmId, wincontrol);
            

            return true;
        }
        

        public void LoadNavigationMenu()
        {
            User user = this.GetCurrentUser();

            List<Menu> menuList = MenuServiceProxy.GetNavagatorMenu(user.UserId);


        }

        public void LoadNavigationMenu(string userId)
        {
            User user = UserServiceProxy.GetUser(userId);
            
            List<Menu> menuList = MenuServiceProxy.GetNavagatorMenu(user.UserId);


        }
        
        public void Logout()
        {
            throw new NotImplementedException();
        }

        public LOGIN_RESULT_CODE Login(string userId, string password)
        {
            return UserServiceProxy.Login(userId, password);
        }

        public User GetCurrentUser()
        {
            return CurrentUser;
        }

        public void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }



        /// <summary>
        /// Invoke Front Service's Specific Business Logic
        /// </summary>
        /// <param name="typeString"></param>
        /// <param name="methodName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public NEXCOREData InvokeService(string typeString, string methodName, NEXCOREData paras)
        {
            if (Skcc.Configuration.SkccFxConfigManager.TryGetBoolean("ServiceTarget"))
            {
                if (paras != null && paras.DataTable != null && string.IsNullOrEmpty(paras.DataTable.TableName))
                {
                    paras.DataTable.TableName = "TempTable";
                }

                NEXCOREData retData = null;

                User user = this.GetCurrentUser();
                //string msg = string.Format("UIInterface.InvokeFunction : {0} / {1}", typeString, methodName);
                //string paramLog = UtilityHelper.WriteNEXCOREDataLog(string.Format("Start - {0}", msg), paras);
                //UtilityHelper.WriteLog(paramLog, UtilityHelper.eLogCategory.Component, TraceEventType.Information);

                DateTime startTime = DateTime.Now;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                try
                {
                    // Invoke biz-specific method
                    retData = ServiceLoader.Invoke(typeString, methodName, paras);
                    
                    sw.Stop();

                    // Insert into THISCOMP with success value
                    //tempData = CommonManager.HistoryComponents(user.UserId, typeString, methodName, startTime, DateTime.Now,
                     //                                          Convert.ToInt32(sw.ElapsedMilliseconds), paramLog, CommonManager.InvokeState.Success.ToString());
                }
                catch 
                {
                    sw.Stop();
                    // Insert into THISCOMP with success value
                    //tempData = CommonManager.HistoryComponents(user.UserId, typeString, methodName, startTime, System.DateTime.Now,
                     //                                          Convert.ToInt32(sw.ElapsedMilliseconds), UtilityHelper.GetFinalInnerException(ex).Message, CommonManager.InvokeState.Fail.ToString());
                }

                //UtilityHelper.WriteLog(string.Format("End - {0} : {1}", msg, sw.Elapsed.ToString()), UtilityHelper.eLogCategory.Component, TraceEventType.Information);

                return retData;
            }
            else
            {
                ComponentManager cmMgr = AppDomainMgr.GetComponentMgr();
                NEXCOREData retValue = cmMgr.InvokeFunction(typeString, methodName, paras);

                return retValue;
            }
        }

        /// <summary>
        /// Invoke Front Service's Specific Business Logic with Transaction Service
        /// </summary>
        /// <param name="typeString"></param>
        /// <param name="methodName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public NEXCOREData InvokeTransactionService(string typeString, string methodName, NEXCOREData paras)
        {
            if (Skcc.Configuration.SkccFxConfigManager.TryGetBoolean("ServiceTarget"))
            {
                if (paras != null && paras.DataTable != null && string.IsNullOrEmpty(paras.DataTable.TableName))
                {
                    paras.DataTable.TableName = "TempTable";
                }

                NEXCOREData retData = null;

                User user = this.GetCurrentUser();
                //string msg = string.Format("UIInterface.InvokeTransactionFunction : {0} / {1}", typeString, methodName);
                //string paramLog = UtilityHelper.WriteNEXCOREDataLog(string.Format("Start - {0}", msg), paras);
                //UtilityHelper.WriteLog(paramLog, UtilityHelper.eLogCategory.Component, TraceEventType.Information);

                DateTime startTime = DateTime.Now;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                try
                {
                    // Invoke biz-specific method
                    retData = ServiceLoader.InvokeTransaction(typeString, methodName, paras);

                    sw.Stop();

                    // Insert into THISCOMP with success value
                    //tempData = CommonManager.HistoryComponents(user.UserId, typeString, methodName, startTime, DateTime.Now,
                    //                                           Convert.ToInt32(sw.ElapsedMilliseconds), paramLog, CommonManager.InvokeState.Success.ToString());
                }
                catch 
                {
                    sw.Stop();
                    // Insert into THISCOMP with success value
                    //tempData = CommonManager.HistoryComponents(user.UserId, typeString, methodName, startTime, System.DateTime.Now,
                    //                                           Convert.ToInt32(sw.ElapsedMilliseconds), UtilityHelper.GetFinalInnerException(ex).Message, CommonManager.InvokeState.Fail.ToString());
                }

                //UtilityHelper.WriteLog(string.Format("End - {0} : {1}", msg, sw.Elapsed.ToString()), UtilityHelper.eLogCategory.Component, TraceEventType.Information);

                return retData;
            }
            else
            {
                ComponentManager cmMgr = AppDomainMgr.GetComponentMgr();
                NEXCOREData retValue = cmMgr.InvokeTransactionFunction(typeString, methodName, paras);

                return retValue;
            }
        }

        public void UnloadAppDomain()
        {
            // Issue #38. Brian Kwon - 2010.04.20
            ServiceLoader.UnloadAppDomain();
        }

        public bool InvokeServiceAsync(string typeString, string methodName, NEXCOREData paras, Delegate asyncResult)
        {
            return ServiceLoader.InvokeAsync(typeString, methodName, paras, asyncResult);
        }

        public int ExecuteNonquery(string spName, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet ExecuteDataSet(string spName, params object[] parameters)
        {
            throw new NotImplementedException();
        }



        #endregion


        public void WriteStatusBar(SKUserControlBase form ,string msg)
        {
            MainForm main = (MainForm)form.ParentForm;

            main.WriteStatusBar(msg);
        }       
        #region Contents 관리

        public void SetCurrentProgram(Program pgm)
        {
            if (pgm != null)
            {
                this.CurrentProgram = pgm;
            }
        }

        public ISKBase GetCurrentContent(string pgmId)
        {
            try
            {
                if (dicProgramContentList.ContainsKey(pgmId))
                {
                    return dicProgramContentList[pgmId] as ISKBase;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        #endregion
        
        #region SK Control Event Management

        public void AddChildControlEventHandler(string pProgramID, System.Windows.Forms.Control pControl)
        {

                string keyString = pProgramID + "_" +  pControl.Name;
                if (_controlList.ContainsKey(keyString) == false)
                {
                    _controlList.Add(keyString, pControl);
                }
                else
                {
                    _controlList.Remove(keyString);
                    _controlList.Add(keyString, pControl);
                }
        }

        #endregion

        #region Validation Check

        private Dictionary<string, System.Windows.Forms.Control> _controlList = new Dictionary<string, System.Windows.Forms.Control>();

        public System.Windows.Forms.Control GetSKControl(string pgmId, string controlName)
        {
            string keyString = _controlList.Keys.First<string>(str => str.StartsWith(pgmId + "_") && str.EndsWith("_" + controlName));
            if (_controlList.ContainsKey(keyString))
            {
                return _controlList[keyString];
            }
            return null;
        }

        public List<System.Windows.Forms.Control> GetSKControls(string pgmId)
        {
            List<System.Windows.Forms.Control> retValue = new List<System.Windows.Forms.Control>();

                string conditionString = pgmId + "_";
                List<string> keyList = _controlList.Keys.Where
                    (keyStr => keyStr.Contains(conditionString)).ToList<string>();
                
                foreach (string key in keyList)
                {
                    retValue.Add(_controlList[key]);
                }

            return retValue;
        }

        public Dictionary<System.Windows.Forms.Control, string> GetMandatoryControls(string pgmId)
        {
            List<System.Windows.Forms.Control> skControlList = GetSKControls(pgmId);
            Dictionary<System.Windows.Forms.Control, string> mandatoryControls = new Dictionary<System.Windows.Forms.Control, string>();

            foreach (System.Windows.Forms.Control c in skControlList)
            {
                Type t = c.GetType();
                PropertyInfo pInfoRequired = t.GetProperty("Required");

                if (pInfoRequired != null && (bool)pInfoRequired.GetValue(c,null) == true)
                mandatoryControls.Add(c, c.Name);

            }
            return mandatoryControls;
        }

        #endregion

        #region Localization : Multi-Lingual Culture (EN, KO, ZH)
        public void SetCultureInfo(System.Globalization.CultureInfo newCulture)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = newCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
        }

        /// <summary>
        /// 현재 설정된 다국어로 설정을 바꿉니다
        /// </summary>
        public void ReloadCulture()
        {
            BroadCastEventArgs args = new BroadCastEventArgs();
            args.MessageName = "_Framework_Localization";
            args.DataObject = new NEXCOREData();

            Program pgm = this.GetCurrentProgram();
            string strPgmId = string.Empty;

            if (pgm != null)
            {
                strPgmId = pgm.PgmId;
            }
            args.DataObject.Hashtable.Add("Program", strPgmId);

            this.Broadcast(System.Threading.Thread.CurrentThread.CurrentUICulture, args);

        }

        /// <summary>
        /// 현재 설정된 다국어로 현재 화면을 바꿉니다
        /// </summary>
        public void ReloadCurrentProgram(Program pgm)
        {
            BroadCastEventArgs args = new BroadCastEventArgs();

            args.MessageName = "_Framework_Localization";
            args.DataObject = new NEXCOREData();
            args.DataObject.Hashtable.Add("Program", pgm.PgmId);

            this.Broadcast(System.Threading.Thread.CurrentThread.CurrentUICulture, args);
        }

        /// <summary>
        /// 파라미터의 다국어 정보를 이용해서 다국어를 설정 합니다.
        /// </summary>
        /// <param name="newCulture"></param>
        public void ReloadCulture(System.Globalization.CultureInfo newCulture)
        {
            this.SetCultureInfo(newCulture);
            this.ReloadCulture();
        }

        public void ReloadCulture(string misCultureString)
        {
            switch (misCultureString)
            {
                case "KOR":
                    this.SetCultureInfo(new System.Globalization.CultureInfo("ko-KR"));
                    break;
                case "ENG":
                    this.SetCultureInfo(new System.Globalization.CultureInfo("en-US"));
                    break;
                case "CHN":
                    this.SetCultureInfo(new System.Globalization.CultureInfo("zh-CN"));
                    break;
            }
            this.ReloadCulture();
        }

        public System.Globalization.CultureInfo GetCurrentUICulture()
        {
            return System.Threading.Thread.CurrentThread.CurrentUICulture;
        }
        
        public string GetCurrentLanguage()
        {
            if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLower().Contains("en"))
            {
                return "ENG";
            }
            else if (System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLower().Contains("zh") || System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLower().Contains("ch"))
            {
                return "CHN";
            }
            else
            {
                return "KOR";
            }
        }
        #endregion

    }
}
