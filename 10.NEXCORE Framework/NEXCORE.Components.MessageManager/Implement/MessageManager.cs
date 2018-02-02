using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

namespace NEXCORE.Components.MessageManager
{
    public class MessageManager : IMessageManager
    {
        private MessageDatabase _MessageRepository = new MessageDatabase();
        
        public void Init()
        {
            _MessageRepository.LoadMessage();
        }

        #region IMessageManager 멤버

        public bool Contains(string msgID)
        {
            List<Message> msgList = _MessageRepository.GetMessageList();

            try
            {
                var queryRet = from m in msgList
                               where m.MessageId == msgID
                               select m;

                if (queryRet.Count() > 0)
                    return true;
            }
            catch { }

            return false;

        }

        public List<Message> GetMessageList(string msgID,string msgName)
        {
            List<Message> msgList = _MessageRepository.GetMessageSearchList(msgID, msgName);

            
            return msgList;
        }
        public string GetMessage(string msgID)
        {
            List<Message> msgList = _MessageRepository.GetMessageList();

            var queryRet = from m in msgList
                           select m;
            if (queryRet.Count() < 1)
                return string.Empty;

            return queryRet.First<Message>().MessageKO;
        }
        public Message GetMessageObject(string msgID)
        {
            List<Message> msgList = _MessageRepository.GetMessageList();

            var queryRet = from m in msgList
                           where m.MessageId == msgID
                           select m;
            if (queryRet.Count() < 1)
                return null;

            return queryRet.First<Message>();
        }

        public string GetMessage(string msgID, string locale)
        {
            string retMsg = string.Empty;
            List<Message> msgList = _MessageRepository.GetMessageList();

            var queryRet = from m in msgList
                           where m.MessageId == msgID
                           select m;
            if (queryRet.Count() < 1)
                return retMsg;

            Message msg = queryRet.First<Message>();

            switch (locale)
            {
                //case "KOR"://"KO":
                //    retMsg = msg.MessageKO;
                //    break;
                //case "ENG"://"EN":
                //    retMsg = msg.MessageEN;
                //    break;
                //case "CHN"://"ZH":
                //    retMsg = msg.MessageZH;
                //    break;
                default:
                    // Use Korean Only
                    retMsg = msg.MessageKO;
                    break;
            }

            return retMsg;
        }

        public string GetMessage(string msgID, params object[] param)
        {
            throw new NotImplementedException();
        }

        public string GetMessage(string msgID, string locale, params object[] param)
        {
            throw new NotImplementedException();
        }
        public void AddMessage(string msgID, string msgNm)
        {
            _MessageRepository.AddMessage(msgID,msgNm);
        }


        public void UpdateMessage(string msgID, string msgNm)
        {
            _MessageRepository.UpdateMessage(msgID, msgNm);
        }

        public void DeleteMessage(string msgID)
        {
            _MessageRepository.DeleteMessage(msgID);
        }

        public void Reload()
        {
            _MessageRepository.LoadMessage();
        }

        #endregion
    }
}
