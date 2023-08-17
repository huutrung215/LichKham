using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class VchOfElectronic : IEntity
    {
        [PrimaryKey]
        public string? VchTypeID { get; set; }
        public string? VchName { get; set; }
    }

    public class VchOfElectronicParam : IEntity
    {
        [PrimaryKey]
        public string? ID { get; set; }
    }
}
