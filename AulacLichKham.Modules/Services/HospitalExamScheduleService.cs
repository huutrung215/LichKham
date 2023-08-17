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
    public class HospitalExamScheduleService : BaseService<HospitalExamSchedule>, IHospitalExamScheduleService
    {
        private readonly IHospitalExamScheduleRepository _repo;
        public HospitalExamScheduleService(IHospitalExamScheduleRepository repo) : base(repo) 
        {
            _repo = repo;
        }
        public IEnumerable<HospitalExamSchedule> Gets_HospitalExamSchedule()
        {
            return _repo.Gets_HospitalExamSchedule();
        }
        public LoginESResponse Login_ES(LoginESRequest request)
        {
            return _repo.Login_ES(request);
        }
        public bool Register_ES(RegisterESRequest request)
        {
            return _repo.Register_ES(request);
        }
    }
}
