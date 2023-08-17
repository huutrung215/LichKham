using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class ServicePfmOfPntRepository : BaseRepository<ServicePfmOfPnt>, IServicePfmOfPntRepository
    {
        public ServicePfmOfPntRepository(IDbConnection dbConnection) : base(dbConnection, "SP_CancelServicePfmOfPnt")
        {
        }

        public string? ServicePfmOfPntFrombService(ServicePfmOfPnt entity)
        {
            return base.Execute(entity);
        }
    }
}
