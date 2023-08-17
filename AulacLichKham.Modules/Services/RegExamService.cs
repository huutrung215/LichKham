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
    public class RegExamService : BaseService<RegExam>, IRegExamService
    {
        private readonly IRegExamRepository _repo;
        public RegExamService(IRegExamRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public virtual RegExamResponse? ExecuteRegExam(RegExam entity)
        {
            return _repo.ExecuteRegExam(entity);
        }

     
    }

    public class CacelExamFrombDoctorService : BaseService<ExamFrombDoctor>, ICacelExamFrombDoctorService
    {
        private readonly ICacelExamFrombDoctorRepository _repo;
        public CacelExamFrombDoctorService(ICacelExamFrombDoctorRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public string? CancelExamFrombDoctor(ExamFrombDoctor entity)
        {
            return _repo.Execute(entity);
        }
    }

    public class GetStatusExamOfPntbDoctorService : BaseService<ExamFrombDoctor>, IGetStatusExamOfPntbDoctorService
    {
        private readonly IGetStatusExamOfPntbDoctorRepository _repo;
        public GetStatusExamOfPntbDoctorService(IGetStatusExamOfPntbDoctorRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public string? GetStatusExamOfPntbDoctor(ExamFrombDoctor entity)
        {
            return _repo.Execute(entity);
        }
    }
}
