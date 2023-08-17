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
    public class GetDoctorExamInDayService : BaseService<DoctorExamInDay>, IGetDoctorExamInDayService
    {
        private readonly IGetDoctorExamInDayRepository _repo;
        public GetDoctorExamInDayService(IGetDoctorExamInDayRepository repo) : base(repo)
        {
            _repo = repo;
        }
        //public string? Gets_DoctorExamInDay(RegExamParam entity, ref DataTable tb)
        //{
        //    return _repo.Gets_DoctorExamInDay(entity, ref tb);
        //}

        public virtual IEnumerable<DoctorExamInDay> Gets_DoctorExamInDay(RegExamParam entity)
        {
            return _repo.Gets_DoctorExamInDay(entity);
        }
    }
}
