using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IGetDoctorExamInDayService : IBaseService<DoctorExamInDay>
    {
        //public string? Gets_DoctorExamInDay(RegExamParam entity, ref DataTable tb);

        public IEnumerable<DoctorExamInDay> Gets_DoctorExamInDay(RegExamParam entity);
    }
}

