using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface ITownWardService : IBaseService<TownWard>
    {
        public IEnumerable<TownWard> Gets_TownWard(TownWardParam entity);
    }
}
