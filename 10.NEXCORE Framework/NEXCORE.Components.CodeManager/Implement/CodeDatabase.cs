using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Skcc.Data;
using System.Data;
using System.Data.Common;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using Oracle.DataAccess.Client;


namespace NEXCORE.Components.CodeManager
{
    public class CodeDatabase : ICodeRepository
    {
        private Hashtable CodeList = new Hashtable();
        private Dictionary<string, Code> _dicCodeList;
        private const string SPLoadAll = "PK_NEXCORE.SP_CODE_DTL_SELECTALL";
        private const string SPCODEMSTSELECTALL = "PK_NEXCORE.SP_CODE_MST_SELECTALL";

        DataAccessWrapper _daw = null;
        #region ICodeRepository Members

        public bool LoadCode()
        {
            // 코드 카테고리 정보를 읽어옴.
            _dicCodeList = new Dictionary<string, Code>();

            _daw = new DataAccessWrapper();
            DbCommand selectCmd = _daw.GetStoredProcCommand(SPCODEMSTSELECTALL);
            DataSet dsCodeMaster = _daw.ExecuteDataSet(selectCmd);

            CodeList = new Hashtable();

            foreach (DataRow drCodeMaster in dsCodeMaster.Tables[0].Rows)
            {
                Code parent = new Code();

                try
                {
                    parent.Id = drCodeMaster["CODE_TYPE"] == null ? string.Empty : drCodeMaster["CODE_TYPE"].ToString();
                    parent.Name = drCodeMaster["CODE_NM"] == null ? string.Empty : drCodeMaster["CODE_NM"].ToString();

                    parent.Description = drCodeMaster["CODE_DESC"] == null ? string.Empty : drCodeMaster["CODE_DESC"].ToString();
                    parent.CategoryValue = drCodeMaster["CODE_NM"] == null ? string.Empty : drCodeMaster["CODE_NM"].ToString();
                    parent.Status = drCodeMaster["USE_YN"] == null ? string.Empty : drCodeMaster["USE_YN"].ToString();
                    parent.Children = new List<Code>();

                    CodeList[parent.Id] = parent;

                    _dicCodeList.Add(parent.Id, parent);
                }
                catch { }
            }

            // 코드 상세 정보를 읽어옴.

            DbCommand selectCmd1 = _daw.GetStoredProcCommand(SPLoadAll);
            DataSet dsCode = _daw.ExecuteDataSet(selectCmd1);


            foreach (DataRow drCode in dsCode.Tables[0].Rows)
            {
                try
                {
                    Code each = new Code();
                    each.pkId = drCode["CODE_TYPE"].ToString() + ":" + drCode["CODE"].ToString();
                    each.Id = drCode["CODE"].ToString();
                    each.Name = drCode["CODE_NM"].ToString();

                    each.Description = drCode["CODE_DESC"].ToString();
                    each.CategoryValue = drCode["CODE_TYPE"].ToString();
                    each.Status = drCode["USE_YN"].ToString();
                    each.Children = new List<Code>();


                    CodeList[each.pkId] = each;

                    
                    // 코드의 부모 코드를 찾아서 부모로 설정함.
                    if (CodeList[drCode["CODE_TYPE"].ToString()] != null)
                    {
                        Code pCode = (Code)CodeList[drCode["CODE_TYPE"].ToString()];
                        each.Parent = pCode;
                        each.ParentId = pCode.Id;
                        //pCode.Children.Add(each);
                    }

                    _dicCodeList.Add(each.pkId, each);
                }
                catch { }
            }
            return true;
        }

        public Code GetCode(string codeId)
        {
            if (CodeList.Contains(codeId))
            {
                return (Code)CodeList[codeId];
            }

            return null;
        }

        #endregion

        #region IDisposable Implememt

        public void Dispose()
        {
            CodeList = null;
        }

        #endregion

        #region Inner Method


