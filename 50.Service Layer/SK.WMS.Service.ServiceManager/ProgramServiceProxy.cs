using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;
using NEXCORE.Common.Data;

namespace NEXCORE.Service.ServiceManager
{
    public class ProgramServiceProxy 
    {
        private static ProgramService.ProgramServiceClient _ProgramService;

        private static string PROGRAM_SERVICE_URL = "PROGRAM_SERVICE_URL";


        public static List<Program> GetProgramList()
        {
            if (!CheckConnection())
                return null;

            return _ProgramService.GetProgramList();
        }
        public static List<Program> GetProgramList(string pgmId)
        {
            if (!CheckConnection())
                return null;

            return _ProgramService.GetProgramSelect(pgmId);
        }
        public static List<Program> GetProgramList(string pgmType, string pgmId, string pgmPath)
        {
            if (!CheckConnection())
                return null;

            return _ProgramService.GetProgramListWhereQuery(pgmType, pgmId, pgmPath);
     
        }

        public static Program GetProgram(string pgmId)
        {
            if (!CheckConnection())
                return null;
            
            return _ProgramService.GetProgram(pgmId);
        }
        public static void Reload()
        {
            if (!CheckConnection())
                return;
            
            _ProgramService.Reload();
        }
        public static void AddProgram(Program program)
        {
            if (!CheckConnection())
                return;

            _ProgramService.AddProgram(program);
        }
        public static void UpdateProgram(Program program)
        {
            if (!CheckConnection())
                return;

            _ProgramService.UpdateProgram(program);
        }
        public static void DeleteProgram(Program program)
        {
            if (!CheckConnection())
                return;

            _ProgramService.DeleteProgram(program);
        }
        private static bool CheckConnection()
        {
            if (_ProgramService == null)
            {
                string url = Skcc.Configuration.SkccFxConfigManager.GetString(PROGRAM_SERVICE_URL);

                BasicHttpBinding wsBinding = new BasicHttpBinding();
                wsBinding.MaxReceivedMessageSize = 2147483647;
                
                EndpointAddress address = new EndpointAddress(url);
              
                _ProgramService = new ProgramService.ProgramServiceClient(wsBinding, address);
            }

            return true;
        }
    }
}