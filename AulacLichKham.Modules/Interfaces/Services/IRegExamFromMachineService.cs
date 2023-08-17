using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IRegExamFromMachineService : IBaseService<RegExamFromMachine>
    {
        public string[] Execute_RegExamFromMachine(RegExamFromMachine entity, out string[] result);
    }
}
