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
    public class ServiceOfDoctorPfmRepository : BaseRepository<ServiceOfDoctorPfm>, IServiceOfDoctorPfmRepository
    {
        public ServiceOfDoctorPfmRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetListServiceOfDoctorPfm")
        {
        }

        public virtual IEnumerable<ServiceOfDoctorPfm> Gets_ServiceOfDoctorPfm(ServiceOfDoctorPfmParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<ServiceOfDoctorPfm>(StoredProcedure.ServiceOfDoctorPfm.SP_GetListServiceOfDoctorPfm, param, commandType: CommandType.StoredProcedure);
        }

        
    }
}
