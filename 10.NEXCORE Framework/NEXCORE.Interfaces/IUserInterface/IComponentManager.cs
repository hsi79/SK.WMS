using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IComponentManager
    {
        #region 권한 관련
        //미작성
        #endregion
        
        #region 코드 관련
        void ReloadCodes();

        ICode GetCode(string id);
       
        ICode GetParentCode(string childCode);
        ICode GetParentCode(ICode code);

        IList<ICode> GetCodes(string parentCodeId);
        IList<ICode> GetCodes(ICode parentCode);

        IList<ICode> GetCodes(string parentCodeId, params string[] codeAttributes);
          
        #endregion

        #region Program 관련
        Program GetProgram(string pgmId);
        List<Program> GetProgramList(string pgmType, string pgmId, string pgmPath);
        bool Show(string pgmId);
        
        System.Windows.Forms.DialogResult ShowPopup(string pgmId);

        bool ReloadProgram();
        #endregion

        #region Message 관련
        //구현 필요
        #endregion

        #region 사용자 관련
        LOGIN_RESULT_CODE Login(string userId, string password);

        IUser GetUser(string userId);
        #endregion

        #region 메뉴 관련
        List<Menu> GetToolMenuList(string authId);

        List<Menu> GetNavagatorMenu(string authId);

        List<Menu> GetRootMenu(string authId);

        List<Menu> GetChildMenus(string parentId, string authId);
        #endregion
    }
}
