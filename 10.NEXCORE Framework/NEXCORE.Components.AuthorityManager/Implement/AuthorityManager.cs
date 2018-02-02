using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using System.Data;

namespace NEXCORE.Components.AuthorityManager
{
    public class AuthorityManager : IAuthorityManager
    {
        //Setter Injection
        public AuthorityDatabase _AuthorityRepository = new AuthorityDatabase();

        #region IAuthorityManager 멤버

        public void Init()
        {
            //_AuthorityRepository.LoadAuthority();
        }

        public List<NEXCORE.Common.Data.Authority> GetAuthorityList()
        {
            return _AuthorityRepository.GetAuthority();
        }
        public List<NEXCORE.Common.Data.AuthorityPgm> GetAuthorityPgmList(string authId, string all)
        {
            return _AuthorityRepository.GetAuthorityPgmList(authId,all);
        }
        public List<NEXCORE.Common.Data.AuthorityPgm> GetAuthorityPgm(string authId)
        {
            return _AuthorityRepository.GetAuthorityPgm(authId);
        }
        public List<NEXCORE.Common.Data.AuthorityButton> GetAuthorityButtonList(string authId, string pgmId)
        {
            return _AuthorityRepository.GetAuthorityButtonList(authId,pgmId);
        }
        public List<NEXCORE.Common.Data.AuthorityButton> GetUserButtonList(string userId, string pgmId)
        {
            return _AuthorityRepository.GetUserButtonList(userId, pgmId);
        }
        public List<NEXCORE.Common.Data.UserAuthority> GetUserAuthorityList(string userId)
        {
            return _AuthorityRepository.GetUserAuthorityList(userId);
        }
        public List<NEXCORE.Common.Data.AuthorityUser> GetAuthorityUserList(string authId, string usernm, string deptnm)
        {
            return _AuthorityRepository.GetAuthorityUserList(authId,usernm,deptnm);
        }
        public List<NEXCORE.Common.Data.Authority> GetAuthorityList(string authId, string authName)
        {
            List<Authority> authList = GetAuthorityList();
            return authList.Where
                (authority => authority.AuthId.Contains(authId) && authority.AuthName.Contains(authName)).ToList<Authority>();

        }

        public NEXCORE.Common.Data.Authority GetAuthority(string authId)
        {
            List<Authority> authList = GetAuthorityList();

            return authList.Single
                (a => a.AuthId == authId);
        }

        public List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId)
        {
            List<ButtonAuthority> btnAuthList = new List<ButtonAuthority>();

            return this._AuthorityRepository.GetButtonAuthority(userId, pgmId);
        }

        public bool AddUserAuth(NEXCOREData data)
        {
            bool ret = false;

            if (data.DataTable.Rows.Count > 0)
            {
                _AuthorityRepository.DeleteUserAuth(data.DataTable.Rows[0]);
            }
            foreach (DataRow row in data.DataTable.Rows)
            {
                if (row["Chk"].ToString() == "True")
                {
                    ret = _AuthorityRepository.AddUserAuth(row);
                }

            }
            return ret;
        }
        public bool AddAuthUser(NEXCOREData data)
        {
            bool ret = false;

            if (data.DataTable.Rows.Count > 0)
            {
                _AuthorityRepository.DeleteAuthUser(data.DataTable.Rows[0]);
            }
            foreach (DataRow row in data.DataTable.Rows)
            {
                if (row["Chk"].ToString() == "True")
                {
                    ret = _AuthorityRepository.AddAuthUser(row);
                }

            }
            return ret;
        }
        public bool AddAuthPgm(NEXCOREData data)
        {
            bool ret = false;
            if (data.DataTable.Rows.Count > 0)
            {
                _AuthorityRepository.DeleteAuthPgm(data.DataTable.Rows[0]);
            }
            foreach (DataRow row in data.DataTable.Rows)
            {
                if (row["Chk"].ToString() == "True" || row["C"].ToString() == "True" || row["R"].ToString() == "True" || row["D"].ToString() == "True" || row["E"].ToString() == "True" || row["P"].ToString() == "True")
                {

                    ret = _AuthorityRepository.AddAuthPgm(row);
                }
            }
            return ret;
        }
        public bool AddAuth(NEXCOREData data)
        {
            bool ret = false;

            if (data.Hashtable.Count > 0)
            {
                _AuthorityRepository.AddAuth(data.Hashtable);
            }

            return ret;
        }
        public bool UpdateAuth(NEXCOREData data)
        {
            bool ret = false;

            if (data.Hashtable.Count > 0)
            {
                _AuthorityRepository.UpdateAuth(data.Hashtable);
            }

            return ret;
        }
        public bool DeleteAuth(NEXCOREData data)
        {
            bool ret = false;

            if (data.Hashtable.Count > 0)
            {
                _AuthorityRepository.DeleteAuth(data.Hashtable);
            }

            return ret;
        }

        public bool AddAuthButton(NEXCOREData data)
        {
            bool ret = false;


            foreach (DataRow row in data.DataTable.Rows)
            {

                ret = _AuthorityRepository.AddAuthButton(row);


            }
            return ret;
        }

        public int DupCheck(string TableName, string key)
        {
            return _AuthorityRepository.DupCheck(TableName, key);
        }
        public NEXCOREData GetLogList(string Type, string start, string end)
        {
            return _AuthorityRepository.GetLogList( Type,  start, end);
        }
        public bool DeleteAuthority(string authId, bool deleteChildAuth)
        {
            throw new NotImplementedException();
        }

        public bool ModifyAuthority(NEXCORE.Common.Data.Authority authority)
        {
            throw new NotImplementedException();
        }

        public Program GetProgramButtonAuthority(string programId)
        {
            throw new NotImplementedException();
        }

        public bool ModifyProgramAuthority(Program pgm)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProgramInAuthority(string pgmId, string authId)
        {
            throw new NotImplementedException();
        }

        public ManagedButton GetButton(string btnId)
        {
            List<ManagedButton> btnList = this._AuthorityRepository.GetButtonList();

            foreach (ManagedButton btn in btnList)
            {
                if (btn.ButtonID == btnId)
                    return btn;
            }

            return null;
        }

        public List<ManagedButton> GetButtonList(string pgmId)
        {
            List<ManagedButton> btnList = this._AuthorityRepository.GetButtonList();

            var newBtnList = from b in btnList
                             where b.PgmId == pgmId
                             select b;

            return newBtnList.ToList<ManagedButton>();
        }
        public List<ManagedButton> GetButtonListAll()
        {
            List<ManagedButton> btnList = this._AuthorityRepository.GetButtonList();

            return btnList.ToList<ManagedButton>();
        }
        public bool AddButton(ManagedButton button)
        {
            bool ret = false;


            ret =    _AuthorityRepository.AddButton(button);

            return ret;
        }
        public bool UpdateButton(ManagedButton button)
        {
            bool ret = false;


            ret = _AuthorityRepository.UpdateButton(button);

            return ret;
        }
        public bool DeleteButton(ManagedButton button)
        {
            bool ret = false;


            ret = _AuthorityRepository.DeleteButton(button);

            return ret;
        }
        #endregion
    }
}
