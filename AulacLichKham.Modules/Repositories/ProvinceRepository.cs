using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class ProvinceRepository:BaseRepository<Province>, IProvinceRepository
    {
        public ProvinceRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetProvince")
        {
        }
    }
}
