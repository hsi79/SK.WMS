using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;
using NEXCORE.Common;
using System.Collections;
using Skcc.Transactions;
using System.Diagnostics;
using System.IO;
using NEXCORE.Utility;
using SK.WMS.INV10.MST.Dac;
using System.Data;

namespace SK.WMS.INV10.MST.Biz
{
    public class MST1010Biz : SKBizBase
    {

        public static NEXCOREData SP_MST1010_0_R_SKUSELECT(NEXCOREData data)
        {
            using (MST1010Dac dac = new MST1010Dac())
            {
                NEXCOREData retValue = new NEXCOREData();

                retValue.DataSet = dac.SP_MST1010_0_R_SKUSELECT(data.Hashtable);
                return retValue;
            }
        }

        public static NEXCOREData SP_MST1010_0_S_SKUSAVE(NEXCOREData data)
        {
            using (MST1010Dac dac = new MST1010Dac())
            {
                NEXCOREData retValue = new NEXCOREData();

                DataTable dt = (DataTable)data.Hashtable["P_IN"];
                Hashtable ht = new Hashtable();
                retValue.intCnt = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    
                    ht.Add("P_SERIALKEY",       dr["SERIALKEY"]);
                    ht.Add("P_WHSEID",          dr["WHSEID"]);
                    ht.Add("P_STORERKEY",       dr["STORERKEY"]);
                    ht.Add("P_SKU",             dr["SKU"]);
                    ht.Add("P_DESCR",           dr["DESCR"]);
                    ht.Add("P_SUSR1",           dr["SUSR1"]);
                    ht.Add("P_SUSR2",           dr["SUSR2"]);
                    ht.Add("P_SUSR3",           dr["SUSR3"]);
                    ht.Add("P_SUSR4",           dr["SUSR4"]);
                    ht.Add("P_SUSR5",           dr["SUSR5"]);
                    ht.Add("P_MANUFACTURERSKU", dr["MANUFACTURERSKU"]);
                    ht.Add("P_PACKKEY",         dr["PACKKEY"]);
                    ht.Add("P_STDGROSSWGT",     dr["STDGROSSWGT"]);
                    ht.Add("P_STDNETWGT",       dr["STDNETWGT"]);
                    ht.Add("P_STDCUBE",         dr["STDCUBE"]);
                    ht.Add("P_TARE",            dr["TARE"]);
                    ht.Add("P_CLASS",           dr["CLASS"]);
                    ht.Add("P_ACTIVE",          dr["ACTIVE"]);
                    ht.Add("P_SKUGROUP",        dr["SKUGROUP"]);
                    ht.Add("P_TARIFFKEY",       dr["TARIFFKEY"]);
                    ht.Add("P_LOTTABLE01LABEL", dr["LOTTABLE01LABEL"]);
                    ht.Add("P_LOTTABLE02LABEL", dr["LOTTABLE02LABEL"]);
                    ht.Add("P_LOTTABLE03LABEL", dr["LOTTABLE03LABEL"]);
                    ht.Add("P_LOTTABLE04LABEL", dr["LOTTABLE04LABEL"]);
                    ht.Add("P_LOTTABLE05LABEL", dr["LOTTABLE05LABEL"]);
                    ht.Add("P_LOTTABLE06LABEL", dr["LOTTABLE06LABEL"]);
                    ht.Add("P_LOTTABLE07LABEL", dr["LOTTABLE07LABEL"]);
                    ht.Add("P_LOTTABLE08LABEL", dr["LOTTABLE08LABEL"]);
                    ht.Add("P_LOTTABLE09LABEL", dr["LOTTABLE09LABEL"]);
                    ht.Add("P_LOTTABLE10LABEL", dr["LOTTABLE10LABEL"]);
                    ht.Add("P_SKUGROUP2",       dr["SKUGROUP2"]);
                    ht.Add("P_SUSR6",           dr["SUSR6"]);
                    ht.Add("P_SUSR9",           dr["SUSR9"]);
                    ht.Add("P_SUSR10",          dr["SUSR10"]);
                    ht.Add("P_OCWFLAG",         dr["OCWFLAG"]);
                    ht.Add("P_PUTAWAYSTRATEGYKEY", dr["PUTAWAYSTRATEGYKEY"]);
                    ht.Add("P_QIGRADE",         dr["QIGRADE"]);
                    ht.Add("P_GLUEWRAP",        dr["GLUEWRAP"]);
                    ht.Add("P_ADDDATE",         dr["ADDDATE"]);
                    ht.Add("P_ADDWHO",          dr["ADDWHO"]);
                    ht.Add("P_EDITDATE",        dr["EDITDATE"]);
                    ht.Add("P_EDITWHO",         dr["EDITWHO"]);

                    retValue.intCnt = retValue.intCnt + dac.SP_MST1010_0_S_SKUSAVE(ht);
                    
                }

                return retValue;
            }
        }

        public static NEXCOREData SP_MST1010_0_D_SKUDELETE(NEXCOREData data)
        {
            using (MST1010Dac dac = new MST1010Dac())
            {
                NEXCOREData retValue = new NEXCOREData();

                DataTable dt = (DataTable)data.Hashtable["P_IN"];
                Hashtable ht = new Hashtable();

                retValue.intCnt = 0;
                
                foreach (DataRow dr in dt.Rows)
                {
                    ht.Add("P_SKU", dr["SKU"].ToString());
                    ht.Add("P_STORERKEY", dr["STORERKEY"].ToString());

                    retValue.intCnt = retValue.intCnt + dac.SP_MST1010_0_D_SKUDELETE(ht);
                }

                return retValue;
            }
        }
        
    }
}
