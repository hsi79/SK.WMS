using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using System.Collections;
using Skcc.Data;
using System.Data;
using NEXCORE.Common.Data;
using System.Data.Common;

namespace NEXCORE.Components.AuthorityManager
{
    public class AuthorityDatabase : IAuthorityRepository
    {
        private Dictionary<string, Authority> _AuthorityList = new Dictionary<string, Authority>();

        private const string SPLoadAll = "PK_NEXCORE.SP_AUTH_SELECTALL";
        private const string SPLoadButtonAuth = "PK_NEXCORE.SP_BUTTONAUTHORITY_SELECT";
        private const string SPLoadManagedButton = "PK_NEXCORE.SP_BUTTON_SELECT";
        private const string SPLoadAuthPgm = "PK_NEXCORE.SP_ROLEPGM_SELECT";
        private const string SPLoadAuthPgmList = "PK_NEXCORE.SP_ROLEPGM_LIST"; 
        private const string SPLoadAuthButton = "PK_NEXCORE.SP_ROLEBUTTON_SELECT";
        private const string SPLoadUserAuth = "PK_NEXCORE.SP_USERROLE_SELECT";
        private const string SPLoadAuthUser = "PK_NEXCORE.SP_ROLEUSER_SELECT";
        private const string SPUserAuth = "PK_NEXCORE.SP_USERROLE_INSERT";
        private const string SPAuthUser = "PK_NEXCORE.SP_ROLEUSER_INSERT";
        private const string SPAuthPgm = "PK_NEXCORE.SP_ROLEPGM_INSERT";
        private const string SPUserAuthDelete = "PK_NEXCORE.SP_USERROLE_DELETE";
        private const string SPAuthUserDelete = "PK_NEXCORE.SP_ROLEUSER_DELETE";
        private const string SPAuthPgmDelete = "PK_NEXCORE.SP_ROLEPGM_DELETE";
        private const string SPAuthDelete = "PK_NEXCORE.SP_ROLE_DELETE";
        private const string SPAuthUpdate = "PK_NEXCORE.SP_ROLE_UPDATE";
        private const string SPAuthInsert = "PK_NEXCORE.SP_ROLE_INSERT";
        private const string SPDupCheck = "PK_NEXCORE.SP_DUP_CHECK";
        private const string SPButtonInsert = "PK_NEXCORE.SP_BUTTON_INSERT";
        private const string SPButtonUpdate = "PK_NEXCORE.SP_BUTTON_UPDATE";
        private const string SPButtonDelete = "PK_NEXCORE.SP_BUTTON_DELETE";
        private const string SPAuthButton = "PK_NEXCORE.SP_ROLEBUTTON_INSERT";
        private const string SPLoadUserButton = "PK_NEXCORE.SP_USERBUTTON_SELECT";

        private DataAccessWrapper _daw;

        #region IAuthorityRepository 멤버

        public void LoadAuthority()
        {
            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAll);

            DataSet dsAuthority = _daw.ExecuteDataSet(selectCmd);

            if (dsAuthority.Tables.Count <= 0 || dsAuthority.Tables[0].Rows.Count <= 0)
                return;

            _AuthorityList = GetAuthorityList(dsAuthority);
        }

        
        public List<Authority> GetAuthority()
        {
            LoadAuthority();
            return _AuthorityList.Values.ToList<Authority>();
        }
        public List<AuthorityPgm> GetAuthorityPgmList(string authId,string all)
        {
            List<AuthorityPgm> pgmAuthPgmList = new List<AuthorityPgm>();

            _daw = new DataAccessWrapper();



            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAuthPgm);
            _daw.AddInParameter(selectCmd, "p_ROLE_ID", DbType.String, authId);
            DataSet dsAuthPgm = _daw.ExecuteDataSet(selectCmd);

            if (dsAuthPgm.Tables.Count <= 0 || dsAuthPgm.Tables[0].Rows.Count <= 0)
                return pgmAuthPgmList;

