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
    public class TownWardRepository : BaseRepository<TownWard>, ITownWardRepository
    {
        public TownWardRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetListTownWard")
        {
        }

        public virtual IEnumerable<TownWard> Gets_TownWard(TownWardParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<TownWard>(StoredProcedure.TownWard.SP_GetListTownWard, param, commandType: CommandType.StoredProcedure);
        }
    }
}
