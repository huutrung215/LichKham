using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class TownWard : IEntity
    {
        [PrimaryKey]
        public int? TownWardPrkID { get; set; }
        public string? TownWardID { get; set; }
        public string? TownWardFullID { get; set; }
        public string? DistrictID { get; set; }
        public string? TownWardName { get; set; }
        public string? TownWardSig { get; set; }
        public bool? IsActive { get; set; }
        public string? TownWardInsID { get; set; }
    }
    public class TownWardParam : IEntity
    {
        public int? TownWardPrkID { get; set; }
        public string? TownWardID { get; set; }
        public string? DistrictID { get; set; }
    }
}
