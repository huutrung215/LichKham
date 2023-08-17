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
    public class VchOfElectronicRepository : BaseRepository<VchOfElectronic>, IVchOfElectronicRepository
    {
        public VchOfElectronicRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetListVchOfElectronic")
        {
        }

        public IEnumerable<VchOfElectronic> Gets_VchOfElectronic(VchOfElectronicParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<VchOfElectronic>(StoredProcedure.CureExam.SP_GetListVchOfElectronic, param, commandType: CommandType.StoredProcedure);
        }
    }
}
