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
    public class CureExamService:BaseService<CureExam>, ICureExamService
    {
        private readonly ICureExamRepository _repo;

        public CureExamService(ICureExamRepository repo) : base(repo)
        {
            _repo = repo;
        }
        public IEnumerable<CureExam> Gets_PntCureOfBedNum(CureExamRequest request)
        {
            return _repo.Gets_PntCureOfBedNum(request);
        }
        public IEnumerable<BedNumOfDept> Gets_BedNumOfDept(BedNumOfDeptRequest request)
        {
            return _repo.Gets_BedNumOfDept(request);
        }
    }
}
