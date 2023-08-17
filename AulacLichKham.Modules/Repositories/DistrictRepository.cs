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
    public class DistrictRepository : BaseRepository<District>,IDistrictRepository
    {
        public DistrictRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetDistrict")
        {
        }

        public virtual IEnumerable<District> Gets_District(DistrictParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<District>(StoredProcedure.District.SP_GetDistrict, param, commandType: CommandType.StoredProcedure);
        }
    }
}
