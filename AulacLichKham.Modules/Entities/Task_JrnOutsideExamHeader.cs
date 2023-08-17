using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class Task_JrnOutsideExamHeader
    {
        public long? OutsideExamPrkID { get; set; }
        public long? MdcFilePrkID { get; set; }
        public int? TaskJrnExamPrkID { get; set; }
        public long? PntPrkID { get; set; }
        public string? HspInNum { get; set; }
        public int? DoctorExamPrkID { get; set; }
        public int? DeptExamPrkID { get; set; }
        public string? VchNo { get; set; }
        public string? VchName { get; set; }
        public string? SymptomsPain { get; set; }
        public DateOnly? DateExam { get; set; }
        public TimeOnly? TimeExam { get; set; }
        public int? IsPainID { get; set; }
        public int? PntStatusExam { get; set; }
        public int? DoctorReqPrkID { get; set; }
        public int? DeptReqPrkID { get; set; }
        public string? ContentReq { get; set; }
        public int? StatusReq { get; set; }
        public Boolean? IsDie { get; set; }
        public Boolean? IsMainExam { get; set; }
        public string? ExamFuncName { get; set; }
        public string? Diagnostic { get; set; }
        public string? DiagnosticInitial { get; set; }
    }
}
