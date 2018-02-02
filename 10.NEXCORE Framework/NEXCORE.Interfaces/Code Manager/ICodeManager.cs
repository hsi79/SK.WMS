using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces.Objects;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface ICodeManager : IManager
    {
        /// <summary>
        /// 코드를 반환한다.
        /// </summary>
        /// <param name="id">코드 아이디</param>
        /// <returns>코드 아이디에 대한 코드</returns>
        Code GetCode(string id);


        /// <summary>
        /// 코드 아이디의 하위 코드 집합을 반환한다.
        /// </summary>
        /// <param name="parentCodeId">상위 코드 아이디</param>
        /// <returns>코드 아이디에 대한 하위 코드 목록</returns>
        List<Code> GetCodes(string parentCodeId);

        /// <summary>
        /// 코드 아이디의 하위 코드 집합을 반환한다.
        /// 코드 속성 정보를 이용해서 좀 더 상세하게 제어한다.
        /// </summary>
        /// <param name="parentCodeId">상위 코드 아이디</param>
        /// <param name="codeAttributes">코드 속성 정보 목록</param>
        /// <returns>코드 아이디에 대한 하위 코드 목록</returns>
        List<Code> GetCodes(string parentCodeId, params string[] codeAttributes);

        NEXCOREData GetHelpWindow(NEXCOREData data);


        NEXCOREData GetHelpProduct(NEXCOREData data);

        void Reload();

        void Init();
    }
}
