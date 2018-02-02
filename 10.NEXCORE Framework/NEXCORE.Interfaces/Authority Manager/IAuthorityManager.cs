using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IAuthorityManager : IManager
    {
        void Init();

        List<Authority> GetAuthorityList();

        List<Authority> GetAuthorityList(string authId, string authName);

        List<AuthorityPgm> GetAuthorityPgmList(string authId, string all);
        List<AuthorityPgm> GetAuthorityPgm(string authId);
        List<AuthorityButton> GetAuthorityButtonList(string authId, string pgmId);
        List<AuthorityButton> GetUserButtonList(string userId, string pgmId);
        List<UserAuthority> GetUserAuthorityList(string userId);
        List<AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm);
        Authority GetAuthority(string authId);
        NEXCOREData GetLogList(string Type, string start, string end);
        bool DeleteAuthority(string authId, bool deleteChildAuth);

        bool ModifyAuthority(Authority authority);

        Program GetProgramButtonAuthority(string programId);

        bool ModifyProgramAuthority(Program pgm);

        bool AddUserAuth(NEXCOREData data);
        bool AddAuthPgm(NEXCOREData data);
        bool AddAuthUser(NEXCOREData data);
        bool AddAuth(NEXCOREData data);
        bool UpdateAuth(NEXCOREData data);
        bool DeleteAuth(NEXCOREData data);
        bool DeleteProgramInAuthority(string pgmId, string authId);
        int DupCheck(string TableName, string key);       
        List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId);
        
        ManagedButton GetButton(string btnId);

        List<ManagedButton> GetButtonList(string pgmId);
        List<ManagedButton> GetButtonListAll();
        bool AddButton(ManagedButton button);
        bool UpdateButton(ManagedButton button);
        bool DeleteButton(ManagedButton button);

        bool AddAuthButton(NEXCOREData data);
    }
}
