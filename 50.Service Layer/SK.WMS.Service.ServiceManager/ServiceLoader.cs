using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel;
using NEXCORE.Common.Data;

using System.Runtime.Serialization;

namespace NEXCORE.Service.ServiceManager
{
    public class ServiceLoader
    {
        private static FrontService.FrontServiceClient _frontService;

        private static string FRONT_SERVICE_URL = "FRONT_SERVICE_URL";

        #region Front Service

        public static NEXCOREData Invoke(string typeString, string methodName, NEXCOREData paras)
        {
            if (!CheckConnection())
                return null;

            return _frontService.InvokeService(typeString, methodName, paras);
        }

        public static NEXCOREData InvokeTransaction(string typeString, string methodName, NEXCOREData paras)
        {
            if (!CheckConnection())
                return null;

            return _frontService.InvokeTransactionService(typeString, methodName, paras);
        }
        public static bool InvokeAsync(string typeString, string methodName, NEXCOREData paras, Delegate AsyncResult)
        {
            if (!CheckConnection())
            {
                return false;
            }

            return true;
        }

        private static bool CheckConnection()
        {
            if (_frontService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(FRONT_SERVICE_URL);

                BasicHttpBinding wsBinding = new System.ServiceModel.BasicHttpBinding();

                wsBinding.MaxReceivedMessageSize = 2147483647;
                wsBinding.MaxBufferPoolSize = 2147483647;
                wsBinding.MaxBufferSize = 2147483647;
                wsBinding.ReceiveTimeout = new TimeSpan(0, 10, 0);
                wsBinding.SendTimeout = new TimeSpan(0, 10, 0);

                wsBinding.ReaderQuotas.MaxArrayLength = 2147483647;

                EndpointAddress address = new EndpointAddress(url);

                _frontService = new FrontService.FrontServiceClient(wsBinding, address);
            }

            return true;
        }

        public static void UnloadAppDomain()
        {
            _frontService.UnloadApplicationDomainLibrary();
        }
        #endregion

    }
}
