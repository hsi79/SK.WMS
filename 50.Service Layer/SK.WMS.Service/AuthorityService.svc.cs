using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.IoC;
using NEXCORE.Common.Data;
using NEXCORE.Components.AuthorityManager;

namespace NEXCORE.Service
{
    // NOTE: If you change the class name "AuthorityService" here, you must also update the reference to "AuthorityService" in Web.config.
    public class AuthorityService : IAuthorityService
    {
        #region IAuthorityService 멤버

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public IList<NEXCORE.Common.Data.Authority> GetAuthorityList()
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthorityList();
        }
        public IList<NEXCORE.Common.Data.AuthorityPgm> GetAuthorityPgmList(string authId, string all)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthorityPgmList(authId,all);
        }
        public IList<NEXCORE.Common.Data.AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthorityUserList(authId,usernm,deptnm);
        }
        public IList<NEXCORE.Common.Data.AuthorityPgm> GetAuthorityPgm(string authId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthorityPgm(authId);
        }
        public IList<NEXCORE.Common.Data.AuthorityButton> GetAuthorityButtonList(string authId, string pgmId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthorityButtonList(authId,pgmId);
        }
        public IList<NEXCORE.Common.Data.AuthorityButton> GetUserButtonList(string userId, string pgmId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetUserButtonList(userId, pgmId);
        }
        public IList<NEXCORE.Common.Data.UserAuthority> GetUserAuthorityList(string userId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetUserAuthorityList(userId);
        }
        public IList<NEXCORE.Common.Data.Authority> GetAuthorityListByCondition(string authId, string authName)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthorityList(authId, authName);
        }

        public NEXCORE.Common.Data.Authority GetAuthority(string authId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetAuthority(authId);
        }

        public NEXCOREData GetLogList(string Type, string start, string end)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetLogList(Type, start, end);
        }
        public bool DeleteAuthority(string authId, bool deleteChildAuth)
        {
            throw new NotImplementedException();
        }

        public bool ModifyAuthority(NEXCORE.Common.Data.Authority authority)
        {
            throw new NotImplementedException();
        }

        public bool AddUserAuth(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.AddUserAuth(data);
        }
        public bool AddAuthPgm(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.AddAuthPgm(data);
        }
        public bool AddAuthUser(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.AddAuthUser(data);
        }
        public bool AddAuthButton(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.AddAuthButton(data);
        }

        public bool AddAuth(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.AddAuth(data);
        }
        public bool UpdateAuth(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.UpdateAuth(data);
        }
        public bool DeleteAuth(NEXCORE.Common.Data.NEXCOREData data)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.DeleteAuth(data);
        }
        public int DupCheck(string TableName, string key)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.DupCheck(TableName, key);
        }
        public List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetButtonAuthority(userId, pgmId);
        }

        public ManagedButton GetButton(string btnId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetButton(btnId);
        }
        public List<ManagedButton> GetButtonListAll()
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetButtonListAll();
        }
        public List<ManagedButton> GetButtonList(string pgmId)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.GetButtonList(pgmId);
        }
        public bool AddButton(ManagedButton button)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.AddButton(button);
        }
        public bool UpdateButton(ManagedButton button)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.UpdateButton(button);
        }
        public bool DeleteButton(ManagedButton button)
        {
            IAuthorityManager authMgr = (IAuthorityManager)ComponentFactory.GetObject("NexcoreAuthorityMgr");
            return authMgr.DeleteButton(button);
        }
        #endregion
    }
}
