using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    //PntCureOfBedNum
    public class CureExam : IEntity
    {
        [PrimaryKey]
        public string? MdcFilePrkID { get; set; }
        public string? PntName { get; set; }
        public string? PntBirthday { get; set; }
        public string? DateInCure { get; set; }
        public string? PntExamNo { get; set; }
        public string? ModeTrmtID { get; set; }
        public string? BedNum { get; set; }
    }
    public class CureExamRequest : IEntity
    {
        [PrimaryKey]
        public string? DeptCurePrkID { get; set; }
        public string? PntName { get; set; }
        public string? BedNum { get; set; }
    }

    public class BedNumOfDept : IEntity
    {
        [PrimaryKey]
        public string? BedNum { get; set; }
    }
    public class BedNumOfDeptRequest : IEntity
    {
        [PrimaryKey]
        public string? DeptCurePrkID { get; set; }
    }
}
