using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

namespace NEXCORE.Components.CodeManager
{
    public class CodeManager : ICodeManager
    {
        #region ICodeManager Members

        //Setter Injection
        public CodeDatabase _CodeRepository = new CodeDatabase();
        
        public Code GetCode(string id)
        {
            //_CodeRepository.LoadCode();
            return _CodeRepository.GetCode(id);
        }
 
        public List<Code> GetCodes(string parentCodeId)
        {
            //_CodeRepository.LoadCode();
            return _CodeRepository.GetCodes(parentCodeId);
        }
 
        public List<Code> GetCodes(string parentCodeId, params string[] codeAttributes)
        {
            throw new NotImplementedException();
        }
        #region IHelpRepository 멤버


        public NEXCOREData GetHelpWindow(NEXCOREData data)
        {
            return _CodeRepository.GetHelpWindow(data);
        }

        public NEXCOREData GetHelpProduct(NEXCOREData data)
        {
            return _CodeRepository.GetHelpProduct(data);
        }
        #endregion
        public void Reload()
        {
            _CodeRepository.LoadCode();
        }

        public void Init()
        {
            _CodeRepository.LoadCode();
        }

        #endregion

    }
}
