using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using Aulac.Service.Rsc.Tags;
using AulacLichKham.Modules.Utils;
using Dapper;
using Aulac.Service.Global;

namespace AulacLichKham.Modules.Repositories
{
    public class RegExamRepository : BaseRepository<RegExam>, IRegExamRepository
    {
        public RegExamRepository(IDbConnection dbConnection) : base(dbConnection, "SP_RegExamFrombDoctor")
        {
        }

        public virtual RegExamResponse? ExecuteRegExam(RegExam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);

            param.Add(tagRegExam.Data, direction: ParameterDirection.Output, size: 100);
            param.Add(tagRegExam.StatusCode, direction: ParameterDirection.Output, size: 3);

            _dbConnection.Execute(StoredProcedure.RegExam.SP_RegExamFrombDoctor, param, commandType: CommandType.StoredProcedure);

            string? data = param.Get<string>(tagRegExam.Data);
            string? statusCode = param.Get<string>(tagRegExam.StatusCode);

            return new RegExamResponse() { Data = data, StatusCode = statusCode };
        }
    }

    public class CacelExamFrombDoctorRepository : BaseRepository<ExamFrombDoctor>, ICacelExamFrombDoctorRepository
    {
        public CacelExamFrombDoctorRepository(IDbConnection dbConnection) : base(dbConnection, "SP_CancelExamFrombDoctor")
        {
        }

        public string? CancelExamFrombDoctor(ExamFrombDoctor entity)
        {
            return base.Execute(entity);
        }
    }

    public class GetStatusExamOfPntbDoctorRepository : BaseRepository<ExamFrombDoctor>, IGetStatusExamOfPntbDoctorRepository
    {
        public GetStatusExamOfPntbDoctorRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetStatusExamOfPntbDoctor")
        {
        }

        public string? GetStatusExamOfPntbDoctor(ExamFrombDoctor entity)
        {
            return base.Execute(entity);
        }
    }
}
