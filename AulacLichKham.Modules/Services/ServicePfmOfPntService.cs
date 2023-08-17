using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class ServicePfmOfPntService : BaseService<ServicePfmOfPnt>, IServicePfmOfPntService
    {
        public readonly IServicePfmOfPntRepository _repo;

        public ServicePfmOfPntService(IServicePfmOfPntRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public string? ServicePfmOfPntFrombService(ServicePfmOfPnt entity)
        {
            return _repo.Execute(entity);
        }

    }
}
