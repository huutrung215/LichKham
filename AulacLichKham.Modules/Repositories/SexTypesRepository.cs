using Aulac.Service.Rsc.Tags;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class SexTypesRepository : BaseRepository<SexTypes>, ISexTypesRepository
    {
        public SexTypesRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetListSexTypes")
        {
        }
    }
}
