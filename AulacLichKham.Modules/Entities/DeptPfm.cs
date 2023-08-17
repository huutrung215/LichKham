using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class DeptPfm:IEntity
    {
        [PrimaryKey]
        public string? DeptPrkID { get; set; }
        public string? DeptID { get; set; }
        public string? DeptName { get; set; }
        public int? SL { get; set; }
        
    }
}
