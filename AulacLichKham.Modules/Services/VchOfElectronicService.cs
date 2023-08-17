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
    public class VchOfElectronicService : BaseService<VchOfElectronic>, IVchOfElectronicService
    {
        public readonly IVchOfElectronicRepository _repo;
        public VchOfElectronicService(IVchOfElectronicRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public IEnumerable<VchOfElectronic> Gets_VchOfElectronic(VchOfElectronicParam entity)
        {
            return _repo.Gets_VchOfElectronic(entity);
        }
    }
}