        private Hashtable GetCodeList(DataSet dsCodes)
        {
            // 상세 
            Hashtable result = new Hashtable();


            foreach (DataRow drCodeMaster in dsCodes.Tables[1].Rows)
            {

                try
                {
                    Code parent = new Code();


                    parent.Id = drCodeMaster["CODE_TYPE"].ToString();
                    parent.Name = drCodeMaster["CODE_NM"].ToString();

                    parent.Description = drCodeMaster["CODE_DESC"].ToString();
                    parent.CategoryValue = drCodeMaster["CODE_NM"].ToString();
                    parent.Status = drCodeMaster["USE_YN"].ToString();
                    parent.Children = new List<Code>();

                    result[parent.Id] = parent;
                }
                catch { }
            }

            
            foreach (DataRow drCode in dsCodes.Tables[0].Rows)
            {

                try
                {
                    Code each = new Code();

                    each.Id = drCode["CODE_TYPE"].ToString() ;
                    each.Name = drCode["CODE_NM"].ToString();

                    each.Description = drCode["CODE_DESC"].ToString();
                    each.CategoryValue = drCode["CODE"].ToString();
                    each.Status = drCode["USE_YN"].ToString();
                    each.Children = new List<Code>();

                    result[each.Id] = each;

                    // 코드의 부모 코드를 찾아서 부모로 설정함.
                    if (result[drCode["CODE_TYPE"].ToString()] != null)
                    {
                        each.Parent = (Code)result[drCode["CODE_TYPE"].ToString()];
                        each.ParentId = each.Parent.Id;
                    }
                }
                catch { }
            }

            return result;
        }
        #endregion

        #region ICodeRepository 멤버


        public List<Code> GetCodes(string categoryId)
        {
            List<Code> childList = new List<Code>();
            //SortedList sortList = new SortedList(CodeList);
            
            //foreach (DictionaryEntry item in sortList)
            //{
            //    Code c = (Code)item.Value;

            //    if (c.ParentId == categoryId)
            //    {
            //        childList.Add(c);
            //    }
            //}
            foreach (Code c in _dicCodeList.Values)
            {
                if (c.ParentId == categoryId)
                {
                    childList.Add(c);
                }
            }

            //foreach (Code c in CodeList.Values)
            //{
            //    if (c.ParentId == categoryId)
            //    {
            //        childList.Add(c);
            //    }
            //}

            return childList;
        }

        #endregion

        #region IHelpRepository 멤버


        public NEXCOREData GetHelpWindow(NEXCOREData data)
        {
            NEXCOREData ret = new NEXCOREData();
            _daw = new DataAccessWrapper();
            DbCommand selectCmd = _daw.GetStoredProcCommand(data.Name);

            foreach (System.Collections.DictionaryEntry d in data.Hashtable)
            {

                _daw.AddInParameter(selectCmd, d.Key.ToString(), DbType.String, d.Value.ToString());
            }
            _daw.AddOutParameter(selectCmd, "p_Header", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Header"]).OracleDbType = OracleDbType.RefCursor;
            _daw.AddOutParameter(selectCmd, "p_Data", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Data"]).OracleDbType = OracleDbType.RefCursor;
            DataSet dsWindow = _daw.ExecuteDataSet(selectCmd);

            ret.DataSet = dsWindow;

            return ret;
        }

        public NEXCOREData GetHelpProduct(NEXCOREData data)
        {
            NEXCOREData ret = new NEXCOREData();
            _daw = new DataAccessWrapper();
            DbCommand selectCmd = _daw.GetStoredProcCommand(data.Name);
            foreach (System.Collections.DictionaryEntry d in data.Hashtable)
            {

                _daw.AddInParameter(selectCmd, d.Key.ToString(), DbType.String, d.Value.ToString());
            }
            _daw.AddOutParameter(selectCmd, "p_Header", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Header"]).OracleDbType = OracleDbType.RefCursor;
            _daw.AddOutParameter(selectCmd, "p_Data", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["p_Data"]).OracleDbType = OracleDbType.RefCursor;
            DataSet dsProduct = _daw.ExecuteDataSet(selectCmd);

            ret.DataSet = dsProduct;
            return ret;
        }
        #endregion
    }
}
