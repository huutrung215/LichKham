using AulacLichKham.Attributes;

namespace AulacLichKham.DTO.FuncExam
{
    public class FuncExamRequest
    {
        [RequiredCustom]
        public int? FuncExamID { get; set; }
        [RequiredCustom]
        public string? FuncExamName { get; set; }
    }
}
