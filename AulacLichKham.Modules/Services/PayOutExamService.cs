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
    public class PayOutExamService : BaseService<PayOutExam>, IPayOutExamService
    {
        private readonly IPayOutExamRepository _repo;
        public PayOutExamService(IPayOutExamRepository repo) : base(repo) 
        {
            _repo = repo;
        }
        public IEnumerable<PayOutExam> Gets_DetailPayOutExamService(PayOutExamRequest request)
        {
            return _repo.Gets_DetailPayOutExamService(request);
        }
    }
}
