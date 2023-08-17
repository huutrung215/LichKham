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
    public class InsCardFastMachineSevice : BaseService<InsCardFastMachine>, IInsCardFastMachineService
    {
        public readonly IInsCardFastMachineRepository _repo;
        public InsCardFastMachineSevice(IInsCardFastMachineRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public string? InsCardFastMachineFrombAccount(InsCardFastMachine entity)
        {
            return _repo.Execute(entity);
        }
    }
}
