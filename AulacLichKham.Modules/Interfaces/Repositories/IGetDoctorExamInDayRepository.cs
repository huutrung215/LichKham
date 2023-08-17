using AulacLichKham.Modules.Entities;
using System.Data;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IGetDoctorExamInDayRepository : IBaseRepository<DoctorExamInDay>
    {
        //public string? Gets_DoctorExamInDay(RegExamParam entity, ref DataTable tb);

        public IEnumerable<DoctorExamInDay> Gets_DoctorExamInDay(RegExamParam entity);
    }
}
