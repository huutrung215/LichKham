using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class MdcFile_PntLog
    {
        public long? MdcFilePrkID { get; set; }
        public int? PntLogPrkID { get; set; }
        public string? PntExamNo { get; set; }
        public string? HspInNum { get; set; }
        public long? VchOrgID { get; set; }
        public int? VchOrgTypeID { get; set; }
        public DateOnly? VchDate { get; set; }
        public int? DeptExamPrkID { get; set; }
        public int? ModeTrmtID { get; set; }
        public int? PntOrgLogPrkID { get; set; }
        public int? PntStatusExam { get; set; }
        public int? PntRdcObjPrkID { get; set; }
        public int? IsActive { get; set; }
        public int? PntOrgStatusExam { get; set; }
    }
}
