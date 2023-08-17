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
    public class FuncExamService:BaseService<FuncExam>, IFuncExamService
    {
        private readonly IFuncExamRepository _repo;
        public FuncExamService(IFuncExamRepository repo) : base(repo)
        {
            _repo = repo;
        }

        /*public IEnumerable<FuncExam> Gets_FuncExam(FuncExamParam entity)
        {
            return _repo.Gets_FuncExam(entity);
        }*/
    }
}
