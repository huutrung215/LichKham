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
    public class InfoPayoutOnlineService : BaseService<InfoPayoutOnline>, IInfoPayoutOnlineService
    {
        public readonly IInfoPayoutOnlineRepository _repo;
        public InfoPayoutOnlineService(IInfoPayoutOnlineRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public IEnumerable<InfoPayoutOnline> Gets_InfoPayoutOnline(InfoPayoutOnlineParam entity)
        {
            return _repo.Gets_InfoPayoutOnline(entity);
        }
    }
}
