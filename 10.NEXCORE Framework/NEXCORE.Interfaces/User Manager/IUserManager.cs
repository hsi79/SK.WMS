using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IUserManager : IManager
    {
        void Init();
        LOGIN_RESULT_CODE Login(string userId, string password);
        User GetUser(string userId);
        bool ModifyLockUser(string userId, string lockyn);
        bool ErrorLog(NEXCOREData data);
        bool LoginHistory(NEXCOREData data);
        bool PgmHistory(NEXCOREData data);
        bool ButtonHistory(NEXCOREData data);
        List<User> GetUsers(string usernm);
        bool ChangePassword(string userId, string password);
        bool AddUser(NEXCOREData data);
        bool UpdateUser(NEXCOREData data);
        bool DeleteUser(NEXCOREData data);
        bool EtcUpdateUser(NEXCOREData data);
        void Reload();
    }

    public enum LOGIN_RESULT_CODE
    {
        ID_NOT_FOUND = 0,
        PWD_NOT_MATCHED = 1,
        NOT_VALID_DATE = 2,
        EXPIRED_DATE = 3,
        ID_LOCKED = 4,
        SUCCESS = 5 ,
        PASSWORD_EXPIRED = 6,
        EXCEPTION = 7,
        FAIL = 8
    }
}
