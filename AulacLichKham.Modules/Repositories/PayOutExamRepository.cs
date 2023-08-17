using Aulac.Service.Rsc.Tags;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class PayOutExamRepository : BaseRepository<PayOutExam>, IPayOutExamRepository
    {
        public PayOutExamRepository(IDbConnection dbConnection) : base(dbConnection) 
        {       
        }
        public IEnumerable<PayOutExam> Gets_DetailPayOutExamService(PayOutExamRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<PayOutExam>(StoredProcedure.PayOutExam.SP_GetDetailExpExamOfPnt, param, commandType: CommandType.StoredProcedure);
        }
    }
}
