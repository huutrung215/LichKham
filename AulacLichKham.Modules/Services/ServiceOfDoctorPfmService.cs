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
    public class ServiceOfDoctorPfmService : BaseService<ServiceOfDoctorPfm>, IServiceOfDoctorPfmService
    {
        private readonly IServiceOfDoctorPfmRepository _repo;
        public ServiceOfDoctorPfmService(IServiceOfDoctorPfmRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public IEnumerable<ServiceOfDoctorPfm> Gets_ServiceOfDoctorPfm(ServiceOfDoctorPfmParam entity)
        {
            return _repo.Gets_ServiceOfDoctorPfm(entity);
        }
    }
}
