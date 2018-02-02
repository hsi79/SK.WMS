using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.Transactions;
using Skcc.Data;

namespace NEXCORE.Common
{
    [Transaction(TransactionOption.Required, IsolationLevel = IsolationLevel.ReadCommitted, Timeout = 60)]
    public class SKBizBase : BizBase
    {
        //public static DataAccessWrapper DBAccess;

        public static void Initialize(object dbAccess)
        {
            //if (dbAccess is DataAccessWrapper)
            //{
            //    DBAccess = dbAccess as DataAccessWrapper;
            //}
        }

        public static void Setup()
        {

        }

        public static void Terminate()
        {

        }
    }
}