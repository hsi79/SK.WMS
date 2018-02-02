using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IMenuManager : IManager
    {
        IList<Menu> GetWMSMenuList();
        IList<Dept> GetWMSDeptList();
        IList<Menu> GetWMSMenuList(string userId, string sysid);

        IList<Menu> GetToolMenuList(string authId, string sysid);

        IList<Menu> GetNavagatorMenu(string authId);

        IList<Menu> GetChildMenus(string parentId, string authId);

        IList<Menu> GetAllMenuList(string authId, string sysid);

        IList<Menu> GetMyMenuList(string userId);
        void AddMenu(Menu menu);

        void UpdateMenu(Menu menu);

        void DeleteMenu(Menu menu);

         bool AddMyMenu(Menu menu);

         void ModifyMyMenu(Menu menu);

         bool UpdateMyMenu(Menu menu);

         bool DeleteMyMenu(Menu menu);

        void Init();
    }
}
