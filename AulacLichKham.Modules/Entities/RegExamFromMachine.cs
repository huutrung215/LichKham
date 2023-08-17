using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class RegExamFromMachine : IEntity
    {

        [PrimaryKey]
        public string? FullName { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }
        public string? Birthday { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? InsuranceNumber { get; set; }
        public string? DateInsStart { get; set; }
        public string? DateInsEnd { get; set; }
        public string? MaKCBBD { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? TextArea { get; set; }
        public string? Serial { get; set; }
    }


}
