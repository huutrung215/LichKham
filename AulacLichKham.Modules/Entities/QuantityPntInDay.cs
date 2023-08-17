using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class QuantityPnt : IEntity
    {
        public long? MdcFilePrkID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateRegExam { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? TimeRegExam { get; set; }
        public int? DeptExamPrkID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateExam { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan? TimeExam { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateEndExam { get; set; }

        [DataType(DataType.Date)]
        public TimeSpan? TimeEndExam { get; set; }
    }
}
