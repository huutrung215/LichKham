using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class DoctorPfm : IEntity
    {
        [PrimaryKey]
        public string? DoctorPrkID { get; set; }
        public string? DoctorID { get; set; }
        public string? DoctorName { get; set; }
    }
    public class DoctorPfmRequest : IEntity
    {
        [PrimaryKey]
        public string? ID { get; set;}
    }
}
