using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;
using System.Data;
using System.Collections;

namespace NEXCORE.Interfaces
{
    public interface IAuthorityRepository
    {
        void LoadAuthority();
        List<AuthorityPgm> GetAuthorityPgmList(string authId, string all);
        List<AuthorityPgm> GetAuthorityPgm(string authId);
        List<UserAuthority> GetUserAuthorityList(string userId);
        List<AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm);
        List<AuthorityButton> GetAuthorityButtonList(string authId, string pgmId);
        List<AuthorityButton> GetUserButtonList(string userId, string pgmId);
        List<Authority> GetAuthority();

        List<ManagedButton> GetButtonList();

        List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId);
        NEXCOREData GetLogList(string Type, string start, string end);
        bool AddUserAuth(DataRow row);
        bool AddAuthUser(DataRow row);
        bool AddAuthPgm(DataRow row);
        bool AddAuth(Hashtable row);
        bool UpdateAuth(Hashtable row);
        bool DeleteAuth(Hashtable row);
        int DupCheck(string TableName, string key);

        bool AddButton(ManagedButton button);
        bool UpdateButton(ManagedButton button);
        bool DeleteButton(ManagedButton button);

    }
}
