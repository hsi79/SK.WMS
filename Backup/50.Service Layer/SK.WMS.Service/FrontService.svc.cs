using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using NEXCORE.Components.ComponentManager;
using NEXCORE.Common.Data;

using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace NEXCORE.Service
{
    // NOTE: If you change the class name "FrontService" here, you must also update the reference to "FrontService" in Web.config.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerSession)] 
    public class FrontService : IFrontService
    {
        public void DoWork()
        {
        }
        
        public NEXCOREData InvokeService(string fullName, string methodName, NEXCOREData paras)
        {
            ComponentManager cmMgr = AppDomainMgr.GetComponentMgr();
            NEXCOREData retValue = cmMgr.InvokeFunction(fullName, methodName, paras);

            if (retValue != null && retValue.DataTable != null && string.IsNullOrEmpty(retValue.DataTable.TableName))
            {
                retValue.DataTable.TableName = "TEMPTABLE";
            }
            
            return retValue;
        }

        public NEXCOREData InvokeTransactionService(string fullName, string methodName, NEXCOREData paras)
        {
            ComponentManager cmMgr = AppDomainMgr.GetComponentMgr();
            NEXCOREData retValue = cmMgr.InvokeTransactionFunction(fullName, methodName, paras);

            if (retValue != null && retValue.DataTable != null && string.IsNullOrEmpty(retValue.DataTable.TableName))
            {
                retValue.DataTable.TableName = "TEMPTABLE";
            }
            return retValue;
        }

        /// <summary>
        /// Unload current using biz/dac dlls
        /// </summary>
        public void UnloadApplicationDomainLibrary()
        {
            AppDomainMgr.UnLoadComponentDomain();
        }
    }
}