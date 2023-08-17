using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class PntPfmService :IEntity
    {
        [PrimaryKey]
        public string? CardCode { get; set; }
        public string? PntName { get; set; }
        public string? PntBirthDay { get; set; }
        public string? StatusName { get; set; }
        public int? StatusID { get; set; }
    }

    public class PntPfmServiceParam : IEntity
    {
        public string? ID { get; set; }
        public string? DeptPfmID { get; set; }
        public string? Filter { get; set; }
        public int? StatusID { get; set; }
    }
}
