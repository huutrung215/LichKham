using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class MdcFile_PntInfo
    {
        public long? PntPrkID { get; set; }
        public string? PntID { get; set; }
        public string? PntName { get; set; }
        public DateOnly? PntBirthday { get; set; }
        public int? PntBirthYear { get; set; }
        public string? PntAddr { get; set; }
        public int? PntRacePrkID { get; set; }
        public int? PntSexID { get; set; }
        public int? PntTownWardPrkID { get; set; }
        public int? PntDistrictPrkID { get; set; }
        public int? PntProvincePrkID { get; set; }
        public int? PntCountryPrkID { get; set; }
        public int? PntJobGrpPrkID { get; set; }
        public string? PntPlaceWork { get; set; }
        public string? PntPhone { get; set; }
        public string? InsNum { get; set; }
        public DateTime? DateInsStart { get; set; }
        public DateTime? DateInsEnd { get; set; }
        public Boolean? IsActive { get; set; }
        public string? PrvnInsID { get; set; }
        public string? HspInsID { get; set; }
        public int? PntMitaryRanksPrkID { get; set; }
        public int? PntWorkPlacePrkID { get; set; }
        public string? ContactTitle { get; set; }
        public string? PntContact { get; set; }
        public string? PntContactAdd { get; set; }
        public string? SoCMND { get; set; }
        public Boolean? IsGetIDHSSK { get; set; }
        public string? SoCMNDContact { get; set; }
        public string? PntAddrCurrent { get; set; }
        public string? PntCardCode { get; set; }
    }
}
