using AulacLichKham.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AulacLichKham.DTO.HospitalExamSchedule
{
    public class RegisterRequest
    {
        [RequiredCustom]
        [Display(Name = "Tên đăng nhập")]
        public string? UserExamID { get; set; }
        [RequiredCustom]
        [Display(Name = "Mật khẩu")]
        public string? UserExamPass { get; set; }
        [RequiredCustom]
        [Display(Name = "Tên người dùng")]
        public string? UserExamName { get; set; }
        [RequiredCustom]
        [Display(Name = "Email")]
        public string? UserExamEmail { get; set; }
        [RequiredCustom]
        [Display(Name = "Số điện thoại")]
        public string? UserExamPhone { get; set; }
    }
}
