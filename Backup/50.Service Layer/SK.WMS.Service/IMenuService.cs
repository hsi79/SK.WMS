using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "IMenuService" here, you must also update the reference to "IMenuService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceContract]
    public interface IMenuService
    {
        [OperationContract]
        IList<Menu> GetWMSMenuList();

        [OperationContract]
        IList<Menu> GetWMSMenuListByUser(string userId, string sysid);

        [OperationContract]
        IList<Menu> GetToolMenuList(string authId, string sysid);

        [OperationContract]
        IList<Menu> GetNavagatorMenu(string authId);

        [OperationContract]
        IList<Menu> GetAllMenuList(string authId, string sysid);

        [OperationContract]
        IList<Menu> GetMyMenuList(string userId);

        [OperationContract]
        void AddMenu(Menu menu);

        [OperationContract]
        void DeleteMenu(Menu menu);

        [OperationContract]
        void UpdateMenu(Menu menu);

        [OperationContract]
         bool AddMyMenu(Menu menu);

        [OperationContract]
         bool DeleteMyMenu(Menu menu);

        [OperationContract]
         bool UpdateMyMenu(Menu menu);

        [OperationContract]
        void Reload();

    }
}
