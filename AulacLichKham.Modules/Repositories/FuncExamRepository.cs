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
    public class FuncExamRepository: BaseRepository<FuncExam>, IFuncExamRepository
    {
        public FuncExamRepository(IDbConnection dbConnection) : base(dbConnection, StoredProcedure.FuncExam.SP_GetListFuncExam)
        {
        }
    }
}
