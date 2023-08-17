using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class RegExamFromMachineRepository : BaseRepository<RegExamFromMachine>, IRegExamFromMachineRepository
    {
        public RegExamFromMachineRepository(IDbConnection dbConnection) : base(dbConnection, "SP_RegExamFrombDoctor")
        {
        }

        public virtual string[] Execute_RegExamFromMachine(RegExamFromMachine entity, out string[] result)
        {
            string outputDataName = "@Data";
            string statusCodeName = "@StatusCode";

            var param = ParamHelper.GetParamOnlyTable(entity);
            param.Add(outputDataName, dbType: DbType.String, direction: ParameterDirection.Output, size: 20);
            param.Add(statusCodeName, dbType: DbType.String, direction: ParameterDirection.Output, size: 3);

            _dbConnection.Execute("SP_RegExamFrombDoctor", param, commandType: CommandType.StoredProcedure);

            string outputData = param.Get<string>(outputDataName);
            string statusCode = param.Get<string>(statusCodeName);

            result = new string[] { statusCode, outputData };

            return result;
        }
    }
}
