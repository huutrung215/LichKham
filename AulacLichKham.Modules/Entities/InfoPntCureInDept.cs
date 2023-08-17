using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class InfoPntCureInDept : IEntity
    {
        [PrimaryKey]
        public string? MdcFilePrkID { get; set; }
        public string? PntName { get; set; }
        public string? PntBirthday { get; set; }
        public string? PntAge { get; set; }
        public string? PntSexID { get; set; }
        public string? PntUnitAgeID { get; set; }
        public string? PntPhone { get; set; }
        public string? DateInCure { get; set; }
        public string? PntExamNo { get; set; }
        public string? ModeTrmtID { get; set; }
        public string? BedNum { get; set; }
        public string? ClassNum { get; set; }
        public string? DeptCureID { get; set; }
        public string? DeptCureName { get; set; }
        public string? Diagnostic { get; set; }
    }

    public class InfoPntCureInDeptParam : IEntity
    {
        [PrimaryKey]
        public string? ID { get; set; }
        public string? MdcFilePrkID { get; set; }
    }
}
