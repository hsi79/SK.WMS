using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "IAuthorityService" here, you must also update the reference to "IAuthorityService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceContract]
    public interface IAuthorityService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        IList<Authority> GetAuthorityList();

        [OperationContract]
        IList<AuthorityPgm> GetAuthorityPgmList(string authId, string all);
        [OperationContract]
        IList<AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm);

        [OperationContract]
        IList<AuthorityPgm> GetAuthorityPgm(string authId);
        [OperationContract]
        IList<UserAuthority> GetUserAuthorityList(string userId);

        [OperationContract]
        IList<Authority> GetAuthorityListByCondition(string authId, string authName);

        [OperationContract]
        IList<AuthorityButton> GetAuthorityButtonList(string authId,string pgmId);

        [OperationContract]
        IList<AuthorityButton> GetUserButtonList(string userId, string pgmId);

         [OperationContract]
        NEXCOREData GetLogList(string Type, string start, string end);       
        [OperationContract]
        Authority GetAuthority(string authId);

        [OperationContract]
        bool DeleteAuthority(string authId, bool deleteChildAuth);

        [OperationContract]
        bool ModifyAuthority(Authority authority);

        [OperationContract]
        bool AddUserAuth(NEXCOREData data);

        [OperationContract]
        bool AddAuthPgm(NEXCOREData data);

        [OperationContract]
        bool AddAuthUser(NEXCOREData data);
        [OperationContract]
        bool AddAuth(NEXCOREData data);

        [OperationContract]
        bool UpdateAuth(NEXCOREData data);

        [OperationContract]
        bool DeleteAuth(NEXCOREData data);

        [OperationContract]
        int DupCheck(string TableName, string key);

        [OperationContract]
        List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId);

        [OperationContract]
        ManagedButton GetButton(string btnId);

        [OperationContract]
        List<ManagedButton> GetButtonList(string pgmId);
        [OperationContract]
        List<ManagedButton> GetButtonListAll();
        [OperationContract]
        bool AddButton(ManagedButton button);
        [OperationContract]
        bool UpdateButton(ManagedButton button);
        [OperationContract]
        bool DeleteButton(ManagedButton button);
        [OperationContract]
        bool AddAuthButton(NEXCOREData data);
    }
}
