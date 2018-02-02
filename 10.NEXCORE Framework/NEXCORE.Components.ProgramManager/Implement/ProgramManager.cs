using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NEXCORE.Interfaces;
using NEXCORE.Common.Data;

namespace NEXCORE.Components.ProgramManager
{
    public class ProgramManager : IProgramManager
    {
        private ProgramRepository _ProgramRepository = new ProgramRepository();

        #region IProgramManager 멤버

        public void Init()
        {
            _ProgramRepository.LoadWMSProgram();
        }

        public List<NEXCORE.Common.Data.Program> GetProgramList()
        {
            return _ProgramRepository.GetProgramList();
        }
        
        public List<NEXCORE.Common.Data.Program> GetProgramList(string authId)
        {
            return _ProgramRepository.GetProgramList();
        }
        public List<NEXCORE.Common.Data.Program> GetProgramSelect(string pgmId)
        {
            return _ProgramRepository.GetProgramList(pgmId);
        }
        public NEXCORE.Common.Data.Program GetProgram(string pgmId)
        {
            List<Program> pgmList = _ProgramRepository.GetProgramList();

            Program pa = new Program();
            var pgm = from p in pgmList
                      where p.PgmId== pgmId
                      select p;
            if (pgm.Count<Program>() > 0)
            {
                return pgm.First<Program>();
            }
            else
            {
                return pa;
            }
        }

        public void Reload()
        {
            _ProgramRepository.LoadWMSProgram();
        }

        public void AddProgram(Program program)
        {
            _ProgramRepository.AddProgram(program);
        }


        public void UpdateProgram(Program program)
        {
            _ProgramRepository.UpdateProgram(program);
        }

        public void DeleteProgram(Program program)
        {
            _ProgramRepository.DeleteProgram(program);
        }       
        #endregion
    }
}
