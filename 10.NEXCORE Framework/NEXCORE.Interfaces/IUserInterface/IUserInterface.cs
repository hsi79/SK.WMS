using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;
using System.Data;
using NEXCORE.Interfaces;
using System.Globalization;
using NEXCORE.Common;
using Skcc.Data;

namespace NEXCORE.Interfaces
{
    public interface IUserInterface
    {
        #region Form Event 관련 함수

        void SendMessage(string pgmId, NEXCOREData data);

        void SendMessage(List<string> pgmIds, NEXCOREData data);

        void Broadcast(object sender, BroadCastEventArgs e);

        void AddChildFormEvent(string pgmId, ReceiveMessage del);

        void RemoveChildFormEvent(string pgmId);

        void AddBroadCastEvent(BroadCast broadcastHandler);



        #endregion

        #region Contents Form 관련 함수

        //void LoadForm(string pgmId, bool checkAuth);
        Program GetCurrentProgram();

        bool LoadForm(SKUserControlBase form, string pgmId, ref string strMsg);

        Object GetNewFormInstance(string pgmId, ref string strResultMessage);


        bool ShowAlert(eAlertTypes type, string message);



        System.Windows.Forms.DialogResult ShowWindowsDialog(string pgmId, object form, NEXCOREData param);
        #endregion

        #region MDI 관련 함수 (메뉴 추가, 로그인등)
        


        #region Menu관련

        void LoadNavigationMenu();

        void LoadNavigationMenu(string userId);

        bool CheckProgramAuthority(string pgmId);

        Menu GetMenu(string pgmId, string sysid);

        #endregion

        #region Login & Logout

        void Logout();

        LOGIN_RESULT_CODE Login(string userId, string password);


        #endregion

        #endregion

        #region User 관련 함수
        User GetCurrentUser();

        void SetCurrentUser(User user);
        #endregion

        #region Web Service & WCF

        NEXCOREData InvokeService(string typeString, string methodName, NEXCOREData paras);

        NEXCOREData InvokeTransactionService(string typeString, string methodName, NEXCOREData paras);



        void UnloadAppDomain();
        #endregion

        #region Localization : Multi-Lingual Culture (EN, KO, ZH)
        /// <summary>
        /// Set local culture info
        /// </summary>
        /// <param name="newCulture">새로운 언어 정보</param>
        void SetCultureInfo(CultureInfo newCulture);

        /// <summary>
        /// 현재 설정된 언어 정보를 통해 MDI와 현재 화면을 다시 로딩 합니다.
        /// </summary>
        void ReloadCulture();
        
        /// <summary>
        /// 현재 설정된 언어 정보를 통해 현재 화면을 다시 로딩 합니다.
        /// </summary>
        void ReloadCurrentProgram(Program pgm);

        /// <summary>
        /// 언어를 설정 하고, 설정된 언어로 화면을 로딩 합니다.
        /// </summary>
        /// <param name="newCulture"></param>
        void ReloadCulture(CultureInfo newCulture);

        /// <summary>
        /// 언어를 설정 하고, 설정 된 언어로 화면을 로딩 합니다.
        /// </summary>
        /// <param name="misCultureString"></param>
        void ReloadCulture(string misCultureString);

        /// <summary>
        /// 현재 설정된 언어 정보를 가져옵니다.
        /// </summary>
        /// <returns></returns>
        CultureInfo GetCurrentUICulture();

        /// <summary>
        /// 현재 설정된 언어 정보를 가져옵니다. KOR, ENG, CHN
        /// </summary>
        /// <returns></returns>
        string GetCurrentLanguage();
        #endregion

        #region Contents 관리

        void SetCurrentProgram(Program pgm);

        ISKBase GetCurrentContent(string pgmId);

        void WriteStatusBar(SKUserControlBase form, string msg);
        
        #endregion
        //void ShowProgressBar();
        //void CloseProgressBar();

        #region Child Control
        void AddChildControlEventHandler(string pProgramID, System.Windows.Forms.Control pControl);
        #endregion

        #region Validation Check
        System.Windows.Forms.Control GetSKControl(string pgmId, string controlName);

        List<System.Windows.Forms.Control> GetSKControls(string pgmId);

        Dictionary<System.Windows.Forms.Control, string> GetMandatoryControls(string pgmId);
        #endregion

    }
}
