using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace NEXCORE.Service.ServiceManager
{
    public class AuthorityServiceProxy
    {
        private static AuthorityService.AuthorityServiceClient _AuthService;

        private static string AUTH_SERVICE_URL = "AUTH_SERVICE_URL";
        

        public static List<Authority> GetAuthorityList()
        {
            if (!CheckConnection())
                return null;
      

            return _AuthService.GetAuthorityList();
        }

        public static List<Authority> GetAuthorityList(string authId, string authName)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetAuthorityListByCondition(authId, authName);
        }

        public static List<AuthorityPgm> GetAuthorityPgmList(string authId, string all)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetAuthorityPgmList(authId,all);
        }
        public static List<AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetAuthorityUserList(authId,usernm,deptnm);
        }
        public static List<AuthorityPgm> GetAuthorityPgm(string authId)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetAuthorityPgm(authId);
        }
        public static List<AuthorityButton> GetAuthorityButtonList(string authId, string pgmId)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetAuthorityButtonList(authId,pgmId);
        }
        public static List<AuthorityButton> GetUserButtonList(string userId, string pgmId)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetUserButtonList(userId, pgmId);
        }
        public static List<UserAuthority> GetUserAuthorityList(string userId)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetUserAuthorityList(userId);
        }
        public static NEXCORE.Common.Data.Authority GetAuthority(string authId)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetAuthority(authId);
        }
        public static NEXCOREData GetLogList(string Type,string start,string end)
        {
            if (!CheckConnection())
                return null;


            return _AuthService.GetLogList(Type, start, end);
        }
        public static bool DeleteAuthority(string authId, bool deleteChildAuth)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.DeleteAuthority(authId, deleteChildAuth);
        }
        public static int DupCheck(string TableName, string key)
        {
            if (!CheckConnection())
                return 0;

            return _AuthService.DupCheck(TableName, key);
        }
        public static bool ModifyAuthority(Authority authority)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.ModifyAuthority(authority);
        }
        public static bool AddUserAuth(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.AddUserAuth(data);
        }
        public static bool AddAuthPgm(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.AddAuthPgm(data);
        }
        public static bool AddAuthUser(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.AddAuthUser(data);
        }
        public static bool AddAuthButton(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.AddAuthButton(data);
        }

        public static bool AddAuth(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.AddAuth(data);
        }
        public static bool UpdateAuth(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.UpdateAuth(data);
        }
        public static bool DeleteAuth(NEXCOREData data)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.DeleteAuth(data);
        }
        private static bool CheckConnection()
        {
            if (_AuthService == null )
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(AUTH_SERVICE_URL);

                Binding wsBinding = new BasicHttpBinding();

                EndpointAddress address = new EndpointAddress(url);

                _AuthService = new AuthorityService.AuthorityServiceClient(wsBinding, address);
            }

            return true;
        }

        public static List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId)
        {
            if (!CheckConnection())
                return new List<ButtonAuthority>();


            return _AuthService.GetButtonAuthority(userId, pgmId);



        }

        public static ManagedButton GetButton(string btnId)
        {
            if (!CheckConnection())
                return null;

            return _AuthService.GetButton(btnId);
        }

        public static List<ManagedButton> GetButtonList(string pgmId)
        {
            if (!CheckConnection())
                return null;

            return _AuthService.GetButtonList(pgmId);
        }
        public static List<ManagedButton> GetButtonListAll()
        {
            if (!CheckConnection())
                return null;

            return _AuthService.GetButtonListAll();
        }
        public static bool AddButton(ManagedButton button)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.AddButton(button);
        }
        public static bool UpdateButton(ManagedButton button)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.UpdateButton(button);
        }
        public static bool DeleteButton(ManagedButton button)
        {
            if (!CheckConnection())
                return false;


            return _AuthService.DeleteButton(button);
        }

    }
}
