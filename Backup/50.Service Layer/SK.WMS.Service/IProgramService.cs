using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NEXCORE.Common.Data;

namespace NEXCORE.Service
{
    // NOTE: If you change the interface name "IProgramService" here, you must also update the reference to "IProgramService" in Web.config.
    [ServiceKnownType(typeof(DBNull))]
    [ServiceContract]
    public interface IProgramService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Program> GetProgramList();

        [OperationContract]
        List<Program> GetProgramSelect(string pgmId);
        [OperationContract]
        Program GetProgram(string pgmId);

        [OperationContract]
        List<Program> GetProgramListWhereQuery(string pgmType, string pgmId, string pgmPath);

        [OperationContract]
        void Reload();
        [OperationContract]
        void AddProgram(Program menu);

        [OperationContract]
        void DeleteProgram(Program menu);

        [OperationContract]
        void UpdateProgram(Program menu);
    }
}
