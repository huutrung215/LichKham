using Aulac.Service.Global;
using Aulac.Service.Rsc.Tags;
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
    public class GetRFIDRepository : BaseRepository<GetRFID>, IGetRFIDRepository
    {
        public GetRFIDRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetRFID")
        {
        }
    }

    public class GetRFID2Repository : BaseRepository<GetRFID2>, IGetRFID2Repository
    {
        public GetRFID2Repository(IDbConnection dbConnection) : base(dbConnection, "SP_GetRFID2")
        {
        }

        public virtual RFID2Response? Execute1(GetRFID2 entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);

            param.Add(RFID.Data, direction: ParameterDirection.Output);
            param.Add(RFID.StatusCode, direction: ParameterDirection.Output);

            _dbConnection.Execute(StoredProcedure.CodeCard.SP_GetRFID2, param, commandType: CommandType.StoredProcedure);

            string? data = param.Get<string>(RFID.Data);
            string? statusCode = param.Get<string>(RFID.StatusCode);

            return new RFID2Response() { Data = data, StatusCode = statusCode };
        }
    }
}
