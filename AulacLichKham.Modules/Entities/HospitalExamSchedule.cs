using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class HospitalExamSchedule : IEntity
    {
        [PrimaryKey]
        public int? HspExamPrkID { get; set; }
        public string? HspInsID { get; set; }
        public string? HspExamName { get; set; }
        public string? HspInsCode { get; set; }
        public string? HspExamAddr { get; set; }
        public string? HspExamHotline { get; set; }
        public string? HspExamEmail { get; set; }
        public string? HspExamPhone { get; set; }
        public string? IsActive { get; set; }
    }
    public class LoginESRequest : IEntity
    {
        public string? UserExamID { get; set; }
        public string? UserExamPass { get; set; }
    }
    public class LoginESResponse : IEntity
    {
        [PrimaryKey]
        public string? UserExamPrkID { get; set; }
        public string? UserExamID { get; set; }
        public string? UserExamPass { get; set; }
        public string? UserExamName { get; set; }
        public string? UserExamEmail { get; set; }
        public string? UserExamPhone { get; set; }
    }
    public class RegisterESRequest : IEntity
    {
        public string? UserExamID { get; set; }
        public string? UserExamPass { get; set; }
        public string? UserExamName { get; set; }
        public string? UserExamEmail { get; set; }
        public string? UserExamPhone { get; set; }
    }
}
