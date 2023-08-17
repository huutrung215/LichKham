using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class ServiceReqOfPntRepository : BaseRepository<ServiceReqOfPnt>, IServiceReqOfPntRepository
    {
        public ServiceReqOfPntRepository(IDbConnection dbConnection) : base(dbConnection, "SP_SetServiceReqOfPnt")
        {
        }

        public string? ServicePfmOfPntFrombService(ServiceReqOfPnt entity)
        {
            return base.Execute(entity);
        }
    }
}
