using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.Data;
using System.Data;
using NEXCORE.Common.Data;
using System.Data.Common;
using NEXCORE.Utility;
using Oracle.DataAccess.Client;

namespace NEXCORE.Components.UserManager
{
    public class UserRepository : IUserRepository
    {
        #region IUserRepository 멤버
        const string SPLoadUsers = "PK_NEXCORE.SP_USER_LOGINSELECT";
        const string SPGetUsers = "PK_NEXCORE.SP_USER_SELECT";
        const string SPUserLock = "PK_NEXCORE.SP_USER_LOCK";
        const string SPLoginHistory = "PK_NEXCORE.SP_HISLOGIN_INSERT";
        const string SPPgmHistory = "PK_NEXCORE.SP_HISPGM_INSERT";
        const string SPButtonHistory = "PK_NEXCORE.SP_HISBUTTON_INSERT";
        const string SPErrorLog = "PK_NEXCORE.SP_ERROR_INSERT";
        const string SPChangePassword = "PK_NEXCORE.SP_CHANGE_PASSWORD";
        const string SPAddUser = "PK_NEXCORE.SP_USER_INSERT";
        const string SPUpdateUser = "PK_NEXCORE.SP_USER_UPDATE";
        const string SPDeleteUser = "PK_NEXCORE.SP_USER_DELETE";
        const string SPEtcUpdateUser = "PK_NEXCORE.SP_USER_ETC_UPDATE";

        Dictionary<string, User> dicUserList;
        DataAccessWrapper _daw = null;
        //public void LoadWMSUsers()
        //{
        //    dicUserList = new Dictionary<string, User>();

        //    SK.WMS.Repository.UserRepository userRepo = new SK.WMS.Repository.UserRepository();
        //    DataSet ds = NEXCORE.Utility.UtilityHelper.ToDataSet<UserEntity>(userRepo.SelectUserInfo());

        //    if (ds != null && ds.Tables.Count > 0)
        //    {
        //        foreach(DataRow row in ds.Tables[0].Rows)
        //        {
        //            User user = LoadUsers(row);

        //            dicUserList.Add(user.UserId, user);
        //        }
        //    }
        //}

        //로그인한 사용자 정보만 DB 에서 가져오기 
        public IList<User> LoadWMSLoginUser(string userId)
        {

            dicUserList = new Dictionary<string, User>();
            _daw = new DataAccessWrapper();
            
            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadUsers);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            //_daw.AddOutParameter(selectCmd, "p_RET", DbType.Object, 8);
            //((OracleParameter)selectCmd.Parameters["p_RET"]).OracleDbType = OracleDbType.RefCursor;
            //_daw.AddOutParameter(selectCmd, "p_RET1", DbType.Object, 8);
            //((OracleParameter)selectCmd.Parameters["p_RET1"]).OracleDbType = OracleDbType.RefCursor;


            DataSet ds = _daw.ExecuteDataSet(selectCmd);         

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {

                
                User user = LoadUsers(ds.Tables[0].Rows[0]);                
                if (dicUserList.ContainsKey(user.UserId))
                    dicUserList[user.UserId] = user;
                else
                    dicUserList.Add(user.UserId, user);                
            }
            
