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
    public class RegExamFromMachineService : BaseService<RegExamFromMachine>, IRegExamFromMachineService
    {
        public readonly IRegExamFromMachineRepository _repo;
        public RegExamFromMachineService(IRegExamFromMachineRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public string[] Execute_RegExamFromMachine(RegExamFromMachine entity, out string[] result)
        {
            _repo.Execute_RegExamFromMachine(entity, out result);

            return result;
        }
    }
}
