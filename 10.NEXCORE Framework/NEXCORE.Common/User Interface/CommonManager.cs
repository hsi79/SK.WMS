using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Service.ServiceManager;
using NEXCORE.Common.Data;

namespace NEXCORE.Common
{
    public class CommonManager// : IComponentManager
    {
        /// <summary>
        /// Represent a variety of state when invoking component, logging in/out, show pgm in tab controls, etc
        /// </summary>
        public enum InvokeState
        {
            /// <summary>
            /// Fail to invoke an specific action
            /// </summary>
            Fail,
            /// <summary>
            /// Succeed in invoking an specific action
            /// </summary>
            Success,
            /// <summary>
            /// Pending state is not used currently
            /// </summary>
            Pending,
            /// <summary>
            /// A special factor for logout state - see MainForm.cs - FormClosing event
            /// </summary>
            Logout
        }

        public static string IPAdress = string.Empty;
        public static string HostName = string.Empty;

        #region IComponentManager 멤버
        
        public static Code GetCode(string id)
        {
            return CodeServiceProxy.GetCode(id);
        }

        public static Code GetParentCode(string childCode)
        {
            Code code = CodeServiceProxy.GetCode(childCode);

            return code.Parent;
        }
        public static NEXCOREData GetHelpWindow(NEXCOREData data)
        {
            return CodeServiceProxy.GetHelpWindow(data);
        }
        public static NEXCOREData GetHelpProduct(NEXCOREData data)
        {
            return CodeServiceProxy.GetHelpProduct(data);
        }
        public static List<Code> GetCodes(string parentCodeId)
        {
            return CodeServiceProxy.GetCodes(parentCodeId);
        }

        public static List<Code> GetCodes(string parentCodeId, params string[] codeAttributes)
        {
            throw new NotImplementedException();
        }
        public static NEXCOREData GetLogList(string Type,string start,string end)
        {
            return AuthorityServiceProxy.GetLogList(Type,start,end);
        }
        public static Program GetMDIProgram()
        {
            List<Program> lstPgm = ProgramServiceProxy.GetProgramList("MDI", "", "");

            if (lstPgm == null || lstPgm.Count <= 0)
                return null;

            return lstPgm.First<Program>();

        }
        public static int DupCheck(string TableName, string key)
        {
            return AuthorityServiceProxy.DupCheck(TableName, key);
        }
        public static Program GetProgram(string pgmId)
        {
            return ProgramServiceProxy.GetProgram(pgmId);
        }

        public static List<Program> GetProgramList()
        {
            return ProgramServiceProxy.GetProgramList();
        }
        public static List<Program> GetProgramList(string pgmId)
        {
            return ProgramServiceProxy.GetProgramList(pgmId);
        }
        public static List<Program> GetProgramList(string pgmType, string pgmId, string pgmPath)
        {
            return ProgramServiceProxy.GetProgramList(pgmType, pgmId, pgmPath);
        }

