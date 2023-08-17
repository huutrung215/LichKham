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
    public class TownWardService : BaseService<TownWard>, ITownWardService
    {
        private readonly ITownWardRepository _repo;
        public TownWardService(ITownWardRepository repo) : base(repo)
        {
            _repo = repo;
        }
        public IEnumerable<TownWard> Gets_TownWard(TownWardParam entity)
        {
            return _repo.Gets_TownWard(entity);
        }
    }
}
