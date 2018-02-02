using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IMenuRepository
    {
        void LoadMenu();

        IList<Menu> GetMenus();

        IList<Menu> GetMyMenuList(string userId);
        void AddMenu(Menu menu);

        void UpdateMenu(Menu menu);

        void DeleteMenu(Menu menu);

        void AddMyMenu(Menu menu);

        void ModifyMyMenu(Menu menu);

        void UpdateMyMenu(Menu menu);

        void DeleteMyMenu(Menu menu);
    }
}
