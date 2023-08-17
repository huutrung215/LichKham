using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class TestCard : IEntity
    {
        [PrimaryKey]
        public string? DeviceID { get; set; }
        public string? ID { get; set; }
        public DateTime? DateInsert { get; set; }
    }
}
