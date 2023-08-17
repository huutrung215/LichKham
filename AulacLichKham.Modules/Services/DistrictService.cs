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
    public class DistrictService : BaseService<District>, IDistrictService
    {
        private readonly IDistrictRepository _repo;
        public DistrictService(IDistrictRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public IEnumerable<District> Gets_District(DistrictParam entity)
        {
            return _repo.Gets_District(entity);
        }
    }
}
