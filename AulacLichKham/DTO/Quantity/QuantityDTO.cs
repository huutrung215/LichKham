using AulacLichKham.Modules;
using System.ComponentModel.DataAnnotations;

namespace AulacLichKham.DTO.Quantity
{
    public class QuantityDTO
    {
        [DataType(DataType.Date)]
        public DateTime? DateTimeReg { get; set; }

        [DataType(DataType.Time)]
        public DateTime? TimeRegExam { get; set; }
        public int? QuantityMin { get; set; }
        public int? QuantityMax { get; set; }
        
    }
}
