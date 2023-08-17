using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulacLichKham.Modules.Entities;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IRegExamRepository : IBaseRepository<RegExam>
    {

        public RegExamResponse? ExecuteRegExam(RegExam entity);
        //public string? Execute_RegExamFrombDoctor(RegExam entity, string[] result, out string value);
    }

    public interface ICacelExamFrombDoctorRepository : IBaseRepository<ExamFrombDoctor>
    {
        public string? CancelExamFrombDoctor(ExamFrombDoctor entity);
    }

    public interface IGetStatusExamOfPntbDoctorRepository : IBaseRepository<ExamFrombDoctor>
    {
        public string? GetStatusExamOfPntbDoctor(ExamFrombDoctor entity);
    }
}
