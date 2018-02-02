using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEXCORE.Interfaces
{
    public interface IFormRepository : IDisposable
    {
        /// <summary>
        /// Form을 Loading 한다.
        /// </summary>
        /// <returns></returns>
        bool LoadForm();

        /// <summary>
        /// Form의 이름으로 Form을 가져 온다.
        /// </summary>
        Dictionary<string, Type> Forms
        {
            get;
        }

        IProgram GetProgram(string pgmId);
    }
}
