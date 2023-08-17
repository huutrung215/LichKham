using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Services
{
    public interface IGetRFIDService : IBaseService<GetRFID>
    {
    }
    public interface IGetRFID2Service : IBaseService<GetRFID2>
    {

        public RFID2Response? Execute1(GetRFID2 entity);
    }
}
