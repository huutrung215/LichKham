using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IDoctorPfmService : IBaseService<DoctorPfm>
    {
        public IEnumerable<DoctorPfm> Gets_DoctorPfm(DoctorPfmRequest request);

    }
}
