using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class SexTypes : IEntity
    {
        [PrimaryKey]
        public int? SexID { get; set; }
        public string? SexName { get; set; }
    }
}
