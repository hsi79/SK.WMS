using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEXCORE.Interfaces
{
    public interface IMDI
    {
        void ShowMenu(List<NEXCORE.Common.Data.Menu> menuList);


        void LoadForm(object formInstance);
    }
}
