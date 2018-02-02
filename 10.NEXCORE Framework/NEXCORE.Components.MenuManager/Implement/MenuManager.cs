using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

namespace NEXCORE.Components.MenuManager
{
    public class MenuManager : IMenuManager
    {
        //Setter Injection
        public MenuRepository _menuRepository = new MenuRepository();

        #region IMenuManager 멤버

        public void Init()
        {
            _menuRepository.LoadWMSDept();
        }

        public IList<Menu> GetWMSMenuList()
        {
            IList<Menu> lstMenus = _menuRepository.GetMenus();
            return lstMenus;
        }
        public IList<Dept> GetWMSDeptList()
        {
            IList<Dept> lstDepts = _menuRepository.GetDepts();
            return lstDepts;
        }
        public IList<Menu> GetWMSMenuList(string userId, string sysid)
        {
            //_menuRepository.LoadMenu(userId);
            _menuRepository.LoadMenu(userId,sysid);
            IList<Menu> lstMenus = _menuRepository.GetMenus();
            return lstMenus;
        }
        public IList<Menu> GetToolMenuList(string userId, string sysid)
        {
            _menuRepository.CommonLoadMenu(userId,sysid);

            IList<Menu> lstMenus = _menuRepository.GetMenus();

            

            return lstMenus;
        }

        public IList<Menu> GetNavagatorMenu(string userId)
        {
            //_menuRepository.LoadMenu(userId);

            IList<Menu> menuList = _menuRepository.GetMenus();

            var rootMenuList = from m in menuList
                               where m.ParentMenuId.Contains("ROOT") && m.MenuType.Equals("NAVIGATION")
                               orderby m.SORT ascending
                               select m;

            return rootMenuList.ToList<Menu>();
        }

        public IList<Menu> GetAllMenuList(string userId, string sysid)
        {
            _menuRepository.LoadMenu(sysid);

            IList<Menu> menus = _menuRepository.GetMenus();

            var childMenus = from m in menus
                             orderby m.SORT ascending
                             select m;

            return childMenus.ToList<Menu>();
        }

        public IList<Menu> GetRootMenu(string userId, string sysid)
        {
            _menuRepository.LoadMenu(userId,sysid);

            IList<Menu> menus = _menuRepository.GetMenus();

            var childMenus = from m in menus
                             where m.ParentMenuId == "ROOT" 
                             orderby m.SORT ascending
                             select m;

            return childMenus.ToList<Menu>();
        }

        public IList<Menu> GetChildMenus(string parentId, string authId)
        {
            IList<Menu> menus = _menuRepository.GetMenus();

           var childMenus = from m in menus
                                     where m.ParentMenuId == parentId && m.AuthId == authId 
                            orderby m.SORT ascending
                                     select m;

           return childMenus.ToList<Menu>();
        }

        public IList<Menu> GetMyMenuList(string userId)
        {
            return _menuRepository.GetMyMenuList(userId);
        }
        public void AddMenu(Menu menu)
        {
            _menuRepository.AddMenu(menu);
        }


        public void UpdateMenu(Menu menu)
        {
            _menuRepository.UpdateMenu(menu);
        }

        public void DeleteMenu(Menu menu)
        {
            _menuRepository.DeleteMenu(menu);
        }
        public bool AddMyMenu(Menu menu)
        {
            return _menuRepository.AddMyMenu(menu);
        }

        public void ModifyMyMenu(Menu menu)
        {
            _menuRepository.ModifyMyMenu(menu);
        }

        public bool UpdateMyMenu(Menu menu)
        {
            return _menuRepository.UpdateMyMenu(menu);
        }

        public bool DeleteMyMenu(Menu menu)
        {
            return _menuRepository.DeleteMyMenu(menu);
        }
        #endregion
    }
}