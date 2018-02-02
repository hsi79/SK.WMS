using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace NEXCORE.Interfaces
{
    public interface IMenu
    {

        string MenuId { get; set; }

        string PgmId { get; set; }

        string ParentMenuId { get; set; }

        string MenuKorea { get; set; }

        string MenuEnglish { get; set; }

        string MenuChina { get; set; }

        string OpenType { get; set; }

        bool Use { get; set; }

        bool Visible { get; set; }

        string MenuDescription { get; set; }
  
        string SORT { get; set; }
    
        string AuthId { get; set; }
 
        Image ICON { get; set; }
 
        string MenuType {get;set;}
    }
}
