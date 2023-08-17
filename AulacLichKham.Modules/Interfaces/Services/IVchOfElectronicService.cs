using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IVchOfElectronicService : IBaseRepository<VchOfElectronic>
    {
        IEnumerable<VchOfElectronic> Gets_VchOfElectronic(VchOfElectronicParam entity);
    }
}
