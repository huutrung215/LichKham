using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AulacLichKham.Modules.Entities;


namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IRegExamService : IBaseService<RegExam>
    {
        public RegExamResponse? ExecuteRegExam(RegExam entity);
    
    }

    public interface ICacelExamFrombDoctorService : IBaseService<ExamFrombDoctor>
    {
        public string? CancelExamFrombDoctor(ExamFrombDoctor entity);
    }

    public interface IGetStatusExamOfPntbDoctorService : IBaseService<ExamFrombDoctor>
    {
        public string? GetStatusExamOfPntbDoctor(ExamFrombDoctor entity);
    }
}