            return dicUserList.Values.ToList<User>();
        }
        public void LoadWMSUser(string userId)
        {
            _daw = new DataAccessWrapper();
            dicUserList = new Dictionary<string, User>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadUsers);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, userId);
            //_daw.AddOutParameter(selectCmd, "p_RET", DbType.Object, 20000);
            //((OracleParameter)selectCmd.Parameters["p_RET"]).OracleDbType = Oracle.DataAccess.Client.OracleDbType.RefCursor;
            //_daw.AddOutParameter(selectCmd, "p_RET1", DbType.Object, 20000);
            //((OracleParameter)selectCmd.Parameters["p_RET1"]).OracleDbType = Oracle.DataAccess.Client.OracleDbType.RefCursor;
            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {


                User user = LoadUsers(ds.Tables[0].Rows[0]);
                if (dicUserList.ContainsKey(user.UserId))
                    dicUserList[user.UserId] = user;
                else
                    dicUserList.Add(user.UserId, user);
            }

            
        }

        public List<User> GetUserList(string usernm)
        {
            _daw = new DataAccessWrapper();
            dicUserList = new Dictionary<string, User>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPGetUsers);
            _daw.AddInParameter(selectCmd, "p_USER_NM", DbType.String, usernm + '%');
            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {


                    User user = LoadUsers(ds.Tables[0].Rows[i]);

                    dicUserList.Add(user.UserId, user);
                }
            }

            return dicUserList.Values.ToList<User>();
        }

        public bool LoginHistory(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPLoginHistory);

            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, data.Hashtable["USER_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_LOGIN_ID", DbType.String, data.Hashtable["LOGIN_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_LOGIN_PW", DbType.String, data.Hashtable["LOGIN_PW"].ToString());
            _daw.AddInParameter(insertCmd, "p_STATE", DbType.String, data.Hashtable["STATE"].ToString());
            _daw.AddInParameter(insertCmd, "p_USER_IP", DbType.String, data.Hashtable["USER_IP"].ToString());
            _daw.AddInParameter(insertCmd, "p_CONNECTED_SERVER", DbType.String, data.Hashtable["CONNECTED_SERVER"].ToString());
            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        public bool PgmHistory(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPPgmHistory);

            
            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, data.Hashtable["USER_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, data.Hashtable["PGM_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_LOADING_TIME", DbType.String, data.Hashtable["LOADING_TIME"].ToString());
            _daw.AddInParameter(insertCmd, "p_STATE", DbType.String, data.Hashtable["STATE"].ToString());
            _daw.AddInParameter(insertCmd, "p_RESULT_LOG", DbType.String, data.Hashtable["RESULT_LOG"].ToString());
            _daw.AddInParameter(insertCmd, "p_USER_IP", DbType.String, data.Hashtable["USER_IP"].ToString());
            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        public bool ButtonHistory(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPButtonHistory);


            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, data.Hashtable["USER_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, data.Hashtable["PGM_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_BUTTON_ID", DbType.String, data.Hashtable["BUTTON_ID"].ToString());
            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        public bool ErrorLog(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPErrorLog);

            _daw.AddInParameter(insertCmd, "p_ERROR_PGM_ID", DbType.String, data.Hashtable["ERROR_PGM_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_ERROR_IP", DbType.String, data.Hashtable["ERROR_IP"].ToString());
            _daw.AddInParameter(insertCmd, "p_ERROR_COMPUTER", DbType.String, data.Hashtable["ERROR_COMPUTER"].ToString());
            _daw.AddInParameter(insertCmd, "p_ERROR_DESC", DbType.String, data.Hashtable["ERROR_DESC"].ToString());
            _daw.AddInParameter(insertCmd, "p_REG_ID", DbType.String, data.Hashtable["REG_ID"].ToString());
            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        public void LoadUsers()
        {
            _daw = new DataAccessWrapper();
            dicUserList = new Dictionary<string, User>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadUsers);
            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            if (ds != null && ds.Tables.Count > 0)
            {
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    User user = LoadUsers(row);

                    dicUserList.Add(user.UserId, user);
                }
            }
        }

        public IList<User> GetUsers()
        {
            return dicUserList.Values.ToList<User>();
        }
        public bool ChangePassword(string userId, string password)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPChangePassword);
            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, userId);
            _daw.AddInParameter(insertCmd, "p_PASSWORD", DbType.String, password);

            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        
        public bool ModifyLockUser(string userId,string lockyn)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPUserLock);
            _daw.AddInParameter(insertCmd, "p_USER_ID", DbType.String, userId);
            _daw.AddInParameter(insertCmd, "p_LOCK", DbType.String, lockyn);

            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        public bool AddUser(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAddUser);

            _daw.AddInParameter(insertCmd, "p_USER_ID"  ,   DbType.String, data.Hashtable["USER_ID"].ToString());
            _daw.AddInParameter(insertCmd, "p_PASSWORD"   ,       DbType.String, data.Hashtable["PASSWORD"].ToString());
            _daw.AddInParameter(insertCmd, "p_USER_NM", DbType.String, data.Hashtable["USER_NM"].ToString());
            _daw.AddInParameter(insertCmd, "p_EMAIL"      ,     DbType.String, data.Hashtable["EMAIL"].ToString());
            _daw.AddInParameter(insertCmd, "p_TEL_WORK"   ,         DbType.String, data.Hashtable["TEL_WORK"].ToString());
            _daw.AddInParameter(insertCmd, "p_TEL_MOBILE" ,   DbType.String, data.Hashtable["TEL_MOBILE"].ToString());
            _daw.AddInParameter(insertCmd, "p_USE_YN"     ,     DbType.String, data.Hashtable["USE_YN"].ToString());
            _daw.AddInParameter(insertCmd, "p_REG_ID"     ,         DbType.String, data.Hashtable["REG_ID"].ToString());


            int i = _daw.ExecuteNonQuery(insertCmd);
            if (i > 0) ret = true;

            return ret;
        }
        public bool UpdateUser(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPUpdateUser);

            _daw.AddInParameter(updateCmd, "p_USER_ID", DbType.String, data.Hashtable["USER_ID"].ToString());
            _daw.AddInParameter(updateCmd, "p_PASSWORD", DbType.String, data.Hashtable["PASSWORD"].ToString());
            _daw.AddInParameter(updateCmd, "p_USER_NM", DbType.String, data.Hashtable["USER_NM"].ToString());
            _daw.AddInParameter(updateCmd, "p_EMAIL", DbType.String, data.Hashtable["EMAIL"].ToString());
            _daw.AddInParameter(updateCmd, "p_TEL_WORK", DbType.String, data.Hashtable["TEL_WORK"].ToString());
            _daw.AddInParameter(updateCmd, "p_TEL_MOBILE", DbType.String, data.Hashtable["TEL_MOBILE"].ToString());
            _daw.AddInParameter(updateCmd, "p_USE_YN", DbType.String, data.Hashtable["USE_YN"].ToString());
            _daw.AddInParameter(updateCmd, "p_REG_ID", DbType.String, data.Hashtable["REG_ID"].ToString());



            int i = _daw.ExecuteNonQuery(updateCmd);
            if (i > 0) ret = true;

            return ret;
        }


        public bool EtcUpdateUser(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPEtcUpdateUser);

            _daw.AddInParameter(updateCmd, "p_USER_ID", DbType.String, data.Hashtable["USER_ID"].ToString());
            _daw.AddInParameter(updateCmd, "p_EMAIL", DbType.String, data.Hashtable["EMAIL"].ToString());
            _daw.AddInParameter(updateCmd, "p_TEL_WORK", DbType.String, data.Hashtable["TEL_WORK"].ToString());
            _daw.AddInParameter(updateCmd, "p_TEL_MOBILE", DbType.String, data.Hashtable["TEL_MOBILE"].ToString());
            int i = _daw.ExecuteNonQuery(updateCmd);
            if (i > 0) ret = true;

            return ret;
        }

        public bool DeleteUser(NEXCOREData data)
        {
            _daw = new DataAccessWrapper();
            bool ret = false;

            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPDeleteUser);

            _daw.AddInParameter(deleteCmd, "p_USER_ID", DbType.String, data.Hashtable["USER_ID"].ToString());
            int i = _daw.ExecuteNonQuery(deleteCmd);
            if (i > 0) ret = true;

            return ret;
        }

        #endregion

        #region Inner Method

        private User LoadUsers(DataRow row)
        {
            User user = new User(row);

            return user;
        }

        #endregion
    }
}