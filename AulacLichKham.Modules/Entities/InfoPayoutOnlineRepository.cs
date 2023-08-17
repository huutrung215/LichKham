using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class InfoPayoutOnline : IEntity
    {
        [PrimaryKey]
        public string? PntName { get; set; }
        public string? PntBirthday { get; set; }
        public string? InsNum { get; set; }
        public string? AmtTltToPay { get; set; }
        public string? DateExam { get; set; }
        public string? PntPhoneDateEndExam { get; set; }
    }

    public class InfoPayoutOnlineParam : IEntity
    {
        [PrimaryKey]
        public string? Phone { get; set; }
    }
}
