using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IServiceReqOfPntRepository : IBaseRepository<ServiceReqOfPnt>
    {
        string? Execute(ServiceReqOfPnt entity);
        public string? ServicePfmOfPntFrombService(ServiceReqOfPnt entity);
    }
}
