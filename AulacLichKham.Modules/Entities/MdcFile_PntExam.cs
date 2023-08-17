using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class MdcFile_PntExam
    {
        public long? MdcFilePrkID { get; set; }
        public DateOnly? VchDate { get; set; }
        public long? PntPrkID { get; set; }
        public string? PntID { get; set; }
        public string? PntName { get; set; }
        public DateOnly? PntBirthday { get; set; }
        public int? PntBirthYear { get; set; }
        public int? PntAge { get; set; }
        public int? PntUnitAgeID { get; set; }
        public string? PntAddr { get; set; }
        public int? PntRacePrkID { get; set; }
        public int? PntSexID { get; set; }
        public int? PntTownWardPrkID { get; set; }
        public string? PntTownWardName { get; set; }
        public int? PntDistrictPrkID { get; set; }
        public string? PntDistrictName { get; set; }
        public int? PntProvincePrkID { get; set; }
        public string? PntProvinceName { get; set; }
        public int? PntCountryPrkID { get; set; }
        public string? PntCountryName { get; set; }
        public int? PntJobGrpPrkID { get; set; }
        public string? PntJobGrpName { get; set; }
        public string? PntPlaceWork { get; set; }
        public string? PntPhone { get; set; }
        public string? PntContactAdd { get; set; }
        public string? PntContact { get; set; }
        public string? ContactTitle { get; set; }
        public string? IcdPrsntID { get; set; }
        public string? IcdPrsntName { get; set; }
        public int? TotalCure { get; set; }
        public int? DeptInPrkID { get; set; }
        public int? DeptOutPrkID { get; set; }
        public DateTime? DateTimeIn { get; set; }
        public DateTime? DateTimeOut { get; set; }
        public DateTime? DateTimeExam { get; set; }
        public int? TranFromHspTypeID { get; set; }
        public string? TranFromOfficeName { get; set; }
        public string? TranFromOfficeCode { get; set; }
        public int? TranFromOfficePrkID { get; set; }
        public Boolean? IsActive { get; set; }
        public string? ReasonExam { get; set; }
        public string? DgnsFrom { get; set; }
        public Boolean? IsKcbDgTuyen { get; set; }
        public Boolean? IsPntEmergency { get; set; }
        public int? FncStylePntPrkID { get; set; }
        public string? HspInNum { get; set; }
        public int? AcdntTypeID { get; set; }
        public Boolean? IsAcdntIns { get; set; }
        public DateOnly? DateRegExam { get; set; }
        public Boolean? IsReCalcPricePnt { get; set; }
        public int? PntMitaryRanksPrkID { get; set; }
        public int? PntWorkPlacePrkID { get; set; }
        public int? PntObjExamTypeID { get; set; }
        public string? SoCMND { get; set; }
        public string? SoCMNDContact { get; set; }
        public string? PntAddrCurrent { get; set; }
        public Boolean? IsRegExambDoctor { get; set; }
        public string? VchNoIntroduce { get; set; }
        public DateOnly? VchDateTranHspFrom { get; set; }
        public int ContactTitleID { get; set; }
        public string? CardCode { get; set; }
        public DateOnly? DateCertificationOfTB { get; set; }
        public string? HspInsCodeTB { get; set; }
        public string? HspInsNameTB { get; set; }
        public int? MedicalFacilityID { get; set; }
    }
}
