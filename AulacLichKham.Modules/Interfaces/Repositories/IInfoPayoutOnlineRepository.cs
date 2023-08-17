using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IInfoPayoutOnlineRepository : IBaseRepository<InfoPayoutOnline>
    {
        public IEnumerable<InfoPayoutOnline> Gets_InfoPayoutOnline(InfoPayoutOnlineParam entity);
    }
}
