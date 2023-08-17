using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace AulacLichKham.DTO.RegExamFrombDoctor
{
    public class RegExamFrombDoctorDTO
    {
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

    public class Response
    {
        public string statusCode { get; set; }

        public string message { get; set; }

        public string data { get; set; }

        public string success { get; set; }

        public List<Quantity> quantity { get; set; }

        public List<Doctor> doctor { get; set; }
    }

    public class Quantity
    {
        public string date { get; set; }

        public string time { get; set; }

        public string min { get; set; }

        public string max { get; set; }
    }

    public class Doctor
    {
        public string DoctorPrkID { get; set; }

        public string DoctorID { get; set; }

        public string DoctorName { get; set; }
    }

    public class RegExamResponseDTO
    {
        public string? StatusCode { get; set; }
        public string? Data { get; set; }
    }

    public class DoctorExamResponse
    {
        public string? DoctorID { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateRegExam { get; set; }
        public string? DoctorName { get; set; }
    }
    public class QuantityPntInDayResponse
    {
        public DateTime? DateTimeReg { get; set; }
        public TimeOnly? TimeRegExam { get; set; }
        public int? Quantity { get; set; }
        public int? QuantityMax { get; set; }
    }
}