        public static List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId)
        {
            return AuthorityServiceProxy.GetButtonAuthority(userId, pgmId);
        }
        public static List<Authority> GetAuthorityList()
        {
            return AuthorityServiceProxy.GetAuthorityList();
        }
        public static List<AuthorityPgm> GetAuthorityPgmList(string authId, string all)
        {
            return AuthorityServiceProxy.GetAuthorityPgmList(authId,all);
        }
        public static List<AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm)
        {
            return AuthorityServiceProxy.GetAuthorityUserList(authId,usernm,deptnm);
        }
        public static List<AuthorityPgm> GetAuthorityPgm(string authId)
        {
            return AuthorityServiceProxy.GetAuthorityPgm(authId);
        }
        public static List<AuthorityButton> GetAuthorityButtonList(string authId, string pgmId)
        {
            return AuthorityServiceProxy.GetAuthorityButtonList(authId,pgmId);
        }
        public static List<AuthorityButton> GetUserButtonList(string userId, string pgmId)
        {
            return AuthorityServiceProxy.GetUserButtonList(userId, pgmId);
        }
        public static List<UserAuthority> GetUserAuthorityList(string userId)
        {
            return AuthorityServiceProxy.GetUserAuthorityList(userId);
        }
        public static ManagedButton GetButton(string btnId)
        {
            return AuthorityServiceProxy.GetButton(btnId);
        }

        public static List<ManagedButton> GetButtonList(string pgmId)
        {
            return AuthorityServiceProxy.GetButtonList(pgmId);
        }
        public static List<ManagedButton> GetButtonListAll()
        {
            return AuthorityServiceProxy.GetButtonListAll();
        }

        #region Reload Methods
        /// <summary>
        /// Reload Program Information from Web-Server - NEXCORE.Components.ProgramManager
        /// </summary>
        public static void ReloadProgram()
        {
            ProgramServiceProxy.Reload();
        }

        /// <summary>
        /// Reload Menu Information from Web-Server - NEXCORE.Components.MenuManager
        /// </summary>
        public static void ReloadMenu()
        {
            MenuServiceProxy.Reload();
        }

        /// <summary>
        /// Reload Code Information from Web-Server - NEXCORE.Components.CodeManager
        /// </summary>
        public static void ReloadCodes()
        {
            CodeServiceProxy.Reload();
        }

        /// <summary>
        /// Reload Message Information from Web-Server - NEXCORE.Components.MessageManager
        /// </summary>
        public static void ReloadMessage()
        {
            MessageServiceProxy.Reload();
        }

        /// <summary>
        /// Reload Message Information from Web-Server - NEXCORE.Components.UserManager
        /// </summary>
        public static void ReloadUsers()
        {
            UserServiceProxy.Reload();
        }

        #endregion

        public static LOGIN_RESULT_CODE Login(string userId, string password)
        {
            LOGIN_RESULT_CODE retCode = UserServiceProxy.Login(userId, password);
            bool data = HistoryLogin(userId, userId, password, retCode.ToString());
            return retCode;
        }
        public static bool ChangePassword(string userId, string password)
        {

            bool ret = UserServiceProxy.ChangePassword(userId,password);
            return ret;
        }
        public static bool AddUser(NEXCOREData data)
        {

            bool ret = UserServiceProxy.AddUser(data);
            return ret;
        }
        public static bool UpdateUser(NEXCOREData data)
        {

            bool ret = UserServiceProxy.UpdateUser(data);
            return ret;
        }
        public static bool EtcUpdateUser(NEXCOREData data)
        {

            bool ret = UserServiceProxy.EtcUpdateUser(data);
            return ret;
        }
        public static bool DeleteUser(NEXCOREData data)
        {

            bool ret = UserServiceProxy.DeleteUser(data);
            return ret;
        }
        public static User GetUser(string userId)
        {
            return UserServiceProxy.GetUser(userId);
        }

        public static User[] GetUsers(string usernm)
        {
            return UserServiceProxy.GetUsers(usernm);
        }
        public static bool AddUserAuth(NEXCOREData data)
        {


            return AuthorityServiceProxy.AddUserAuth(data);
        }
        public static bool AddAuthPgm(NEXCOREData data)
        {


            return AuthorityServiceProxy.AddAuthPgm(data);
        }
        public static bool AddAuthUser(NEXCOREData data)
        {


            return AuthorityServiceProxy.AddAuthUser(data);
        }
        public static bool AddAuthButton(NEXCOREData data)
        {


            return AuthorityServiceProxy.AddAuthButton(data);
        }

        public static bool Contains(string msgID)
        {
            return MessageServiceProxy.Contains(msgID);
        }

        public static bool AddAuth(NEXCOREData data)
        {


            return AuthorityServiceProxy.AddAuth(data);
        }
        public static bool UpdateAuth(NEXCOREData data)
        {


            return AuthorityServiceProxy.UpdateAuth(data);
        }
        public static bool DeleteAuth(NEXCOREData data)
        {


            return AuthorityServiceProxy.DeleteAuth(data);
        }
        public static bool AddButton(ManagedButton button)
        {


            return AuthorityServiceProxy.AddButton(button);
        }
        public static bool UpdateButton(ManagedButton button)
        {


            return AuthorityServiceProxy.UpdateButton(button);
        }
        public static bool DeleteButton(ManagedButton button)
        {


            return AuthorityServiceProxy.DeleteButton(button);
        }

        public static string GetMessage(string msgID)
        {
            string locale = "ENG";
            if (UIInterface.This() != null)
                locale = UIInterface.This().GetCurrentLanguage();
            return MessageServiceProxy.GetMessageLocale(msgID, locale);
        }

        public static List<NEXCORE.Common.Data.Message> GetMessageList(string msgID, string msgNm)
        {
            return MessageServiceProxy.GetMessageList(msgID, msgNm);
        }
        public static string GetMessageLocale(string msgID, string locale)
        {
            return MessageServiceProxy.GetMessageLocale(msgID, locale);
        }

        public static List<Menu> GetAllMenu( string sysid)
        {




            return MenuServiceProxy.GetAllMenuList("",sysid);
        }

        public static List<Menu> GetWMSMenuList()
        {
            return MenuServiceProxy.GetAllWMSMenuList();
        }
        public static List<Dept> GetWMSDeptList()
        {
            return MenuServiceProxy.GetAllWMSDeptList();
        }
        public static List<Menu> GetWMSMenuList(string userId, string sysid)
        {
            return MenuServiceProxy.GetAllWMSMenuList(userId,sysid);
        }
        public static List<Menu> GetToolMenuList(string userId, string sysid)
        {
            return MenuServiceProxy.GetToolMenuList(userId,sysid);
        }
        public static List<Menu> GetNavigatorMenuList(string authId)
        {
            return MenuServiceProxy.GetNavagatorMenu(authId);
        }

        public static List<Menu> GetMyMenuList(string userId)
        {
            return MenuServiceProxy.GetMyMenuList(userId);
        }

        public static bool IsMenuExist(string userId, string pgmName)
        {
            List<Menu> lstMenu = GetMyMenuList(userId);

            bool hasFound = false;

            MenuExist(lstMenu,userId, pgmName, ref hasFound );

            return hasFound;
        }

        private static void MenuExist(List<Menu> lstMenu,string userId, string pgmName, ref bool hasFound)
        {
            if (hasFound == true)
                return;

            foreach (Menu m in lstMenu)
            {
                if (m.UserId == userId && m.PgmId == pgmName)
                {
                    hasFound = true;
                    return;
                }
            }
        }

        public static void AddProgram(Program program)
        {
            ProgramServiceProxy.AddProgram(program);
        }
        public static void UpdateProgram(Program program)
        {
            ProgramServiceProxy.UpdateProgram(program);
        }
        public static void DeleteProgram(Program program)
        {
            ProgramServiceProxy.DeleteProgram(program);
        }
        public static void AddMenu(Menu menu)
        {
            MenuServiceProxy.AddMenu(menu);
        }
        public static void DeleteMenu(Menu menu, bool blnRecursive)
        {
            if (blnRecursive == false)
                MenuServiceProxy.DeleteMenu(menu);
            else
            {
                //하위 메뉴도 삭제 한다.

                string menuId = menu.MenuId;


                //1. 자식들을 구해서 다시 Recursive 호출
                if (menu.ChildMenuList != null)
                {
                    foreach (Menu cm in menu.ChildMenuList)
                    {
                        DeleteMenu(cm, true);
                    }
                }

                //2. 자기 자신을 지운다.
                DeleteMenu(menu, false);
            }
        }

        public static void UpdateMenu(Menu menu)
        {
            MenuServiceProxy.UpdateMenu(menu);
        }
        public static bool AddMyMenu(Menu menu)
        {
           return MenuServiceProxy.AddMyMenu(menu);
        }

        public static void AddMessage(string msgID, string msgNm)
        {
            MessageServiceProxy.AddMessage(msgID,msgNm);
        }
        public static void UpdateMessage(string msgID, string msgNm)
        {
            MessageServiceProxy.UpdateMessage(msgID,msgNm);
        }
        public static void DeleteMessage(string msgID)
        {
            MessageServiceProxy.DeleteMessage(msgID);
        }

        public static void ModifyLockUser(string userID,string lockyn)
        {
            UserServiceProxy.ModifyLockUser(userID,lockyn);
        }

        public static bool DeleteMyMenu(Menu menu)
        {

               return MenuServiceProxy.DeleteMyMenu(menu);
            
        }

        public static bool UpdateMyMenu(Menu menu)
        {
           return MenuServiceProxy.UpdateMyMenu(menu);
        }
        #endregion


        #region Performance Log 관련
        public static bool HistoryLogin(string userId, string loginId, string loginPw, string state)
        {
            if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("UseDBLogging"))
            {
                NEXCOREData param = new NEXCOREData();
                string enIP = getIP();


                param.Hashtable.Add("USER_ID", userId);
                param.Hashtable.Add("LOGIN_ID", loginId);
                param.Hashtable.Add("LOGIN_PW", loginPw);
                param.Hashtable.Add("STATE", state);
                param.Hashtable.Add("USER_IP", enIP);
                param.Hashtable.Add("CONNECTED_SERVER", System.Net.Dns.GetHostName());


                return UserServiceProxy.LoginHistory(param);
            }
            else
            {
                return false;
            }
        }
        public static bool ErrorLog(string pgmId, string loginId, string msg)
        {
            if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("UseDBLogging"))
            {
                NEXCOREData param = new NEXCOREData();
                string enIP = getIP();


                param.Hashtable.Add("ERROR_PGM_ID", pgmId);
                param.Hashtable.Add("ERROR_IP", enIP);
                param.Hashtable.Add("ERROR_COMPUTER", System.Net.Dns.GetHostName());
                param.Hashtable.Add("ERROR_DESC", msg);
                param.Hashtable.Add("REG_ID", loginId);

                return UserServiceProxy.ErrorLog(param);
            }
            else
            {
                return false;
            }
        }
        private static string getIP()
        {
            System.Net.IPAddress LocalAddress;
            System.Net.IPAddress[] ip = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            string enIP = string.Empty;
            for (int i = 0; i < ip.Length; i++)
            {
                if (ip.GetValue(i).ToString().Contains("."))
                {
                    LocalAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[i];
                    enIP = LocalAddress.ToString().Trim();
                    break;
                }
            }
            return enIP;
        }

        //public static NEXCOREData HistoryLogout(string userId, string deptCd)
        //{
        //    NEXCOREData param = new NEXCOREData();

        //    param.Hashtable.Add("UserID", userId);
        //    param.Hashtable.Add("ActionDatetime", DateTime.Now);
        //    param.Hashtable.Add("DeptCD", deptCd);
        //    param.Hashtable.Add("State", "Logout");
        //    param.Hashtable.Add("UserIP", CommonManager.IPAdress);
        //    param.Hashtable.Add("ConnectedServer", string.Empty);
        //    param.Hashtable.Add("StartFrom", string.Empty);
        //    param.Hashtable.Add("ComNm", CommonManager.HostName);

        //    return UIInterface.This().InvokeService("SK.WMS.Common.Biz.HistoryBiz", "AddHistoryLogin", param);
        //}

        public static bool HistoryProgram(string userId, string pgmId, DateTime actionTime, int loadingTime, string state, string resultLog)
        {
            if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("UseDBLogging"))
            {
                NEXCOREData param = new NEXCOREData();
                string enIP = getIP();


                param.Hashtable.Add("USER_ID", userId);
                param.Hashtable.Add("PGM_ID", pgmId);
                param.Hashtable.Add("ACTION_TIME", actionTime);
                param.Hashtable.Add("LOADING_TIME", loadingTime);
                param.Hashtable.Add("STATE", state);
                param.Hashtable.Add("RESULT_LOG", resultLog);
                param.Hashtable.Add("USER_IP", enIP);



                return UserServiceProxy.PgmHistory(param);
            }
            else
            {
                return false;
            }
           
        }

        public static bool HistoryButton(string userId, string pgmId,  string buttonId)
        {
            if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("UseDBLogging"))
            {
                NEXCOREData param = new NEXCOREData();


                param.Hashtable.Add("USER_ID", userId);
                param.Hashtable.Add("PGM_ID", pgmId);
                param.Hashtable.Add("BUTTON_ID", buttonId);



                return UserServiceProxy.ButtonHistory(param);
            }
            else
            {
                return false;
            }

        }

        public static NEXCOREData HistoryComponents(string userId, string bizName, string methodNm, DateTime startDate, DateTime endDate,
                                                     int runningTme, string paramLog, string state)
        {
            return null;
            //if (Skcc.Configuration.SkccFxConfigManager.GetBoolean("UseDBLogging"))
            //{
            //    NEXCOREData param = new NEXCOREData();

            //    param.Hashtable.Add("userId", userId);
            //    param.Hashtable.Add("bizNm", bizName);
            //    param.Hashtable.Add("methodNm", methodNm);
            //    param.Hashtable.Add("startTime", startDate);
            //    param.Hashtable.Add("endTime", endDate);

            //    param.Hashtable.Add("elapsedTime", runningTme);
            //    param.Hashtable.Add("paramLog", paramLog);
            //    param.Hashtable.Add("state", state);
            //    param.Hashtable.Add("userIP", CommonManager.HostName);
            //    param.Hashtable.Add("regId", userId);
            //    param.Hashtable.Add("regTime", DateTime.Now);
            //    //param.Hashtable.Add("connectedServer", System.Net.Dns.GetHostName());

            //    return ServiceLoader.Invoke("SK.WMS.Common.Biz.CommonBiz", "AddHistoryComponent", param);
            //}
            //else
            //{
            //    return null;
            //}
        }
        #endregion
    }
}
