using AulacLichKham.Attributes;
using AulacLichKham.Modules;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AulacLichKham.DTO.HospitalExamSchedule
{
    public class LoginRequest
    {
        [RequiredCustom]
        [Display(Name = "Tên đăng nhập")]
        public string? UserExamID { get; set; }
        [RequiredCustom]
        [Display(Name = "Mật khẩu")]
        public string? UserExamPass { get; set; }
    }
}
