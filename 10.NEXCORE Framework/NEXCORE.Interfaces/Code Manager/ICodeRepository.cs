using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces.Objects;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface ICodeRepository : IDisposable
    {
        bool LoadCode();

        Code GetCode(string codeId);

        List<Code> GetCodes(string categoryId);

        NEXCOREData GetHelpWindow(NEXCOREData data);
        NEXCOREData GetHelpProduct(NEXCOREData data);

    }
}
