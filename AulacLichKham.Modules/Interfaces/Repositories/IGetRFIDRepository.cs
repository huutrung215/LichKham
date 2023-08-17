using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface IGetRFIDRepository : IBaseRepository<GetRFID>
    {
    }

    public interface IGetRFID2Repository : IBaseRepository<GetRFID2>
    {
        //public bool? Execute_GetRFID2(GetRFID2 entity, string[] result, ref string name);

        public RFID2Response? Execute1(GetRFID2 entity);
    }
}
