using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Skcc.Data;
using Skcc.Transactions;

namespace NEXCORE.Common
{
    public class SKDacBase : DacBase
    {
         /// 
        /// Common 데이터 액세스 컴포넌트
        ///



        protected DataAccessWrapper _daw = null;

        public DataAccessWrapper DbAccess
        {
            get { return _daw; }
            set { _daw = value; }
        }

        // 기본 연결 문자열
        private string _connectionString = string.Empty;

        protected string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public SKDacBase(string connectionString)
        {
            _connectionString = connectionString;
            InitializeDataAccess();
        }

        /// 
        /// create new instance of DataAccessWrapper
        ///
        public SKDacBase()
        {
            InitializeDataAccess();
        }

        private void InitializeDataAccess()
        {
            if (string.IsNullOrEmpty(_connectionString) == true)
            {
                //_connectionString = SetConnectionString();
            }

            if (string.IsNullOrEmpty(_connectionString) == false)
            {
                _daw = new DataAccessWrapper(_connectionString);
                
            }
            else
            {
                _daw = new DataAccessWrapper();
            }

            //string xmlFilePath = SetXmlFilePath();

            //if (string.IsNullOrEmpty(xmlFilePath) == false)
            //{
            //    string xmlFileFullPath = Global.RootPhysicalPath + CommonHelper.GetNEXCOREConfig("BasePathOfSqlXmlFiles") + xmlFilePath;

            //    if (string.IsNullOrEmpty(xmlFileFullPath) == false)
            //        _daw.FileName = xmlFileFullPath;
            //}
        }

        // 프로젝트에 특화된 내용을 여기에 추가하거나, 재정의하는 곳임.

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual string SetConnectionString()
        {
            return string.Empty;
        }

        protected virtual string SetXmlFilePath()
        {
            return string.Empty;
        }
    }
}
