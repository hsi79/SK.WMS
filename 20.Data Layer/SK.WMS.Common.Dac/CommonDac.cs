/*
* 프로그램ID: TAUTHDac
* 프로그램명: 기준정보Dac
* 설      명 :기준정보를 위한 Dac
* 작  성  자: 
* 최초작성일: 2012-06-14
* 최종변경일: 
* 2012-06-14: 최초 생성

*/
using System;
using System.Data.Common;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Skcc;
using Skcc.Data;
using Skcc.Transactions;
using NEXCORE.Common;
using NEXCORE.Common.Data;
using Oracle.DataAccess.Client;

namespace SK.WMS.Common.Dac
{
    /// <summary>
    ///   DB 연결
    /// </summary>
    /// <param name=""></param>
    /// <returns>N/A</returns>
    public class CommonDac : SKDacBase
    {
        /// <summary>
        ///  생성자를 주석처리하면 Default DB 연결
        /// </summary>
        public CommonDac()
            
        {
        }
        
        
            // 코드 카테고리 정보를 읽어옴.

            
        #region SP 변수 설정

        #region 화면별 SP 설정
        /// <summary>
        /// test
        /// </summary>
        private string spTest = "PK_NEXCORE.SP_SELECT";
        private string spKSMTest = "PK_NEXCORE.SP_KSMTEST_SELECT";

        #endregion

        #endregion





        #region  조회

