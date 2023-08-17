using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class MdcFile_OutsideExamHeader
    {
        public long? OutsideExamPrkID { get; set; }
        public long? MdcFilePrkID { get; set; }
        public string? HspInNum { get; set; }
        public string? VchNo { get; set; }
        public string? VchName { get; set; }
        public DateOnly? VchDate { get; set; }
        public string? PntExamNo { get; set; }
        public DateOnly? DateExam { get; set; }
        public int? DeptExamPrkID { get; set; }
        public int? DoctorExamPrkID { get; set; }
        public int? IsPainID { get; set; }
        public Boolean? IsDie { get; set; }
        public int? GuideTrmtID { get; set; }    
        public int? ModeTrmtID { get; set; }
        public string? GuideNote { get; set; }
        public long? VchOrgID { get; set; }
        public int? VchOrgTypeID { get; set; }
        public string? Note { get; set; }
        public string? SymptomsPain { get; set; }
        public string? ExamFuncName { get; set; }
        public Boolean? IsMainExam { get; set; }
        public TimeOnly? TimeExam { get; set; }
        public int? HspTranToPrkID { get; set; }
        public int? TranTypeID { get; set; }
        public string? PainID { get; set; }
        public string? PainName { get; set; }
        public string? Icd10ID { get; set; }
        public string? IcdName { get; set; }
        public Boolean? IsActive { get; set; }
        public string? ResonInCure { get; set; }
        public int? PsnPfmPrkID { get; set; }
        public DateOnly? DateEndExam { get; set; }
        public TimeOnly? TimeEndExam { get; set; }
        public string? Diagnostic { get; set; }
        public long? DgnPrkID { get; set; }
        public int? FuncExamID { get; set; }
        public DateOnly? DateExamRepeat { get; set; }
        public DateOnly? DateSickLeave { get; set; }
        public string? DiagnosticInitial { get; set; }
    }
}
