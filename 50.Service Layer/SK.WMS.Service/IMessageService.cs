using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "IMessageService" here, you must also update the reference to "IMessageService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        bool Contains(string msgID);

        [OperationContract]
        string GetMessage(string msgID);
        [OperationContract]
        List<Message> GetMessageList(string msgID,string msgNm);
        [OperationContract]
        Message GetMessageObject(string msgID);

        [OperationContract]
        string GetMessageLocale(string msgID, string locale);
        [OperationContract]
        void AddMessage(string msgID, string msgNm);
        [OperationContract]
        void UpdateMessage(string msgID, string msgNm);
        [OperationContract]
        void DeleteMessage(string msgID);
        [OperationContract]
        void Reload();
    }
}