        /// <summary>
        ///  조회
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet Select(Hashtable dicParam) //--업무에 맞게 변경 
        {
            // make command
            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(spTest);
            _daw.AddInParameter(selectCmd, "p_USER_ID", DbType.String, dicParam["p_USER_ID"].ToString());
            _daw.AddOutParameter(selectCmd, "p_Header", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Header"]).OracleDbType = OracleDbType.RefCursor;
            _daw.AddOutParameter(selectCmd, "p_Data", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Data"]).OracleDbType = OracleDbType.RefCursor;

            return _daw.ExecuteDataSet(selectCmd);
        }
        public DataSet KSMTEST_Select(Hashtable dicParam) //--업무에 맞게 변경 
        {
            // make command
            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(spKSMTest);
            _daw.AddInParameter(selectCmd, "p_IN", DbType.String, dicParam["p_USER_ID"].ToString());
            _daw.AddOutParameter(selectCmd, "P_HEADER", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Header"]).OracleDbType = OracleDbType.RefCursor;
            _daw.AddOutParameter(selectCmd, "P_DATA", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Data"]).OracleDbType = OracleDbType.RefCursor;

            return _daw.ExecuteDataSet(selectCmd);
        }
        #endregion


        // names of stored procedure
        private string spSelectCombo = "PK_NEXCORE.SP_T_CCM_PROCESS_SELECT_COMBO";
        private string spSelectCode = "PK_NEXCORE.SP_T_CCM_CODE_SELECT";
        private string spSelectTEAM = "PK_NEXCORE.SP_T_CCM_DEPT_SELECT_TEAM";
        private string spSelectSUBTEAM_and_TEAM = "PK_NEXCORE.SP_T_CCM_DEPT_SELECT_SUBTEAM_and_TEAM";
        private string spSelectBAN = "PK_NEXCORE.SP_T_CCM_DEPT_SELECT_BAN";
        private string spSelectMainMenuItem = "PK_NEXCORE.SP_T_CCM_MASTER_MainMenuItem_SELECT";

        /// <summary>
        /// SP_T_CCM_PROCESS_SELECT_COMBO를 이용하여 Table의 정보를 DataSet으로 가져온다.
        /// Parameter : LVL, SU_CODE, PGM_GBN
        /// </summary>
        public DataSet SelectT_CCM_PROCESS_COMBO(Hashtable row)
        {
            // make command
            DbCommand Cmd = this.DbAccess.GetStoredProcCommand(spSelectCombo);

            // sql parameter 생성
            this.DbAccess.AddInParameter(Cmd, "p_LVL", DbType.String, row["LVL"]);
            this.DbAccess.AddInParameter(Cmd, "p_SU_CODE", DbType.String, row["SU_CODE"]);
            this.DbAccess.AddInParameter(Cmd, "p_PGM_GBN", DbType.String, row["PGM_GBN"]);

            return this.DbAccess.ExecuteDataSet(Cmd);
        }

        /// <summary>
        /// SP_T_CCM_CODE_SELECT를 이용하여 Table의 Code 정보를 DataSet으로 가져온다.
        /// MenuMgmt.cs, UserMgmt.cs
        /// </summary>
        public DataSet SelectT_CCM_CODE(Hashtable ht)
        {
            // make command
            DbCommand selectCmd = this.DbAccess.GetStoredProcCommand(spSelectCode);

            // sql parameter 생성
            this.DbAccess.AddInParameter(selectCmd, "p_CODE_ID", DbType.String, ht["CODE_ID"]);
            this.DbAccess.AddInParameter(selectCmd, "p_PGM_GBN", DbType.String, ht["PGM_GBN"]);

            return this.DbAccess.ExecuteDataSet(selectCmd);
        }

        /// <summary>
        /// SP_T_CCM_DEPT_TEAM를 이용하여 Table의 TEAM 정보를 DataSet으로 가져온다.
        /// UserMgmt.cs
        /// </summary>
        public DataSet SelectT_CCM_DEPT_TEAM(Hashtable ht)
        {
            // make command
            DbCommand selectCmd = this.DbAccess.GetStoredProcCommand(spSelectTEAM);

            // sql parameter 생성
            //this.DbAccess.AddInParameter(selectCmd, "p_CODE_ID", DbType.String, ht["CODE_ID"]);

            return this.DbAccess.ExecuteDataSet(selectCmd);
        }

        /// <summary>
        /// SP_T_CCM_DEPT_SUBTEAM를 이용하여 Table의 SUBTEAM 정보를 DataSet으로 가져온다.
        /// UserMgmt.cs
        /// </summary>
        public DataSet SelectT_CCM_DEPT_SUBTEAM_and_TEAM(Hashtable ht)
        {
            // make command
            DbCommand selectCmd = this.DbAccess.GetStoredProcCommand(spSelectSUBTEAM_and_TEAM);

            // sql parameter 생성
            //this.DbAccess.AddInParameter(selectCmd, "p_CODE_ID", DbType.String, ht["CODE_ID"]);

            return this.DbAccess.ExecuteDataSet(selectCmd);
        }

        /// <summary>
        /// SP_T_CCM_DEPT_BAN를 이용하여 Table의 BAN 정보를 DataSet으로 가져온다.
        /// UserMgmt.cs
        /// </summary>
        public DataSet SelectT_CCM_DEPT_BAN(Hashtable ht)
        {
            // make command
            DbCommand selectCmd = this.DbAccess.GetStoredProcCommand(spSelectBAN);

            // sql parameter 생성
            this.DbAccess.AddInParameter(selectCmd, "p_SU_DEPT", DbType.String, ht["SU_DEPT"]);

            return this.DbAccess.ExecuteDataSet(selectCmd);
        }

        /// <summary>
        /// SP_T_CCM_MASTER_MainMenuItem_SELECT를 이용하여 Table의 Code 정보를 DataSet으로 가져온다.
        /// MainForm.cs
        /// </summary>
        public DataSet SelectT_CCM_MASTER_MainMenuItem(Hashtable ht)
        {
            // make command
            DbCommand selectCmd = this.DbAccess.GetStoredProcCommand(spSelectMainMenuItem);

            // sql parameter 생성
            this.DbAccess.AddInParameter(selectCmd, "p_PLANT", DbType.String, ht["PLANT"]);
            this.DbAccess.AddInParameter(selectCmd, "p_PROCESS", DbType.String, ht["PROCESS"]);
            this.DbAccess.AddInParameter(selectCmd, "p_UNIT_NO", DbType.String, ht["UNIT"]);
            this.DbAccess.AddInParameter(selectCmd, "p_ITEM_NO", DbType.String, ht["ITEM"]);
            this.DbAccess.AddInParameter(selectCmd, "p_MODULE_TYPE", DbType.String, ht["MODULE_TYPE"]);

            return this.DbAccess.ExecuteDataSet(selectCmd);
        }





    }
}
