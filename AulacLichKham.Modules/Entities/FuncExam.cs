using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class FuncExam:IEntity
    {
        [PrimaryKey]
        public int? FuncExamID { get; set; }
        public string? FuncExamName { get; set; }
        public int? FuncExamTypeID { get; set; }
        public bool? IsActive { get; set; }
        public int? ItemFeeDefaultPrkID { get; set; }
        public int? SpecialistPrkID { get; set; }
    }

   /* public class FuncExamParam : IEntity
    {
        [PrimaryKey]
        public int? FuncExamID { get; set; }
        public string? FuncExamName { get; set; }
    }*/
}
