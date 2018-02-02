using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "IUserService" here, you must also update the reference to "IUserService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        LOGIN_RESULT_CODE Login(string userId, string password);

        [OperationContract]
        User GetUser(string userId);

        [OperationContract]
        List<User> GetUsers(string usernm);

        [OperationContract]
        bool ModifyLockUser(string userId, string lockyn);

        [OperationContract]
        bool ErrorLog(NEXCOREData data);
        [OperationContract]
        bool LoginHistory(NEXCOREData data);

        [OperationContract]
        bool PgmHistory(NEXCOREData data);
        [OperationContract]
        bool ButtonHistory(NEXCOREData data);
        [OperationContract]
        bool ChangePassword(string userId, string password);
        [OperationContract]
        bool AddUser(NEXCOREData data);
        [OperationContract]
        bool UpdateUser(NEXCOREData data);
        [OperationContract]
        bool EtcUpdateUser(NEXCOREData data);
        [OperationContract]
        bool DeleteUser(NEXCOREData data);
        [OperationContract]
        void Reload();
    }
}
