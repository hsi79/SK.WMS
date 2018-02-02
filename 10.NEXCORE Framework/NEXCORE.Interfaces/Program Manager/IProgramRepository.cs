using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Interfaces
{
    public interface IProgramRepository
    {
        void LoadProgram();

        List<Program> GetProgramList();
        void UpdateProgram(Program menu);

        void DeleteProgram(Program menu);

        void AddProgram(Program menu);
    }
}
