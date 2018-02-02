using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using NEXCORE.Common.Data;

namespace NEXCORE.Service.ServiceManager
{
    public class CodeServiceProxy
    {
        private static string CODE_SERVICE_URL = "CODE_SERVICE_URL";
        private static CodeService.CodeServiceClient _CodeService;

         /// <summary>
        /// 코드를 반환한다.
        /// </summary>
        /// <param name="id">코드 아이디</param>
        /// <returns>코드 아이디에 대한 코드</returns>
        public static Code GetCode(string id)
        {
            if (!CheckConnection())
                return null;

            return _CodeService.GetCode(id);
        }


        /// <summary>
        /// 코드 아이디의 하위 코드 집합을 반환한다.
        /// </summary>
        /// <param name="parentCodeId">상위 코드 아이디</param>
        /// <returns>코드 아이디에 대한 하위 코드 목록</returns>
        /// 
        public static List<Code> GetCodes(string parentCodeId)
        {
            if (!CheckConnection())
                return null;

            List<Code> retList = _CodeService.GetCodes(parentCodeId);
            return retList;
        }
        public static NEXCOREData GetHelpWindow(NEXCOREData data)
        {
            if (!CheckConnection())
                return null;

            NEXCOREData retList = _CodeService.GetHelpWindow(data);
            return retList;
        }
        public static NEXCOREData GetHelpProduct(NEXCOREData data)
        {
            if (!CheckConnection())
                return null;

            NEXCOREData retList = _CodeService.GetHelpProduct(data);
            return retList;
        }
        /// <summary>
        /// 코드 아이디의 하위 코드 집합을 반환한다.
        /// 코드 속성 정보를 이용해서 좀 더 상세하게 제어한다.
        /// </summary>
        /// <param name="parentCodeId">상위 코드 아이디</param>
        /// <param name="codeAttributes">코드 속성 정보 목록</param>
        /// <returns>코드 아이디에 대한 하위 코드 목록</returns>
        /// 
        public static List<Code> GetCodesByAttribute(string parentCodeId, params string[] codeAttributes)
        {
            return new List<Code>();
        }

        public static void Reload()
        {
            if (!CheckConnection())
                return ;

            _CodeService.Reload();
        }

        private static bool CheckConnection()
        {
            if (_CodeService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(CODE_SERVICE_URL);

                BasicHttpBinding wsBinding = new BasicHttpBinding();
                wsBinding.MaxReceivedMessageSize = 9999999;

                EndpointAddress address = new EndpointAddress(url);

                _CodeService = new CodeService.CodeServiceClient(wsBinding, address);
            }

            return true;
        }

    }
}
