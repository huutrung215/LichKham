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
    public class InfoPayoutOnlineRepository : BaseRepository<InfoPayoutOnline>, IInfoPayoutOnlineRepository
    {
        public InfoPayoutOnlineRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetInfoPayoutOnline")
        {
        }

        public IEnumerable<InfoPayoutOnline> Gets_InfoPayoutOnline(InfoPayoutOnlineParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<InfoPayoutOnline>(StoredProcedure.PayOutOnline.SP_GetInfoPayoutOnline, param, commandType: CommandType.StoredProcedure);
        }
    }
}
