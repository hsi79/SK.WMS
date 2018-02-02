using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Skcc.IoC;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using NEXCORE.Components.MenuManager;


namespace NEXCORE.Service
{
    // NOTE: If you change the class name "MenuService" here, you must also update the reference to "MenuService" in Web.config.
    public class MenuService : IMenuService
    {

        #region IMenuService 멤버

        public IList<Menu> GetWMSMenuList()
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.GetWMSMenuList();
        }

        public IList<Menu> GetWMSMenuListByUser(string userId, string sysid)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.GetWMSMenuList(userId,sysid);
        }

        public IList<Menu> GetToolMenuList(string authId, string sysid)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.GetToolMenuList(authId,sysid);
        }

        public IList<Menu> GetNavagatorMenu(string authId)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.GetNavagatorMenu(authId);
        }

        public IList<Menu> GetAllMenuList(string authId, string sysid)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.GetAllMenuList(authId,sysid);
        }

        public IList<Menu> GetMyMenuList(string userId)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.GetMyMenuList(userId);
        }
        public void AddMenu(Menu menu)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            menuMgr.AddMenu(menu);
        }

        public void DeleteMenu(Menu menu)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            menuMgr.DeleteMenu(menu);
        }

        public void UpdateMenu(Menu menu)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            menuMgr.UpdateMenu(menu);
        }
        public bool AddMyMenu(Menu menu)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.AddMyMenu(menu);
        }

        public bool DeleteMyMenu(Menu menu)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.DeleteMyMenu(menu);
        }

        public bool UpdateMyMenu(Menu menu)
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return menuMgr.UpdateMyMenu(menu);
        }

        public void Reload()
        {
            IMenuManager menuMgr = null;
            try
            {
                menuMgr = (IMenuManager)ComponentFactory.GetObject("NexcoreMenuMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            menuMgr.Init();
        }

        #endregion
    }
}
