using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class GetQuantityPntInDayService : BaseService<QuantityPntInDay>, IGetQuantityPntInDayService
    {
        private readonly IGetQuantityPntInDayReopsitory _repo;

        public GetQuantityPntInDayService(IGetQuantityPntInDayReopsitory repo) : base(repo)
        {
            _repo = repo;
        }

        public virtual IEnumerable<QuantityPntInDay> Gets_QuantityPntInDay(RegExamParam entity)
        {
            return _repo.Gets_QuantityPntInDay(entity);
        }
    }
}
