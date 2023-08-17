using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IServicePfmOfPntRepository : IBaseRepository<ServicePfmOfPnt>
    {
        public string? ServicePfmOfPntFrombService(ServicePfmOfPnt entity);
    }
}
