namespace AulacLichKham.DTO.CureExam
{
    //PntCureOfBedNumDTO
    public class CureExamDTO
    {
        public string? MdcFilePrkID { get; set; }
        public string? PntName { get; set; }
        public string? PntBirthday { get; set; }
        public string? DateInCure { get; set; }
        public string? PntExamNo { get; set; }
        public string? ModeTrmtID { get; set; }
        public string? BedNum { get; set; }
    }
    public class BedNumOfDeptDTO
    {
        public string? BedNum { get; set;}
    }
    /*public class PntCureOfBedNumRequestDTO
    {
        public int? DeptCurePrkID { get; set; }
        public string? PntName { get; set; }
        public string? BedNum { get; set; }
    }*/
}
