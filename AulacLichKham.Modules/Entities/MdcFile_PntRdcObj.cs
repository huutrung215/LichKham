using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class MdcFile_PntRdcObj
    {
        public long? MdcFilePrkID { get; set; }
        public int? PntRdcObjPrkID { get; set; }
        public int? RdcObjPrkID { get; set; }
        public string? RdcObjName { get; set; }
        public string? RdcObjID { get; set; }
        public float? RdcObjRate { get; set; }
        public int? RdcInsLevel { get; set; }
        public string? InsNum { get; set; }
        public string? InsOfiRegCode { get; set; }
        public string? InsPrvnRegCode { get; set; }
        public int? InsRegExamPrkID { get; set; }
        public string? InsRegExamName { get; set; }
        public DateOnly? DateInsStart { get; set; }
        public DateOnly? DateInsEnd { get; set; }
        public string? InsOfiFullRegCode { get; set; }
        public Boolean? IsInsObj { get; set; }
        public Boolean? IsValidIns { get; set; }
        public DateOnly? DateStartExam { get; set; }
        public DateOnly? DateEndExam { get; set; }
        public Boolean? IsActive { get; set; }
        public long? VchOrgID { get; set; }
        public int? VchOrgTypeID { get; set; }
        public Boolean? IsKcbDgTuyen { get; set; }
        public string? TranFromHspTypeID { get; set; }
        public int? TranFromOfficePrkID { get; set; }
        public string? TranFromOfficeCode { get; set; }
        public DateOnly? VchDate { get; set; }
        public int? FncStylePntPrkID { get; set; }
        public Boolean? IsChildNotCard { get; set; }
        public string? RegionKcb { get; set; }
        public Boolean? IsInsTo5Year { get; set; }
        public Boolean? DateInsTo5YearRdc { get; set; }
        public DateOnly? DateInsTo5Year { get; set; }
        public string? AddrInsCard { get; set; }
        public Boolean? IsCheckIns { get; set; }
        public Boolean? IsTemporaryResidence { get; set; }
    }
}
