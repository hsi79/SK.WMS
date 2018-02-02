using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.IoC;
using System.Diagnostics;
using NEXCORE.Components.UserManager;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the class name "UserService" here, you must also update the reference to "UserService" in Web.config.
    public class UserService : IUserService
    {
        public void DoWork()
        {
        }

        #region IUserService Member
        public NEXCORE.Interfaces.LOGIN_RESULT_CODE Login(string userId, string password)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr =  (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            return userMgr.Login(userId, password);
        }

        public NEXCORE.Common.Data.User GetUser(string userId)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("GetUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
                
            }
            return userMgr.GetUser(userId);
        }
        public List<NEXCORE.Common.Data.User> GetUsers(string usernm)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("GetUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.GetUsers(usernm);
        }

        public bool ModifyLockUser(string userId,string lockyn)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("ModifyLockUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.ModifyLockUser(userId,lockyn);
        }
        public bool ChangePassword(string userId, string password)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("ChangePassword에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.ChangePassword(userId, password);
        }

        public bool ErrorLog(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("ErrorLog에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.ErrorLog(data);
        }
        
        public bool LoginHistory(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("LoginHistory에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.LoginHistory(data);
        }

        public bool PgmHistory(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("PgmHistory에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.PgmHistory(data);
        }
        public bool ButtonHistory(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("ButtonHistory에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.ButtonHistory(data);
        }

        public bool AddUser(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("AddUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.AddUser(data);
        }
        public bool UpdateUser(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("UpdateUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.UpdateUser(data);
        }
        public bool EtcUpdateUser(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("EtcUpdateUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.EtcUpdateUser(data);
        }
        public bool DeleteUser(NEXCOREData data)
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                string msg = Utility.UtilityHelper.GetFinalInnerException(ex).Message;
                Utility.UtilityHelper.WriteLog("DeleteUser에러발생:" + msg, System.Diagnostics.TraceEventType.Error);
            }
            return userMgr.DeleteUser(data);
        }

        public void Reload()
        {
            IUserManager userMgr = null;
            try
            {
                userMgr = (IUserManager)ComponentFactory.GetObject("NexcoreUserMgr");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            userMgr.Reload();
        }
        #endregion

    }
}
