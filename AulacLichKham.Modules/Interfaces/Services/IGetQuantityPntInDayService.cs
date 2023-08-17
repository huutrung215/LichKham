using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IGetQuantityPntInDayService
    {
        public IEnumerable<QuantityPntInDay> Gets_QuantityPntInDay(RegExamParam entity);
    }
}
