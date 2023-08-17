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
    public class DoctorPfmRepository : BaseRepository<DoctorPfm>, IDoctorPfmRepository
    {
        public DoctorPfmRepository(IDbConnection dbConnection) : base(dbConnection, StoredProcedure.DoctorPfm.SP_GetListDoctorPfmService) 
        {
        }
        public IEnumerable<DoctorPfm> Gets_DoctorPfm(DoctorPfmRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<DoctorPfm>(StoredProcedure.DoctorPfm.SP_GetListDoctorPfmService, param, commandType: CommandType.StoredProcedure);
        }

    }
}
