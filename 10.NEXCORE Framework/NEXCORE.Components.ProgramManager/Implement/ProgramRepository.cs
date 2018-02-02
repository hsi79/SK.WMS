using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using Skcc.Data;
using System.Data;
using System.Collections;
using System.Data.Common;

namespace NEXCORE.Components.ProgramManager
{
    public class ProgramRepository 
    {
        private DataAccessWrapper _daw;
        private const string SPLoadAll = "PK_NEXCORE.SP_PGM_SELECTALL";
        private const string SPAddProgram = "PK_NEXCORE.SP_PGM_INSERT";
        private const string SPDeleteProgram = "PK_NEXCORE.SP_PGM_DELETE";
        private const string SPUpdateProgram = "PK_NEXCORE.SP_PGM_UPDATE";
        private Dictionary<string, Program> _dicProgramList;
        private Dictionary<string, Program> _dicProgramSelect;
        public void LoadWMSProgram()
        {
            _daw = new DataAccessWrapper();
            _dicProgramList = new Dictionary<string, Program>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAll);

            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Program pgm = new Program();

                pgm.PgmId = row["PGM_ID"].ToString();
                pgm.PgmPath = row["PGM_ASSEMBLY"].ToString() + "." + row["PGM_CLASS"].ToString();
                pgm.PgmAssembly = row["PGM_ASSEMBLY"].ToString() ;
                pgm.PgmClass = row["PGM_CLASS"].ToString();
                pgm.PgmName = row["PGM_NM_KR"].ToString();
                pgm.PgmType = row["PGM_TYPE"].ToString();
                pgm.PgmDescription = row["PGM_DESC"].ToString();
                pgm.AuthYN = row["AUTH_YN"].ToString();
                pgm.RegId = row["REG_ID"].ToString();
                pgm.RegTime = row["REG_TIME"] == DBNull.Value ? null : (DateTime?)DateTime.Parse(row["REG_TIME"].ToString());
                pgm.ModId = row["MOD_ID"].ToString();
                pgm.ModTime = row["MOD_TIME"] == DBNull.Value ? null : (DateTime?)DateTime.Parse(row["MOD_TIME"].ToString());

                _dicProgramList.Add(pgm.PgmId, pgm);
            }
        }

        #region IProgramRepository 멤버

        public void LoadProgram(string pgmId)
        {
            _daw = new DataAccessWrapper();
            _dicProgramSelect = new Dictionary<string, Program>();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAll);

            DataSet ds = _daw.ExecuteDataSet(selectCmd);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row["PGM_ID"].ToString().ToUpper().Contains(pgmId))
                {
                    Program pgm = new Program();

                    pgm.PgmId = row["PGM_ID"].ToString();
                    pgm.PgmPath = row["PGM_ASSEMBLY"].ToString() + "." + row["PGM_CLASS"].ToString();
                    pgm.PgmAssembly = row["PGM_ASSEMBLY"].ToString();
                    pgm.PgmClass = row["PGM_CLASS"].ToString();
                    pgm.PgmName = row["PGM_NM_KR"].ToString();
                    pgm.PgmType = row["PGM_TYPE"].ToString();
                    pgm.PgmDescription = row["PGM_DESC"].ToString();
                    pgm.AuthYN = row["AUTH_YN"].ToString();
                    pgm.RegId = row["REG_ID"].ToString();
                    pgm.RegTime = row["REG_TIME"] == DBNull.Value ? null : (DateTime?)DateTime.Parse(row["REG_TIME"].ToString());
                    pgm.ModId = row["MOD_ID"].ToString();
                    pgm.ModTime = row["MOD_TIME"] == DBNull.Value ? null : (DateTime?)DateTime.Parse(row["MOD_TIME"].ToString());

                    _dicProgramSelect.Add(pgm.PgmId, pgm);
                }
            }
        }

        public List<NEXCORE.Common.Data.Program> GetProgramList()
        {
            //LoadProgram();
            return this._dicProgramList.Values.ToList<Program>();
        }
        public List<NEXCORE.Common.Data.Program> GetProgramList(string pgmId)
        {
            LoadProgram(pgmId);

            return this._dicProgramSelect.Values.ToList<Program>();
        }
        public void AddProgram(Program program)
        {
            _daw = new DataAccessWrapper();

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAddProgram);

            // sql parameter 생성

            this._daw.AddInParameter(insertCmd, "p_PGM_ID", DbType.String, program.PgmId);
            this._daw.AddInParameter(insertCmd, "p_PGM_PATH", DbType.String, program.PgmPath);
            this._daw.AddInParameter(insertCmd, "p_PGM_ASSEMBLY", DbType.String, program.PgmAssembly);
            this._daw.AddInParameter(insertCmd, "p_PGM_CLASS", DbType.String, program.PgmClass);
            this._daw.AddInParameter(insertCmd, "p_PGM_NM_KR", DbType.String, program.PgmName);
            this._daw.AddInParameter(insertCmd, "p_PGM_NM_EN", DbType.String, program.PgmName);
            this._daw.AddInParameter(insertCmd, "p_PGM_TYPE", DbType.String, program.PgmType);
            this._daw.AddInParameter(insertCmd, "p_PGM_DESC", DbType.String, program.PgmDescription);
            this._daw.AddInParameter(insertCmd, "p_AUTH_YN", DbType.String, program.AuthYN);
            this._daw.AddInParameter(insertCmd, "p_REG_ID", DbType.String, program.RegId );

            _daw.ExecuteNonQuery(insertCmd);
        }


        public void UpdateProgram(Program program)
        {
            _daw = new DataAccessWrapper();

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPUpdateProgram);

            // sql parameter 생성
            this._daw.AddInParameter(updateCmd, "p_PGM_ID", DbType.String, program.PgmId);
            this._daw.AddInParameter(updateCmd, "p_PGM_PATH", DbType.String, program.PgmPath);
            this._daw.AddInParameter(updateCmd, "p_PGM_ASSEMBLY", DbType.String, program.PgmAssembly);
            this._daw.AddInParameter(updateCmd, "p_PGM_CLASS", DbType.String, program.PgmClass);
            this._daw.AddInParameter(updateCmd, "p_PGM_NM_KR", DbType.String, program.PgmName);
            this._daw.AddInParameter(updateCmd, "p_PGM_NM_EN", DbType.String, program.PgmName);
            this._daw.AddInParameter(updateCmd, "p_PGM_TYPE", DbType.String, program.PgmType);
            this._daw.AddInParameter(updateCmd, "p_PGM_DESC", DbType.String, program.PgmDescription);
            this._daw.AddInParameter(updateCmd, "p_AUTH_YN", DbType.String, program.AuthYN); 
            this._daw.AddInParameter(updateCmd, "p_MOD_ID", DbType.String, program.RegId);

            _daw.ExecuteNonQuery(updateCmd);
        }

        public void DeleteProgram(Program program)
        {
            _daw = new DataAccessWrapper();

            DbCommand deleteCmd = _daw.GetStoredProcCommand(SPDeleteProgram);

            // sql parameter 생성
            this._daw.AddInParameter(deleteCmd, "p_PGM_ID", DbType.String, program.PgmId);


            _daw.ExecuteNonQuery(deleteCmd);

        }
        #endregion
    }
}
