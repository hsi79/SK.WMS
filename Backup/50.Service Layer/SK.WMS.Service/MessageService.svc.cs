using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;
using Skcc.IoC;
using NEXCORE.Interfaces;
using NEXCORE.Components.MessageManager;

namespace NEXCORE.Service
{
    // NOTE: If you change the class name "MessageService" here, you must also update the reference to "MessageService" in Web.config.
    public class MessageService : IMessageService
    {
        public void DoWork()
        {
        }

        public bool Contains(string msgID)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
            return msgMgr.Contains(msgID);
        }

        public string GetMessage(string msgID)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
            return msgMgr.GetMessage(msgID);
        }

        public List<Message> GetMessageList(string msgID,string msgNm)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
            return msgMgr.GetMessageList(msgID,msgNm);
        }
        public Message GetMessageObject(string msgID)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
            return msgMgr.GetMessageObject(msgID);
        }

        public string GetMessageLocale(string msgID, string locale)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
            return msgMgr.GetMessage(msgID, locale);
        }
        public void AddMessage(string msgID, string locale)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
             msgMgr.AddMessage(msgID, locale);
        }
        public void UpdateMessage(string msgID, string locale)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
             msgMgr.UpdateMessage(msgID, locale);
        }
        public void DeleteMessage(string msgID)
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
             msgMgr.DeleteMessage(msgID);
        }
        public void Reload()
        {
            IMessageManager msgMgr = (IMessageManager)ComponentFactory.GetObject("NexcoreMessageMgr");
            msgMgr.Reload();
        }
    }
}
