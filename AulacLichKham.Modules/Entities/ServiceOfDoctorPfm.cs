using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class ServiceOfDoctorPfm : IEntity
    {
        [PrimaryKey]
        public string? ItemID { get; set; }
        public string? ItemName { get; set; }
    }

    public class  ServiceOfDoctorPfmParam : IEntity
    {
        public string? ID { get; set; }
        public string? DeptID { get; set; }
    }
}
