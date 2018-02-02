using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;
using NEXCORE.Interfaces;
using Skcc.IoC;
using NEXCORE.Components.ProgramManager;

namespace NEXCORE.Service
{
    // NOTE: If you change the class name "ProgramService" here, you must also update the reference to "ProgramService" in Web.config.
    public class ProgramService : IProgramService
    {
        public void DoWork()
        {
        }

        public List<Program> GetProgramList()
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            return pgmMgr.GetProgramList();
        }

        public List<Program> GetProgramSelect(string pgmId)
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            
            return pgmMgr.GetProgramSelect(pgmId);
        }

        public Program GetProgram(string pgmId)
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            return pgmMgr.GetProgram(pgmId);
        }

        public List<Program> GetProgramListWhereQuery( string pgmType, string pgmId, string pgmPath)
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return null;
            }
            
            List<Program> pgmList = pgmMgr.GetProgramList();
            return pgmList.Where
                (program => program.PgmType.Contains(pgmType) && program.RegId.Contains(pgmId) && program.PgmPath.Contains(pgmPath)).ToList<Program>();

        }

        public void Reload()
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return;
            }

            pgmMgr.Reload();
        }
        public void AddProgram(Program program)
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            pgmMgr.AddProgram(program);
        }

        public void DeleteProgram(Program program)
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            pgmMgr.DeleteProgram(program);
        }

        public void UpdateProgram(Program program)
        {
            IProgramManager pgmMgr = null;
            try
            {
                pgmMgr = (IProgramManager)ComponentFactory.GetObject("NexcoreProgramMgr");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
            pgmMgr.UpdateProgram(program);
        }
    }
}
