using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IMessageManager : IManager
    {
        /// <summary>
        /// 메시지 존재 여부를 체크한다.
        /// </summary>
        /// <param name="msgID">메시지 아이디</param>
        /// <returns>메시지 아이디에 해당하는 메시지</returns>
        bool Contains(string msgID);

        /// <summary>
        /// 메시지를 반환한다.
        /// </summary>
        /// <param name="msgID">메시지 아이디</param>
        /// <returns>메시지 아이디에 해당하는 메시지</returns>
        string GetMessage(string msgID);

        /// <summary>
        /// 메시지를 반환한다.
        /// </summary>
        /// <param name="msgID">메시지 아이디</param>
        /// <returns>메시지 아이디에 해당하는 메시지</returns>
        Message GetMessageObject(string msgID);

        /// <summary>
        /// 메시지를 반환한다.
        /// </summary>
        /// <param name="msgID">메시지 아이디</param>
        /// <param name="locale">로케일 정보(ko, en, zh)</param>
        /// <returns>메시지 아이디에 해당하는 메시지</returns>
        string GetMessage(string msgID, string locale);

        /// <summary>
        /// 메시지를 반환한다.
        /// </summary>
        /// <param name="msgID">메시지 아이디</param>
        /// <param name="param">메시지에 전달할 파라미터들</param>
        /// <returns>메시지 아이디에 해당하는 메시지</returns>
        string GetMessage(string msgID, params object[] param);

        /// <summary>
        /// 메시지를 반환한다.
        /// </summary>
        /// <param name="msgID">메시지 아이디</param>
        /// <param name="locale">로케일 정보(ko, en, zh)</param>
        /// <param name="param">메시지에 전달할 파라미터들</param>
        /// <returns>메시지 아이디에 해당하는 메시지</returns>
        string GetMessage(string msgID, string locale, params object[] param);
        List<Message> GetMessageList(string msgID, string msgName);

        void AddMessage(string msgID, string msgNm);
        void UpdateMessage(string msgID, string msgNm);
        void DeleteMessage(string msgID);
        /// <summary>
        /// 메시지를 다시 로드한다.
        /// </summary>
        void Reload();
    }
}
