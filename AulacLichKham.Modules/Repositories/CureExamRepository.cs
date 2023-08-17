using Aulac.Service.Rsc.Tags;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class CureExamRepository : BaseRepository<CureExam>, ICureExamRepository
    {
        public CureExamRepository(IDbConnection dbConnection) : base(dbConnection)
        {
        }
        public IEnumerable<CureExam> Gets_PntCureOfBedNum(CureExamRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<CureExam>(StoredProcedure.CureExam.SP_GetListPntCureOfBedNum, param, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<BedNumOfDept> Gets_BedNumOfDept(BedNumOfDeptRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<BedNumOfDept>(StoredProcedure.CureExam.SP_GetListBedNumOfDept, param, commandType: CommandType.StoredProcedure);
        }
    }
}
