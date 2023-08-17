using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class  District : IEntity
    {
        [PrimaryKey]
        public int? DistrictPrkID { get; set; }
        public string? DistrictID { get; set; }
        public string? DistrictFullID { get; set; }
        public string? ProvinceID { get; set; }
        public string? DistrictName { get; set; }
        public bool? IsActive { get; set; }
        public string? DistrictInsID { get; set; }
    }

    public class DistrictParam : IEntity
    {
        public int? DistrictPrkID { get; set; }
        public string? DistrictID { get; set; }
        public string? DistrictInsID { get; set; }
    }
}
