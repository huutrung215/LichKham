using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IHospitalExamScheduleService : IBaseService<HospitalExamSchedule>
    {
        public IEnumerable<HospitalExamSchedule> Gets_HospitalExamSchedule();
        public LoginESResponse Login_ES(LoginESRequest request);
        public bool Register_ES(RegisterESRequest request);

    }
}