            foreach (DataRow row in dsAuthPgm.Tables[0].Rows)
            {
                Hashtable htAuthPgm = new Hashtable();

                htAuthPgm["CHK"] = row["CHK"].ToString() ;
                htAuthPgm["AUTH_ID"] = row["ROLE_ID"].ToString();
                htAuthPgm["PGM_ID"] = row["PGM_ID"].ToString();
                htAuthPgm["PGM_NM"] = row["PGM_NM"].ToString();
                //htAuthPgm["SAVE_AUTH"] = row["SAVE_AUTH"].ToString() == "Y" ? "True" : "False";
                //htAuthPgm["READ_AUTH"] = row["READ_AUTH"].ToString() == "Y" ? "True" : "False";
                //htAuthPgm["DEL_AUTH"] = row["DEL_AUTH"].ToString() == "Y" ? "True" : "False";
                //htAuthPgm["EXCEL_AUTH"] = row["EXCEL_AUTH"].ToString() == "Y" ? "True" : "False";
                //htAuthPgm["PRINT_AUTH"] = row["PRINT_AUTH"].ToString() == "Y" ? "True" : "False";
                AuthorityPgm Authpgm = new AuthorityPgm(htAuthPgm);


                pgmAuthPgmList.Add(Authpgm);
            }


            return pgmAuthPgmList;
        }
        public List<AuthorityPgm> GetAuthorityPgm(string authId)
        {
            List<AuthorityPgm> pgmAuthPgmList = new List<AuthorityPgm>();

            _daw = new DataAccessWrapper();



            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAuthPgmList);
            _daw.AddInParameter(selectCmd, "p_ROLE_ID", DbType.String, authId);
            DataSet dsAuthPgm = _daw.ExecuteDataSet(selectCmd);

            if (dsAuthPgm.Tables.Count <= 0 || dsAuthPgm.Tables[0].Rows.Count <= 0)
                return pgmAuthPgmList;

            foreach (DataRow row in dsAuthPgm.Tables[0].Rows)
            {
                Hashtable htAuthPgm = new Hashtable();

                htAuthPgm["CHK"] = row["CHK"].ToString();
                htAuthPgm["AUTH_ID"] = row["ROLE_ID"].ToString();
                htAuthPgm["PGM_ID"] = row["PGM_ID"].ToString();
                htAuthPgm["PGM_NM"] = row["PGM_NM"].ToString();
                AuthorityPgm Authpgm = new AuthorityPgm(htAuthPgm);


                pgmAuthPgmList.Add(Authpgm);
            }


            return pgmAuthPgmList;
        }
        public List<AuthorityButton> GetAuthorityButtonList(string authId, string pgmId)
        {
            List<AuthorityButton> pgmAuthButtonList = new List<AuthorityButton>();

            _daw = new DataAccessWrapper();



            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAuthButton);
            _daw.AddInParameter(selectCmd, "p_ROLE_ID", DbType.String, authId);
            _daw.AddInParameter(selectCmd, "p_PGM_ID", DbType.String, pgmId);
            DataSet dsAuthButton = _daw.ExecuteDataSet(selectCmd);

            if (dsAuthButton.Tables.Count <= 0 || dsAuthButton.Tables[0].Rows.Count <= 0)
                return pgmAuthButtonList;

            foreach (DataRow row in dsAuthButton.Tables[0].Rows)
            {
                Hashtable htAuthbutton = new Hashtable();

                htAuthbutton["AUTH_ID"] = row["ROLE_ID"].ToString();
                htAuthbutton["PGM_ID"] = row["PGM_ID"].ToString();
                htAuthbutton["BUTTON_ID"] = row["BUTTON_ID"].ToString();
                htAuthbutton["BUTTON_NM"] = row["BUTTON_NM"].ToString();
                htAuthbutton["AUTH_YN"] = row["AUTH_YN"].ToString() == "Y" ? "True" : "False";

                AuthorityButton Authbutton = new AuthorityButton(htAuthbutton);


                pgmAuthButtonList.Add(Authbutton);
            }


            return pgmAuthButtonList;
        }
        public List<AuthorityButton> GetUserButtonList(string userId, string pgmId)
        {
            List<AuthorityButton> pgmAuthButtonList = new List<AuthorityButton>();

            _daw = new DataAccessWrapper();



            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadUserButton);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            _daw.AddInParameter(selectCmd, "p_PGM_ID", DbType.String, pgmId);
            DataSet dsAuthButton = _daw.ExecuteDataSet(selectCmd);

            if (dsAuthButton.Tables.Count <= 0 || dsAuthButton.Tables[0].Rows.Count <= 0)
                return pgmAuthButtonList;

            foreach (DataRow row in dsAuthButton.Tables[0].Rows)
            {
                Hashtable htAuthbutton = new Hashtable();

                htAuthbutton["AUTH_ID"] = row["ROLE_ID"].ToString();
                htAuthbutton["PGM_ID"] = row["PGM_ID"].ToString();
                htAuthbutton["BUTTON_ID"] = row["BUTTON_ID"].ToString();
                htAuthbutton["BUTTON_NM"] = row["BUTTON_NM"].ToString();
                htAuthbutton["AUTH_YN"] = row["AUTH_YN"].ToString() ;

                AuthorityButton Authbutton = new AuthorityButton(htAuthbutton);


                pgmAuthButtonList.Add(Authbutton);
            }


            return pgmAuthButtonList;
        }

        public List<UserAuthority> GetUserAuthorityList(string userId)
        {
            List<UserAuthority> userAuthList = new List<UserAuthority>();

            _daw = new DataAccessWrapper();



            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadUserAuth);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            DataSet dsUserAuth = _daw.ExecuteDataSet(selectCmd);

            if (dsUserAuth.Tables.Count <= 0 || dsUserAuth.Tables[0].Rows.Count <= 0)
                return userAuthList;

            foreach (DataRow row in dsUserAuth.Tables[0].Rows)
            {
                Hashtable htUserAuth = new Hashtable();

                htUserAuth["CHK"] = row["CHK"].ToString();
                htUserAuth["AUTH_ID"] = row["ROLE_ID"].ToString();
                htUserAuth["AUTH_NM"] = row["ROLE_NM"].ToString();
                htUserAuth["USER_ID"] = row["USER_ID"].ToString();

                UserAuthority UserAuth = new UserAuthority(htUserAuth);


                userAuthList.Add(UserAuth);
            }


            return userAuthList;
        }
        public List<AuthorityUser> GetAuthorityUserList(string authId,string usernm,string deptnm)
        {
            List<AuthorityUser> AuthuserList = new List<AuthorityUser>();

            _daw = new DataAccessWrapper();



            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAuthUser);
            _daw.AddInParameter(selectCmd, "p_ROLE_ID", DbType.String, authId);
            _daw.AddInParameter(selectCmd, "p_USER_NM", DbType.String, usernm + "%");
            DataSet dsUserAuth = _daw.ExecuteDataSet(selectCmd);

            if (dsUserAuth.Tables.Count <= 0 || dsUserAuth.Tables[0].Rows.Count <= 0)
                return AuthuserList;

            foreach (DataRow row in dsUserAuth.Tables[0].Rows)
            {
                Hashtable htAuthUser = new Hashtable();

                htAuthUser["CHK"] = row["CHK"].ToString();
                htAuthUser["AUTH_ID"] = row["ROLE_ID"].ToString();
                htAuthUser["USER_NM"] = row["USER_NM"].ToString();
                htAuthUser["USER_ID"] = row["USER_ID"].ToString();
                htAuthUser["DEPT_NM"] = row["DEPT_NM"].ToString();
                AuthorityUser AuthUser = new AuthorityUser(htAuthUser);


                AuthuserList.Add(AuthUser);
            }


            return AuthuserList;
        }
        public List<ManagedButton> GetButtonList()
        {
            List<ManagedButton> pgmAuthBtnList = new List<ManagedButton>();

                _daw = new DataAccessWrapper();

            Hashtable htAuthPgm = new Hashtable();


            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadManagedButton);

            DataSet dsButtonAuth = _daw.ExecuteDataSet(selectCmd);

            if (dsButtonAuth.Tables.Count <= 0 || dsButtonAuth.Tables[0].Rows.Count <= 0)
                return pgmAuthBtnList;

            Hashtable htBtnAuth = new Hashtable();


            pgmAuthBtnList = SetButtonList(dsButtonAuth);

            return pgmAuthBtnList;
        }

        public List<ButtonAuthority> GetButtonAuthority(string userId, string pgmId)
        {
            List<ButtonAuthority> pgmAuthBtnList = new List<ButtonAuthority>();

            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadButtonAuth);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            _daw.AddInParameter(selectCmd, "p_PGM_ID", DbType.String, pgmId);
            
            DataSet dsButtonAuth = _daw.ExecuteDataSet(selectCmd);
     
            if (dsButtonAuth.Tables.Count <= 0 || dsButtonAuth.Tables[0].Rows.Count <= 0)
                return pgmAuthBtnList;

            pgmAuthBtnList = SetButtonAuthority(dsButtonAuth);

            return pgmAuthBtnList;
        }

        public bool AddUserAuth(DataRow row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand insertCmd = _daw.GetStoredProcCommand(SPUserAuth);
            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, row["UserId"].ToString());
            _daw.AddInParameter(insertCmd, "p_ROLE_ID", DbType.String, row["AuthId"].ToString());


            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool AddAuthPgm(DataRow row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAuthPgm);
            _daw.AddInParameter(insertCmd, "p_ROLE_ID", DbType.String, row["AuthId"].ToString());
            _daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, row["PgmId"].ToString());
            _daw.AddInParameter(insertCmd, "p_READ_AUTH", DbType.String, row["R"].ToString()=="True" ? "Y" : "N");
            _daw.AddInParameter(insertCmd, "p_SAVE_AUTH", DbType.String, row["C"].ToString() == "True" ? "Y" : "N");
            _daw.AddInParameter(insertCmd, "p_DEL_AUTH", DbType.String, row["D"].ToString() == "True" ? "Y" : "N");
            _daw.AddInParameter(insertCmd, "p_EXCEL_AUTH", DbType.String, row["E"].ToString() == "True" ? "Y" : "N");
            _daw.AddInParameter(insertCmd, "p_PRINT_AUTH", DbType.String, row["P"].ToString() == "True" ? "Y" : "N");
            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool DeleteUserAuth(DataRow row)
        {

            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPUserAuthDelete);
            _daw.AddInParameter(deleteCmd, "p_USER_ID", DbType.String, row["UserId"].ToString());

            int i = _daw.ExecuteNonQuery(deleteCmd);
            if (i > 0) ret = true;
            return ret;
        }
        public bool DeleteAuthPgm(DataRow row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPAuthPgmDelete);
            _daw.AddInParameter(deleteCmd, "p_ROLE_ID", DbType.String, row["AuthId"].ToString());

            int i = _daw.ExecuteNonQuery(deleteCmd);
            if ( i > 0) ret = true;
            return ret;
        }
        public bool AddAuthButton(DataRow row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAuthButton);
            _daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, row["PgmId"].ToString());
            _daw.AddInParameter(insertCmd, "p_BUTTON_ID", DbType.String, row["ButtonId"].ToString());
            _daw.AddInParameter(insertCmd, "p_ROLE_ID", DbType.String, row["AuthId"].ToString());
            _daw.AddInParameter(insertCmd, "p_AUTH_YN", DbType.String, row["AuthYN"].ToString() == "True" ? "Y" : "N");

            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool AddAuthUser(DataRow row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAuthUser);
            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, row["UserId"].ToString());
            _daw.AddInParameter(insertCmd, "p_ROLE_ID", DbType.String, row["AuthId"].ToString());


            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool DeleteAuthUser(DataRow row)
        {

            bool ret = false;
            _daw = new DataAccessWrapper();



            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPAuthUserDelete);
            _daw.AddInParameter(deleteCmd, "p_ROLE_ID", DbType.String, row["AuthId"].ToString());

            int i = _daw.ExecuteNonQuery(deleteCmd);
            if (i > 0) ret = true;
            return ret;
        }
        public bool AddAuth(Hashtable row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAuthInsert);
            _daw.AddInParameter(insertCmd, "p_ROLE_ID", DbType.String, row["ROLE_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_ROLE_NM", DbType.String, row["ROLE_NM"].ToString());
            _daw.AddInParameter(insertCmd, "p_ROLE_DESC", DbType.String, row["ROLE_DESC"].ToString());
            _daw.AddInParameter(insertCmd, "p_USE_YN", DbType.String, row["USE_YN"].ToString());
            _daw.AddInParameter(insertCmd, "p_REG_ID", DbType.String, row["REG_ID"].ToString());

            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool UpdateAuth(Hashtable row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPAuthUpdate);
            _daw.AddInParameter(updateCmd, "p_ROLE_ID", DbType.String, row["ROLE_ID"].ToString());
            _daw.AddInParameter(updateCmd, "p_ROLE_NM", DbType.String, row["ROLE_NM"].ToString());
            _daw.AddInParameter(updateCmd, "p_ROLE_DESC", DbType.String, row["ROLE_DESC"].ToString());
            _daw.AddInParameter(updateCmd, "p_USE_YN", DbType.String, row["USE_YN"].ToString());
            _daw.AddInParameter(updateCmd, "p_REG_ID", DbType.String, row["REG_ID"].ToString());

            int i = _daw.ExecuteNonQuery(updateCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool DeleteAuth(Hashtable row)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPAuthDelete);
            _daw.AddInParameter(deleteCmd, "p_ROLE_ID", DbType.String, row["ROLE_ID"].ToString());


            int i = _daw.ExecuteNonQuery(deleteCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public bool AddButton(ManagedButton button)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPButtonInsert);

            // sql parameter 생성

            this._daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, button.PgmId);
            this._daw.AddInParameter(insertCmd, "p_BUTTON_ID", DbType.String, button.ButtonID);
            this._daw.AddInParameter(insertCmd, "p_BUTTON_NM", DbType.String, button.ButtonName);
            this._daw.AddInParameter(insertCmd, "p_BUTTON_DESC", DbType.String, button.ButtonDescription);
            this._daw.AddInParameter(insertCmd, "p_REG_ID", DbType.String, button.RegId);

            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;
            return ret;
        }
        public bool UpdateButton(ManagedButton button)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPButtonUpdate);

            // sql parameter 생성
            this._daw.AddInParameter(updateCmd, "p_PGM_ID", DbType.String, button.PgmId);
            this._daw.AddInParameter(updateCmd, "p_BUTTON_ID", DbType.String, button.ButtonID);
            this._daw.AddInParameter(updateCmd, "p_BUTTON_NM", DbType.String, button.ButtonName);
            this._daw.AddInParameter(updateCmd, "p_BUTTON_DESC", DbType.String, button.ButtonDescription);
            this._daw.AddInParameter(updateCmd, "p_MOD_ID", DbType.String, button.RegId);

            int i = _daw.ExecuteNonQuery(updateCmd);
            if (i > 0) ret = true;
            return ret;
        }
        public bool DeleteButton(ManagedButton button)
        {
            bool ret = false;
            _daw = new DataAccessWrapper();

            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPButtonDelete);

            // sql parameter 생성
            this._daw.AddInParameter(deleteCmd, "p_PGM_ID", DbType.String, button.PgmId);
            this._daw.AddInParameter(deleteCmd, "p_BUTTON_ID", DbType.String, button.ButtonID);


            int i = _daw.ExecuteNonQuery(deleteCmd);
            if (i > 0) ret = true;
            return ret;

        }
        public int DupCheck(string TableName,string key)
        {
            _daw = new DataAccessWrapper();
            string[] str = key.Split(',');

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPDupCheck);

            _daw.AddInParameter(selectCmd, "p_TABLE", DbType.String, TableName);
            _daw.AddInParameter(selectCmd, "p_KEY1", DbType.String, str.Length > 0 ?  str[0] : "");
            _daw.AddInParameter(selectCmd, "p_KEY2", DbType.String, str.Length > 1 ?  str[1] : "");
            _daw.AddInParameter(selectCmd, "p_KEY3", DbType.String, str.Length > 2 ?  str[2] : "");
            _daw.AddInParameter(selectCmd, "p_KEY4", DbType.String, str.Length > 3 ?  str[3] : "");
            _daw.AddInParameter(selectCmd, "p_KEY5", DbType.String, str.Length > 4 ?  str[4] : "");

            return _daw.ExecuteDataSet(selectCmd).Tables[0].Rows.Count;


        }
        public NEXCOREData GetLogList(string Type, string start,string end)
        {
            _daw = new DataAccessWrapper();

            NEXCOREData data = new NEXCOREData();

            DbCommand selectCmd = _daw.GetStoredProcCommand("PK_NEXCORE.SP_LOG_SELECT");

            _daw.AddInParameter(selectCmd, "p_TYPE_ID", DbType.String,Type);
            _daw.AddInParameter(selectCmd, "p_START_DATE", DbType.String, start);
            _daw.AddInParameter(selectCmd, "p_END_DATE", DbType.String, end);

            data.DataSet = _daw.ExecuteDataSet(selectCmd);

            return data;


        }
        #endregion

        #region Inner Method
        private List<ButtonAuthority> SetButtonAuthority(DataSet dsBtnAuth)
        {
            List<ButtonAuthority> lstBtnAuth = new List<ButtonAuthority>();

            foreach (DataRow drBtnAuth in dsBtnAuth.Tables[0].Rows)
            {
                Hashtable htBtnAuth = new Hashtable();
                htBtnAuth["PGM_ID"] = drBtnAuth["PGM_ID"].ToString();
                htBtnAuth["SAVE_AUTH"] = drBtnAuth["SAVE_AUTH"].ToString();
                htBtnAuth["READ_AUTH"] = drBtnAuth["READ_AUTH"].ToString();
                htBtnAuth["DEL_AUTH"] = drBtnAuth["DEL_AUTH"].ToString();
                htBtnAuth["EXCEL_AUTH"] = drBtnAuth["EXCEL_AUTH"].ToString();
                htBtnAuth["PRINT_AUTH"] = drBtnAuth["PRINT_AUTH"].ToString();
                ButtonAuthority btnAuth = new ButtonAuthority(htBtnAuth);

                lstBtnAuth.Add(btnAuth);
            }

            return lstBtnAuth;
        }

        private List<Program> SetProgramByAuth(DataSet dsPgmAuth)
        {
            List<Program> pgmList = new List<Program>();

            foreach (DataRow drPgm in dsPgmAuth.Tables[0].Rows)
            {
                Hashtable htPgm = new Hashtable();
                htPgm["PGM_ID"] = drPgm["PGM_ID"].ToString();
                htPgm["PGM_PATH"] = drPgm["PGM_PATH"].ToString();
                htPgm["PGM_NM"] = drPgm["PGM_NM"].ToString();
                htPgm["PGM_TYPE"] = drPgm["PGM_TYPE"].ToString();
                htPgm["PGM_DESC"] = drPgm["PGM_DESC"].ToString();
                htPgm["REG_ID"] = drPgm["REG_ID"].ToString();
                htPgm["REG_TIME"] = drPgm["REG_TIME"].ToString();
                htPgm["MOD_ID"] = drPgm["MOD_ID"].ToString();
                htPgm["MOD_TIME"] = drPgm["MOD_TIME"].ToString();

                Program btn = new Program(htPgm);

                pgmList.Add(btn);
            }

            return pgmList;
            
        }

        private List<ManagedButton> SetButtonList(DataSet dsButtonAuth)
        {
            List<ManagedButton> buttnList = new List<ManagedButton>();

            foreach (DataRow drBtnAuth in dsButtonAuth.Tables[0].Rows)
            {

                Hashtable htBtnAuth = new Hashtable();
                htBtnAuth["PGM_ID"] = drBtnAuth["PGM_ID"].ToString();
                htBtnAuth["BUTTON_ID"] = drBtnAuth["BUTTON_ID"].ToString();
                htBtnAuth["BUTTON_NM"] = drBtnAuth["BUTTON_NM"].ToString();
                htBtnAuth["BUTTON_DESC"] = drBtnAuth["BUTTON_DESC"].ToString();
                htBtnAuth["REG_ID"] = drBtnAuth["REG_ID"].ToString();
                htBtnAuth["REG_TIME"] = drBtnAuth["REG_TIME"].ToString();
                htBtnAuth["MOD_ID"] = drBtnAuth["MOD_ID"].ToString();
                htBtnAuth["MOD_TIME"] = drBtnAuth["MOD_TIME"].ToString();

                ManagedButton btn = new ManagedButton(htBtnAuth);

                buttnList.Add(btn);
            }

            return buttnList;
        }

        private Dictionary<string, Authority> GetAuthorityList(DataSet dsAuthority)
        {
            Dictionary<string, Authority> result = new Dictionary<string, Authority>();


            foreach (DataRow drAuth in dsAuthority.Tables[0].Rows)
            {
                Hashtable htCategory = new Hashtable();
                htCategory["AUTH_ID"] = drAuth["ROLE_ID"];
                htCategory["AUTH_NM"] = drAuth["ROLE_NM"];
                htCategory["AUTH_DESC"] = drAuth["ROLE_DESC"];
                htCategory["USE_YN"] = drAuth["USE_YN"];


                Authority auth = new Authority(htCategory);

                result[auth.SysId + auth.AuthId] = auth;
            }

            return result;
        }
        #endregion
    }
}
