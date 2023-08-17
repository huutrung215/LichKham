using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IRegExamFromMachineRepository : IBaseRepository<RegExamFromMachine>
    {
        public string[] Execute_RegExamFromMachine(RegExamFromMachine entity, out string[] result);
    }
}
