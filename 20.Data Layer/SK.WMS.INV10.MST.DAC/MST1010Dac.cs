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

namespace SK.WMS.INV10.MST.Dac
{
    public class MST1010Dac : SKDacBase
    {
        #region 화면별 SP 설정
        private string sp_MST1010_0_R_SKUSELECT = "PK_INV10.SP_MST1010_0_R_SKUSELECT";
        private string sp_MST1010_0_S_SKUSAVE = "PK_INV10.SP_MST1010_0_S_SKUSAVE";
        private string sp_MST1010_0_D_SKUDELETE = "PK_INV10.SP_MST1010_0_D_SKUDELETE"; 

        #endregion

        /// <summary>
        /// MST1010의 조회
        /// TABLE : SKU
        /// </summary>
        /// <param name="dicParam"></param>
        /// <returns></returns>
        public DataSet SP_MST1010_0_R_SKUSELECT(Hashtable dicParam) //--업무에 맞게 변경 
        {
            // make command
            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(sp_MST1010_0_R_SKUSELECT);
            _daw.AddInParameter(selectCmd, "P_IN", DbType.String, dicParam["p_USER_ID"].ToString());
            _daw.AddOutParameter(selectCmd, "P_HEADER", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["P_HEADER"]).OracleDbType = OracleDbType.RefCursor;
            _daw.AddOutParameter(selectCmd, "P_DATA", DbType.Object, 8);
            ((OracleParameter)selectCmd.Parameters["P_DATA"]).OracleDbType = OracleDbType.RefCursor;

            return _daw.ExecuteDataSet(selectCmd);
        }
        /// <summary>
        /// MST1010의 저장
        /// TABLE : SKU
        /// </summary>
        /// <param name="dicParam"></param>
        /// <returns></returns>
        public int SP_MST1010_0_S_SKUSAVE(Hashtable dicParam) //--업무에 맞게 변경 
        {
            // make command
            _daw = new DataAccessWrapper();

            DbCommand saveCmd = _daw.GetStoredProcCommand(sp_MST1010_0_S_SKUSAVE);

            _daw.AddInParameter(saveCmd, "P_SERIALKEY"              , DbType.Int32, dicParam["P_SERIALKEY"      ].ToString());
            _daw.AddInParameter(saveCmd, "P_WHSEID"                 , DbType.String, dicParam["P_WHSEID"         ].ToString());
            _daw.AddInParameter(saveCmd, "P_STORERKEY"              , DbType.String, dicParam["P_STORERKEY"      ].ToString());
            _daw.AddInParameter(saveCmd, "P_SKU"                    , DbType.String, dicParam["P_SKU"            ].ToString());
            _daw.AddInParameter(saveCmd, "P_DESCR"                  , DbType.String, dicParam["P_DESCR"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR1"                  , DbType.String, dicParam["P_SUSR1"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR2"                  , DbType.String, dicParam["P_SUSR2"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR3"                  , DbType.String, dicParam["P_SUSR3"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR4"                  , DbType.String, dicParam["P_SUSR4"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR5"                  , DbType.String, dicParam["P_SUSR5"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_MANUFACTURERSKU"        , DbType.String, dicParam["P_MANUFACTURERSKU"].ToString());
            _daw.AddInParameter(saveCmd, "P_PACKKEY"                , DbType.String, dicParam["P_PACKKEY"        ].ToString());
            _daw.AddInParameter(saveCmd, "P_STDGROSSWGT"            , DbType.Decimal, dicParam["P_STDGROSSWGT"    ].ToString());
            _daw.AddInParameter(saveCmd, "P_STDNETWGT"              , DbType.Decimal, dicParam["P_STDNETWGT"      ].ToString());
            _daw.AddInParameter(saveCmd, "P_STDCUBE"                , DbType.Decimal, dicParam["P_STDCUBE"        ].ToString());
            _daw.AddInParameter(saveCmd, "P_TARE"                   , DbType.Decimal, dicParam["P_TARE"           ].ToString());
            _daw.AddInParameter(saveCmd, "P_CLASS"                  , DbType.String, dicParam["P_CLASS"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_ACTIVE"                 , DbType.String, dicParam["P_ACTIVE"         ].ToString());
            _daw.AddInParameter(saveCmd, "P_SKUGROUP"               , DbType.String, dicParam["P_SKUGROUP"       ].ToString());
            _daw.AddInParameter(saveCmd, "P_TARIFFKEY"              , DbType.String, dicParam["P_TARIFFKEY"      ].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE01LABEL"        , DbType.String, dicParam["P_LOTTABLE01LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE02LABEL"        , DbType.String, dicParam["P_LOTTABLE02LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE03LABEL"        , DbType.String, dicParam["P_LOTTABLE03LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE04LABEL"        , DbType.String, dicParam["P_LOTTABLE04LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE05LABEL"        , DbType.String, dicParam["P_LOTTABLE05LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE06LABEL"        , DbType.String, dicParam["P_LOTTABLE06LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE07LABEL"        , DbType.String, dicParam["P_LOTTABLE07LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE08LABEL"        , DbType.String, dicParam["P_LOTTABLE08LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE09LABEL"        , DbType.String, dicParam["P_LOTTABLE09LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_LOTTABLE10LABEL"        , DbType.String, dicParam["P_LOTTABLE10LABEL"].ToString());
            _daw.AddInParameter(saveCmd, "P_SKUGROUP2"              , DbType.String, dicParam["P_SKUGROUP2"      ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR6"                  , DbType.String, dicParam["P_SUSR6"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR9"                  , DbType.String, dicParam["P_SUSR9"          ].ToString());
            _daw.AddInParameter(saveCmd, "P_SUSR10"                 , DbType.String, dicParam["P_SUSR10"         ].ToString());
            _daw.AddInParameter(saveCmd, "P_OCWFLAG"                , DbType.String, dicParam["P_OCWFLAG"        ].ToString());
            _daw.AddInParameter(saveCmd, "P_PUTAWAYSTRATEGYKEY"     , DbType.String, dicParam["P_PUTAWAYSTRATEGYKEY"].ToString());
            _daw.AddInParameter(saveCmd, "P_QIGRADE"                , DbType.String, dicParam["P_QIGRADE"        ].ToString());
            _daw.AddInParameter(saveCmd, "P_GLUEWRAP"               , DbType.String, dicParam["P_GLUEWRAP"       ].ToString());
            _daw.AddInParameter(saveCmd, "P_ADDDATE"                , DbType.DateTime, dicParam["P_ADDDATE"        ].ToString());
            _daw.AddInParameter(saveCmd, "P_ADDWHO"                 , DbType.String, dicParam["P_ADDWHO"         ].ToString());
            _daw.AddInParameter(saveCmd, "P_EDITDATE"               , DbType.DateTime, dicParam["P_EDITDATE"       ].ToString());
            _daw.AddInParameter(saveCmd, "P_EDITWHO"                , DbType.String, dicParam["P_EDITWHO"        ].ToString());


            return _daw.ExecuteNonQuery(saveCmd);
        }
        /// <summary>
        /// MST1010의 삭제
        /// TABLE : SKU
        /// </summary>
        /// <param name="dicParam"></param>
        /// <returns></returns>
        public int SP_MST1010_0_D_SKUDELETE(Hashtable dicParam) //--업무에 맞게 변경 
        {
            // make command
            _daw = new DataAccessWrapper();

            DbCommand saveCmd = _daw.GetStoredProcCommand(sp_MST1010_0_D_SKUDELETE);
            
            
            _daw.AddInParameter(saveCmd, "P_SKU", DbType.String, dicParam["P_SKU"].ToString());
            _daw.AddInParameter(saveCmd, "P_STORERKEY", DbType.String, dicParam["P_STORERKEY"].ToString());

            return _daw.ExecuteNonQuery(saveCmd);
        }
    }
}
