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
    public class HospitalExamScheduleRepository : BaseRepository<HospitalExamSchedule>,IHospitalExamScheduleRepository
    {
        public HospitalExamScheduleRepository(IDbConnection dbConnection) : base(dbConnection) 
        {
        }
        public IEnumerable<HospitalExamSchedule> Gets_HospitalExamSchedule()
        {
            var param = ParamHelper.GetParamOnlyTable(null);
            return _dbConnection.Query<HospitalExamSchedule>(StoredProcedure.HspExamSchedule.SP_GetHospitalExamSchedule,param,commandType:CommandType.StoredProcedure);
        }
        public LoginESResponse Login_ES(LoginESRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            try
            {
                return _dbConnection.QueryFirst<LoginESResponse>(StoredProcedure.HspExamSchedule.SP_LoginExamSchedule,param,commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Register_ES(RegisterESRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            if (_dbConnection.Execute(StoredProcedure.HspExamSchedule.SP_RegisterExamSchedule, param, commandType: CommandType.StoredProcedure) == 1) return true;
            return false;
        }
    }
}
