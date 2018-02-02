using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Interfaces;
using Skcc.IoC;
using NEXCORE.Common.Data;
using NEXCORE.Components.CodeManager;

namespace NEXCORE.Service
{
    // NOTE: If you change the class name "CodeService" here, you must also update the reference to "CodeService" in Web.config.
    public class CodeService : ICodeService
    {
        public void DoWork()
        {
        }

        #region ICodeService 멤버


        public NEXCORE.Common.Data.Code GetCode(string id)
        {
            ICodeManager codeMgr = null;
            try
            {
                codeMgr = (ICodeManager)ComponentFactory.GetObject("NexcoreCodeMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return codeMgr.GetCode(id);
        }

        public List<NEXCORE.Common.Data.Code> GetCodes(string parentCodeId)
        {
            ICodeManager codeMgr = null;
            try
            {
                codeMgr = (ICodeManager)ComponentFactory.GetObject("NexcoreCodeMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            List<Code> retList = codeMgr.GetCodes(parentCodeId);
            return retList;
        }

        public NEXCOREData GetHelpWindow(NEXCOREData data)
        {
            ICodeManager codeMgr = null;
            try
            {
                codeMgr = (ICodeManager)ComponentFactory.GetObject("NexcoreCodeMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            NEXCOREData retList = codeMgr.GetHelpWindow(data);
            return retList;
        }
        public NEXCOREData GetHelpProduct(NEXCOREData data)
        {
            ICodeManager codeMgr = null;
            try
            {
                codeMgr = (ICodeManager)ComponentFactory.GetObject("NexcoreCodeMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            NEXCOREData retList = codeMgr.GetHelpProduct(data);
            return retList;
        }
        public List<NEXCORE.Common.Data.Code> GetCodesByAttribute(string parentCodeId, params string[] codeAttributes)
        {
            ICodeManager codeMgr = null;
            try
            {
                codeMgr = (ICodeManager)ComponentFactory.GetObject("NexcoreCodeMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return codeMgr.GetCodes(parentCodeId, codeAttributes);
        }

        public void Reload()
        {
            ICodeManager codeMgr = null;
            try
            {
                codeMgr = (ICodeManager)ComponentFactory.GetObject("NexcoreCodeMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            codeMgr.Reload();
        }

        #endregion
    }
}
