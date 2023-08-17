using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class Task_PntRegExam
    {
        public long? PntRegPrkID { get; set; }
        public int? PsnRegPrkID { get; set; }
        public string? VchNo { get; set; }
        public DateTime? VchDate { get; set; }
        public string? PntExamNo { get; set; }
        public TimeOnly? TimeRegExam { get; set; }
        public int? DeptExamPrkID { get; set; }
        public int? ModeTrmtID { get; set; }
        public string? ExamFuncName { get; set; }
        public long? MdcFilePrkID { get; set; }
        public string? HspInNum { get; set; }
        public int? PsnAcntDefaultPrkID { get; set; }
        public string? PsnRegName { get; set; }
    }
}
