using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace NEXCORE.Service.ServiceManager
{
    public class MenuServiceProxy
    {
        private static string MENU_SERVICE_URL = "MENU_SERVICE_URL";
        private static MenuService.MenuServiceClient _MenuService;
        
        public static List<Menu> GetNavagatorMenu(string authId)
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetNavagatorMenu(authId);
        }

        public static List<Menu> GetToolMenuList(string authId, string sysid)
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetToolMenuList(authId,sysid);
        }

        public static List<Menu> GetAllWMSMenuList()
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetWMSMenuList();
        }

        public static List<Dept> GetAllWMSDeptList()
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetWMSDeptList();
        }
        public static List<Menu> GetAllWMSMenuList(string userId, string sysid)
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetWMSMenuListByUser(userId,sysid);
        }

        public static List<Menu> GetAllMenuList(string authId, string sysid)
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetAllMenuList(authId,sysid);
        }

        private static bool CheckConnection()
        {
            if (_MenuService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(MENU_SERVICE_URL);

                BasicHttpBinding wsBinding = new BasicHttpBinding();
                wsBinding.MaxReceivedMessageSize = 9999999;

                EndpointAddress address = new EndpointAddress(url);

                _MenuService = new MenuService.MenuServiceClient(wsBinding, address);
            }

            return true;
        }

        public static List<Menu> GetMyMenuList(string userId)
        {
            if (!CheckConnection())
                return null;

            return _MenuService.GetMyMenuList(userId);
        }
        public static void AddMenu(Menu menu)
        {
            if (!CheckConnection())
                return;

            _MenuService.AddMenu(menu);
        }

        public static void DeleteMenu(Menu menu)
        {
            if (!CheckConnection())
                return;

            _MenuService.DeleteMenu(menu);
        }

        public static void UpdateMenu(Menu menu)
        {
            if (!CheckConnection())
                return;

            _MenuService.UpdateMenu(menu);
        }
        public static bool AddMyMenu(Menu menu)
        {
            if (!CheckConnection())
                return false;

           return _MenuService.AddMyMenu(menu);
        }

        public static bool DeleteMyMenu(Menu menu)
        {
            if (!CheckConnection())
                return false;

           return _MenuService.DeleteMyMenu(menu);
        }

        public static bool UpdateMyMenu(Menu menu)
        {
            if (!CheckConnection())
                return false;

           return _MenuService.UpdateMyMenu(menu);
        }

        public static void Reload()
        {
            if (!CheckConnection())
                return;

            _MenuService.Reload();
        }
    }
}
