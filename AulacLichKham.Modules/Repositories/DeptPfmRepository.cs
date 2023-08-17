using Aulac.Service.Rsc.Tags;
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
    public class DeptPfmRepository : BaseRepository<DeptPfm>,IDeptPfmRepository
    {
        public DeptPfmRepository(IDbConnection dbConnection) : base(dbConnection, StoredProcedure.DeptPfm.SP_GetListDeptPfmService) 
        { 
        }
    }
}
