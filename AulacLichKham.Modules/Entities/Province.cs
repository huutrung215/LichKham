using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class Province:IEntity
    {
 
        [PrimaryKey]
        public int? ProvincePrkID { get; set; }
        public string? PrvnCode { get; set; }
        public string? ProvinceID { get; set; }
        public string? ProvinceName { get; set; }
        public string? ProvinceRegion { get; set; }
        public bool? IsActive { get; set; }
        public string? PrvnInsID { get; set; }
    }
}
