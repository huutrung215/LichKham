using AulacLichKham.Modules;
using System.ComponentModel.DataAnnotations;

namespace AulacLichKham.DTO.DoctorPfm
{
    public class DoctorPfmDTO
    {
        public string? DoctorPrkID { get; set; }
        public string? DoctorID { get; set; }
        public string? DoctorName { get; set; }
    }

    public class DoctorExamDTO
    {
        public string? DoctorID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateRegExam { get; set; }

        public string DoctorPrkID { get; set; }
        public string? DoctorName { get; set; }
    }
}
