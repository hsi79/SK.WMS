using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace NEXCORE.Service.ServiceManager
{
    public class MessageServiceProxy
    {
        private static MessageService.MessageServiceClient _MessageService;

        private static string MESSAGE_SERVICE_URL = "MESSAGE_SERVICE_URL";

        public static bool Contains(string msgID)
        {
            if (!CheckConnection())
                return false;

            return _MessageService.Contains(msgID);
        }

        public static string GetMessage(string msgID)
        {
            if (!CheckConnection())
                return string.Empty;

            return _MessageService.GetMessage(msgID);
        }
        public static List<NEXCORE.Common.Data.Message> GetMessageList(string msgID, string msgNm)
        {
            if (!CheckConnection())
                return null;

            return _MessageService.GetMessageList(msgID, msgNm);
        }        
        public static string GetMessageLocale(string msgID, string locale)
        {
            if (!CheckConnection())
                return string.Empty;

            return _MessageService.GetMessageLocale(msgID, locale);
        }
        public static void AddMessage(string msgID, string msgNm)
        {
            if (CheckConnection())
            {
                _MessageService.AddMessage(msgID, msgNm);
            }
        }
        public static void UpdateMessage(string msgID, string msgNm)
        {
            if (CheckConnection())
            {
                _MessageService.UpdateMessage(msgID, msgNm);
            }
        }
        public static void DeleteMessage(string msgID)
        {
            if (CheckConnection())
            {
                _MessageService.DeleteMessage(msgID);
            }
        }
        public static void Reload()
        {
            if (CheckConnection())
            {
                _MessageService.Reload();
            }
        }

        private static bool CheckConnection()
        {
            if (_MessageService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(MESSAGE_SERVICE_URL);

                Binding wsBinding = new System.ServiceModel.BasicHttpBinding();

                EndpointAddress address = new EndpointAddress(url);

                _MessageService = new MessageService.MessageServiceClient(wsBinding, address);
            }

            return true;
        }
    }
}
