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
    public class InfoPntCureInDeptRepository : BaseRepository<InfoPntCureInDept>, IInfoPntCureInDeptRepository
    {
        public InfoPntCureInDeptRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetInfoPntCureInDept")
        {
        }

        public IEnumerable<InfoPntCureInDept> Gets_InfoPntCureInDept(InfoPntCureInDeptParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<InfoPntCureInDept>(StoredProcedure.CureExam.SP_GetInfoPntCureInDept, param, commandType: CommandType.StoredProcedure);
        }
    }
}
