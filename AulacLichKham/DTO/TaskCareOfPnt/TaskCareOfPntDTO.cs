namespace AulacLichKham.DTO.TaskCareOfPnt
{
    public class TaskCareOfPntDTO
    {
        public string? TaskCareOfPntPrkID { get; set; }
        public string? VchTypeID { get; set; }
        public string? MdcFilePrkID { get; set; }

        public string? DatePfm { get; set; }

        public string? TimePfm { get; set; }

        public string? EvolutionOfPnt { get; set; }

        public string? PfmMedicalInstruction { get; set; }

        public string? PsnPfmPrkID { get; set; }

        public string? PsnPfmID { get; set; }

        public string? PsnPfmName { get; set; }

        public string? DoctorPfmPrkID { get; set; }

        public string? DoctorPfmID { get; set; }

        public string? DoctorPfmName { get; set; }

        public string? DeptCurePrkID { get; set; }

        public string? DeptCureID { get; set; }

        public string? DeptCureName { get; set; }

        public string? DrugRequest { get; set; }

        public string? CLSRequest { get; set; }

        public string? PTTRequest { get; set; }

        public string? CountPack { get; set; }

        public string? DateTreatment { get; set; }
    }
    public class VchPttPntDTO
    {
        public string? VchPTTPntPrkID { get; set; } = null;
        public string? MdcFilePrkID { get; set; }
        public string? VchTypeID { get; set; }
        public string? VchNo { get; set; }
        public string? VchName { get; set; }
        public string? DeptReqPrkID { get; set; }
        public string? DeptReqID { get; set; }
        public string? DeptReqName { get; set; }
        public string? DoctorReqPrkID { get; set; }
        public string? DoctorReqID { get; set; }
        public string? DoctorReqName { get; set; }
        public string? DeptPfmPrkID { get; set; }
        public string? DeptPfmID { get; set; }
        public string? DeptPfmName { get; set; }
        public string? DoctorPfmPrkID { get; set; }
        public string? DoctorPfmID { get; set; }
        public string? DoctorPfmName { get; set; }
        public string? Diagnostic { get; set; }
    }
    public class MdnItemsDTO
    {
        public string? ItemPrkID { get; set; }
        public string? ItemID { get; set; }
        public string? ItemName { get; set; }
        public string? Unit { get; set; }
        public string? PriceSellInExc { get; set; }
    }
    public class ItemsSubTypeDTO
    {
        public string? ItemSubTypeID { get; set; }
        public string? ItemSubTypeName { get; set; }
    }
    public class DeptPfmClsDTO
    {
        public string? DeptPfmPrkID { get; set; }

        public string? DeptPfmID { get; set; }

        public string? DeptPfmName { get; set; }
    }
}
