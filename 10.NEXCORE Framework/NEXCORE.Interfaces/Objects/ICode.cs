using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace NEXCORE.Interfaces
{
    public interface ICode
    {
        /// <summary>
        /// 코드 아이디를 반환한다.
        /// <returns>코드 아이디</returns>
        /// </summary>
        string GetId();

        /// <summary>
        /// 코드 이름을 반환한다. 코드 객체를 <code>new</code> 를 통해서 생성한 경우에는 이름을
        /// <code>ICodeManager</code> 에서 찾아서 반환한다.
        /// </summary>
        /// <return>코드 이름</return>
        string GetName();

        /// <summary>
        /// Locale에 해당하는 코드 이름을 반환한다. 코드 객체를 <code>new</code> 를 통해서 생성한 경우에는 이름을
        /// <code>ICodeManager</code> 에서 찾아서 반환한다.
        /// </summary>
        /// @param locale Locale
        /// <return>코드 이름</return>
        string GetName(string locale);

        /// <summary>
        /// 코드 설명을 반환한다.
        /// </summary>
        /// <return>코드 설명</return>
        string GetDescription();

        /// <summary>
        /// 코드 상태를 반환한다.
        /// </summary>
        /// <return>코드 상태</return>
        string GetStatus();

        /// <summary>
        /// 상위 코드를 반환한다.
        /// </summary>
        /// <return>상위 코드</return>
        ICode GetParent();

        /// <summary>
        /// 하위 코드 집합을 반환한다.
        /// </summary>
        /// <return>하위 코드 집합</return>
        IList<ICode> GetChildren();

        /// <summary>
        /// 하위 코드 집합을 가지고 있는지 체크한다.
        /// </summary>
        /// <returns>가지고 있다면 true, 그렇지 않으면 false를 반환</returns>
        bool HasChildren();

        /// <summary>
        /// 코드의 상태가 활성화 되어 있는지 확인한다.
        /// </summary>
        /// <return>'Y'이면 true, 그렇지 않으면 false를 반환</return>
        bool IsActive();

        /// <summary>
        /// 실제 코드의 값(Value)를 가져온다.
        /// </summary>
        /// <returns>코드값</returns>
        string GetValue();
    }
}
