using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class InsCardFastMachine : IEntity
    {
        [PrimaryKey]
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public string? pBirthday { get; set; }
        public string? pInsuranceNumber { get; set; }
        public string? pHspInsID { get; set; }
        public string? pDate { get; set; }
        public string? pTime { get; set; }
        public string? history { get; set; }
    }


}
