using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;
using Skcc.Data;
using System.Data;
using System.Collections;
using System.Data.Common;

namespace NEXCORE.Components.MessageManager
{
    public class MessageDatabase 
    {
        private Dictionary<string, Message> _MessageList = new Dictionary<string, Message>();

        private const string SPLoadAlls = "PK_NEXCORE.SP_MSG_SELECTALL";
        private const string SPLoadAll = "PK_NEXCORE.SP_MSG_SELECT";
        private const string SPAddMessage = "PK_NEXCORE.SP_MSG_INSERT";
        private const string SPUpdateMessage = "PK_NEXCORE.SP_MSG_UPDATE";
        private const string SPDeleteMessage = "PK_NEXCORE.SP_MSG_DELETE";
        private DataAccessWrapper _daw;

        #region IMessageRepository 멤버

        public List<Message> GetMessageList()
        {
            return _MessageList.Values.ToList<Message>();
        }

        public void LoadMessage()
        {

            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAlls);

            DataSet dsMessage = _daw.ExecuteDataSet(selectCmd);
            //DataSet dsMessage = _daw.ExecuteDataSet(SPLoadAlls);
            if (dsMessage.Tables.Count <= 0 || dsMessage.Tables[0].Rows.Count <= 0)
                return;

            _MessageList = SetMessageList(dsMessage);


            if (dsMessage.Tables.Count <= 0 || dsMessage.Tables[0].Rows.Count <= 0)
                return;

            _MessageList = SetMessageList(dsMessage);

        }
        public void MessageList(string msgID, string msgName)
        {

            _daw = new DataAccessWrapper();

            DbCommand selectCmd = _daw.GetStoredProcCommand(SPLoadAll);
            this._daw.AddInParameter(selectCmd, "p_MSG_ID", DbType.String, msgID);
            this._daw.AddInParameter(selectCmd, "p_MSG_NM", DbType.String, msgName);

            DataSet dsMessage = _daw.ExecuteDataSet(selectCmd);
            //DataSet dsMessage = _daw.ExecuteDataSet(SPLoadAlls);
            if (dsMessage.Tables.Count <= 0 || dsMessage.Tables[0].Rows.Count <= 0)
                return;

            _MessageList = SetMessageList(dsMessage);


            if (dsMessage.Tables.Count <= 0 || dsMessage.Tables[0].Rows.Count <= 0)
                return;

            _MessageList = SetMessageList(dsMessage);


        }

        public List<Message> GetMessageSearchList(string msgID, string msgName)
        {
            MessageList(msgID, msgName);
            return _MessageList.Values.ToList<Message>();
        }
        public void AddMessage(string msgID, string msgName)
        {

            _daw = new DataAccessWrapper();

            DbCommand insertCmd = _daw.GetStoredProcCommand(SPAddMessage);
            this._daw.AddInParameter(insertCmd, "p_MSG_ID", DbType.String, msgID);
            this._daw.AddInParameter(insertCmd, "p_MSG_NM", DbType.String, msgName);

            _daw.ExecuteDataSet(insertCmd);


        }
        public void UpdateMessage(string msgID, string msgName)
        {

            _daw = new DataAccessWrapper();

            DbCommand updateCmd = _daw.GetStoredProcCommand(SPUpdateMessage);
            this._daw.AddInParameter(updateCmd, "p_MSG_ID", DbType.String, msgID);
            this._daw.AddInParameter(updateCmd, "p_MSG_NM", DbType.String, msgName);

            _daw.ExecuteDataSet(updateCmd);



        }
        public void DeleteMessage(string msgID)
        {

            _daw = new DataAccessWrapper();

            DbCommand DeleteCmd = _daw.GetStoredProcCommand(SPDeleteMessage);
            this._daw.AddInParameter(DeleteCmd, "p_MSG_ID", DbType.String, msgID);

            _daw.ExecuteNonQuery(DeleteCmd);



        }

        #endregion


        #region 내부 메소드

        private Dictionary<string, Message> SetMessageList(DataSet dsMsg)
        {
            Dictionary<string, Message> msgList = new Dictionary<string, Message>();

            foreach (DataRow drMsg in dsMsg.Tables[0].Rows)
            {
                Hashtable htCategory = new Hashtable();
                htCategory["MESSAGE_ID"] = drMsg["MESSAGE_ID"].ToString();
                htCategory["MESSAGE_TYPE"] = drMsg["MESSAGE_TYPE"].ToString();
                htCategory["MESSAGE_KO"] = drMsg["MESSAGE_KO"].ToString();
                htCategory["MESSAGE_EN"] = drMsg["MESSAGE_EN"].ToString();
                htCategory["MESSAGE_ZH"] = drMsg["MESSAGE_ZH"].ToString();
                htCategory["REG_ID"] = drMsg["REG_ID"].ToString();
                htCategory["REG_TIME"] = drMsg["REG_TIME"].ToString();
                htCategory["MOD_ID"] = drMsg["MOD_ID"].ToString();
                htCategory["MOD_TIME"] = drMsg["MOD_TIME"].ToString();

                Message msg = new Message(htCategory);

                msgList[msg.MessageId] = msg;
            }

            return msgList;
            
        }

        #endregion
    }
}
