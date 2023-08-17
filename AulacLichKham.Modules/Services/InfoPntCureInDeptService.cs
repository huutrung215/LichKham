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
    public class InfoPntCureInDeptService : BaseService<InfoPntCureInDept>, IInfoPntCureInDeptService
    {
        public readonly IInfoPntCureInDeptRepository _repo;
        public InfoPntCureInDeptService(IInfoPntCureInDeptRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public IEnumerable<InfoPntCureInDept> Gets_InfoPntCureInDept(InfoPntCureInDeptParam entity)
        {
            return _repo.Gets_InfoPntCureInDept(entity);
        }
    }
}
