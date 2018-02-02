using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "ICodeService" here, you must also update the reference to "ICodeService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceContract]
    public interface ICodeService
    {
        [OperationContract]
        void DoWork();

        /// <summary>
        /// 코드를 반환한다.
        /// </summary>
        /// <param name="id">코드 아이디</param>
        /// <returns>코드 아이디에 대한 코드</returns>
        [OperationContract]
        Code GetCode(string id);


        /// <summary>
        /// 코드 아이디의 하위 코드 집합을 반환한다.
        /// </summary>
        /// <param name="parentCodeId">상위 코드 아이디</param>
        /// <returns>코드 아이디에 대한 하위 코드 목록</returns>
        /// 
        [OperationContract]
        List<Code> GetCodes(string parentCodeId);

        [OperationContract]
        NEXCOREData GetHelpWindow(NEXCOREData data);

        [OperationContract]
        NEXCOREData GetHelpProduct(NEXCOREData data);
        /// <summary>
        /// 코드 아이디의 하위 코드 집합을 반환한다.
        /// 코드 속성 정보를 이용해서 좀 더 상세하게 제어한다.
        /// </summary>
        /// <param name="parentCodeId">상위 코드 아이디</param>
        /// <param name="codeAttributes">코드 속성 정보 목록</param>
        /// <returns>코드 아이디에 대한 하위 코드 목록</returns>
        /// 
        [OperationContract]
        List<Code> GetCodesByAttribute(string parentCodeId, params string[] codeAttributes);



        [OperationContract]
        void Reload();
    }
}
