using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.Data;
using System.Data;
using System.Collections;
using System.IO;
using System.Reflection;

namespace NEXCORE.Components.FormManager
{
    public class FormRepository : IFormRepository
    {
        #region Memeber Variables & Properties

        /// <summary>
        /// Setter Injection으로 값이 채워 지며,
        /// 만약 Injection으로 값이 넘어 오지 않을 경우
        /// Dll File의 Path는 App Config에 정의 되어 있는 값으로 하며
        /// App Config에도 정의가 되어 있지 않을 경우
        /// 현재 위치로 설정 한다.
        /// </summary>
        private string AssemblyPath;

        /// <summary>
        /// Setter Injection
        /// Connection String의 명
        /// </summary>
        private string ConnectionName =string.Empty;

        private DataAccessWrapper _daw;
        private const string SPLoadAll = "PK_NEXCORE.SP_SKS_PGM_SELECTALL";
        private Dictionary<string, Program> dicProgramList = new Dictionary<string, Program>();
        private Dictionary<string, Type> dicForms = new Dictionary<string, Type>();


        #endregion

        #region IFormRepository Members
        public IProgram GetProgram(string pgmId)
        {
            return this.dicProgramList[pgmId];
        }
        public bool LoadForm()
        {
            //Skcc.Diagnostics.Logger.Write("Start Loading Forms....", 0, 0, Skcc.Diagnostics.LogLevel.DEBUG);

            if (String.IsNullOrEmpty(AssemblyPath))
            {
                try
                {
                    //App.Config에 설정이 되어 있는 지 확인 한다.                 
                    AssemblyPath = Skcc.Configuration.SkccFxConfigManager.GetString("FormsAssemblyPath");
                }
                catch { }

                if (String.IsNullOrEmpty(AssemblyPath))
                {
                    //아무 설정도 없을 경우 현재 위치를 Default 설정
                    AssemblyPath = @".\";
                }

            }

            LoadProgramFromDatabase();
            LoadFormFromPath();

            return true;
        }

       

        public Dictionary<string, Type> Forms
        {
            get { return dicForms; }
        }

        public void Dispose()
        {
            dicProgramList = null;
            dicForms = null;
            _daw = null;
        }

        #endregion


        #region Private Method
        private void LoadFormFromPath()
        {
            DirectoryInfo dInfo = new DirectoryInfo(AssemblyPath);

            foreach (FileInfo fInfo in dInfo.GetFiles("*.dll"))
            {
                Assembly formDll = Assembly.LoadFrom(fInfo.FullName);

                Type[] types = formDll.GetTypes();

                foreach (Type t in types)
                {
                    AddToFormList(t);                  
                }
                
            }
        }

        private void AddToFormList(Type t)
        {
            if (t.BaseType == null)
                return;

            string baseTypeName = t.BaseType.Name;

            switch (baseTypeName)
            {
                case "Form":
                case "SKCForm":
                case "SKDialogBase":
                    this.dicForms.Add(t.FullName, t);
                    break;
            }
        }

        private void LoadProgramFromDatabase()
        {
            if (String.IsNullOrEmpty(ConnectionName))
                _daw = new DataAccessWrapper();
            else
                _daw = new DataAccessWrapper(ConnectionName);

            DataSet dsPGM = _daw.ExecuteDataSet(SPLoadAll);

            if (dsPGM.Tables.Count > 0 && dsPGM.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in dsPGM.Tables[0].Rows)
                {
                    Hashtable ht = new Hashtable();


                    ht.Add("ID", row["PGM_ID"]);
                    ht.Add("PATH", row["PGM_PATH"]);
                    ht.Add("NAME", row["PGM_NM"]);
                    ht.Add("TYPE", row["PGM_TYPE"]);
                    ht.Add("DESCRIPTION", row["PGM_DESC"]);

                    Program pgm = new Program();
                    pgm.Initilize(ht);

                    this.dicProgramList.Add(pgm.Id, pgm);

                }
            }
        }
        #endregion

    }
}
