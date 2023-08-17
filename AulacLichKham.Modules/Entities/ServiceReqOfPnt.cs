using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class ServiceReqOfPnt : IEntity
    {
        [PrimaryKey]
        public string? DoctorID { get; set; }
        public string? ServiceID { get; set; }
        public string? PersonID { get; set; }
    }

    public class ServiceReqOfPntParam : IEntity
    {
        [PrimaryKey]
        public string? DoctorID { get; set; }
        public string? ServiceID { get; set; }
        public string? PersonID { get; set; }
        public string? StatusCode { get; set; }

    }
}
