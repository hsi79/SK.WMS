using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "IFrontService" here, you must also update the reference to "IFrontService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceKnownType(typeof(Menu))]
    [ServiceKnownType(typeof(List<Menu>))]
    [ServiceContract]
    public interface IFrontService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        NEXCOREData InvokeService(string fullName, string methodName, NEXCOREData paras);

        [OperationContract]
        NEXCOREData InvokeTransactionService(string fullName, string methodName, NEXCOREData paras);

        [OperationContract]
        void UnloadApplicationDomainLibrary();
    }
}
