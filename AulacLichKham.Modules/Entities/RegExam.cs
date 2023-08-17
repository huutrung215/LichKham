using AulacLichKham.Modules.Utils;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class RegExam : IEntity
    {
        [PrimaryKey]
        public string? StatusCode { get; set; }
        public string? DoctorID { get; set; }
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Birthday { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? InsuranceNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateInsStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateInsEnd { get; set; }
        public string? MaKCBBD { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime? Time { get; set; }
        public string? HspInsID { get; set; }
        public string? TextArea { get; set; }
        public Boolean? Order { get; set; }
        public string? NameBook { get; set; }
        public string? AddressBook { get; set; }
        public string? TownWardBook { get; set; }
        public string? DistrictBook { get; set; }
        public string? ProvinceBook { get; set; }
        public string? Service { get; set; }
        public float? Price { get; set; }
        public string? Data { get; set; }
    }

    public class RegExamResponse : IEntity
    {
        public string? StatusCode { get; set; }
        public string? Data { get; set; }
    }

    public class DoctorExamInDay : IEntity
    {
        public string? DoctorID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateRegExam { get; set; }

        public string DoctorPrkID { get; set; }
        public string? DoctorName { get; set; }
    }

    public class RegExamParam : IEntity
    {
        public string? HspInsID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }

    public class QuantityPntInDay : IEntity
    {
        public DateTime? DateTimeReg { get; set; }
        public TimeSpan? TimeRegExam { get; set;}
        public int? Quantity { get; set;}
        public int? QuantityMax { get; set; }
    }

    public class ExamFrombDoctor : IEntity
    {
        [PrimaryKey]
        public string? StatusCode { get; set; }
        public string? HspInsID { get; set; }
        public string? PntExamNo { get; set; }
        public string? InsuranceNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
    }
}
