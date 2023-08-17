using AulacLichKham.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AulacLichKham.DTO.HospitalExamSchedule
{
    public class LoginESResponseDTO
    {
        public string? UserExamPrkID { get; set; }
        public string? UserExamID { get; set; }
        public string? UserExamPass { get; set; }
        public string? UserExamName { get; set; }
        public string? UserExamEmail { get; set; }
        public string? UserExamPhone { get; set; }
    }
}
