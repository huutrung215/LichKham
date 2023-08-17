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
    public class DoctorPfmService : BaseService<DoctorPfm>, IDoctorPfmService
    {
        private readonly IDoctorPfmRepository _repo;
        public DoctorPfmService(IDoctorPfmRepository repo) : base(repo) 
        {
            _repo = repo;
        }
        public IEnumerable<DoctorPfm> Gets_DoctorPfm(DoctorPfmRequest request)
        {
            return _repo.Gets_DoctorPfm(request);
        }
    }
}
