using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace NEXCORE.Service.ServiceManager
{
    public class UserServiceProxy
    {
        private static UserService.UserServiceClient _UserService;
        
        private static string USER_SERVICE_URL = "USER_SERVICE_URL";


        public static LOGIN_RESULT_CODE Login(string userId, string password)
        {
            try
            {
                if (!CheckConnection())
                    return LOGIN_RESULT_CODE.EXCEPTION;

                return _UserService.Login(userId, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return LOGIN_RESULT_CODE.EXCEPTION;
        }

        public static User GetUser(string userId)
        {
            try
            {
                if (!CheckConnection())
                    return null;

                return _UserService.GetUser(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public static User[] GetUsers(string usernm)
        {
            try
            {
                if (!CheckConnection())
                    return null;

                return _UserService.GetUsers(usernm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public static bool ModifyLockUser(string userId,string lockyn)
        {
            try
            {
                if (!CheckConnection())
                    return false;
                return _UserService.ModifyLockUser(userId, lockyn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }
        public static bool ChangePassword(string userId, string password)
        {
            try
            {
                if (!CheckConnection())
                    return false;
                return _UserService.ChangePassword(userId, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public static bool ErrorLog(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.ErrorLog(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        public static bool AddUser(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.AddUser(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        public static bool UpdateUser(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.UpdateUser(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        public static bool EtcUpdateUser(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.EtcUpdateUser(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        public static bool DeleteUser(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.DeleteUser(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        public static bool LoginHistory(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.LoginHistory(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }

        public static bool PgmHistory(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.PgmHistory(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        public static bool ButtonHistory(NEXCOREData data)
        {
            bool retData = false;
            try
            {
                if (CheckConnection())
                    retData = _UserService.ButtonHistory(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return retData;
        }
        
        private static bool CheckConnection()
        {
            if (_UserService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(USER_SERVICE_URL);

                BasicHttpBinding wsBinding = new BasicHttpBinding();
                wsBinding.MaxReceivedMessageSize = 2147483647;
                
                EndpointAddress address = new EndpointAddress(url);

                _UserService = new UserService.UserServiceClient(wsBinding, address);
            }

            return true;
        }

        public static void Reload()
        {
            if (!CheckConnection())
                return;

            _UserService.Reload();
        }
    }
}
