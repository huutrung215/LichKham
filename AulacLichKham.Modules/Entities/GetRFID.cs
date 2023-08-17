using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class GetRFID : IEntity
    {
        [PrimaryKey]
        public string? StatusCode { get; set; }
        public string? DeviceID { get; set; }
        public string? ID { get; set; }
    }

    public class GetRFID2 : IEntity
    {
        [PrimaryKey]
        public string? StatusCode { get; set; }
        public string? Data { get; set; }
        public string? DeviceID { get; set; }
        public string? ID { get; set; }
    }

    public class RFID2Response : IEntity
    {
        public string? StatusCode { get; set; }
        public string? Data { get; set; }
    }
}
