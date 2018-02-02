using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IProgramManager
    {
        void Init();

        List<Program> GetProgramList();

        List<Program> GetProgramSelect(string pgmId);
        Program GetProgram(string pgmId);

        void Reload();

        void AddProgram(Program program);
        void UpdateProgram(Program program);
        void DeleteProgram(Program program);
    }
}
