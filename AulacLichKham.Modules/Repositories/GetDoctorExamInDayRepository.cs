using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using AulacLichKham.Modules.Interfaces.Repositories;
using Aulac.Service.Rsc.Tags;
using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Utils;
using Aulac.Service.Global;

namespace AulacLichKham.Modules.Repositories
{
    public class GetDoctorExamInDayRepository : BaseRepository<DoctorExamInDay>, IGetDoctorExamInDayRepository
    {
        private readonly IDbConnection _dbConnection;
        public GetDoctorExamInDayRepository(IDbConnection dbConnection) : base(dbConnection, "SP_GetDoctorExamInDay")
        {
        }
        public virtual IEnumerable<DoctorExamInDay> Gets_DoctorExamInDay(RegExamParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<DoctorExamInDay>(StoredProcedure.RegExam.SP_GetDoctorExamInDay, param, commandType: CommandType.StoredProcedure);
        }

        //public virtual string? Gets_DoctorExamInDay(RegExamParam entity, ref DataTable tb)
        //{
        //    var param = ParamHelper.GetParamOnlyTable(entity);

        //    var result = _dbConnection.Query<DoctorExamInDay>(StoredProcedure.RegExam.SP_GetDoctorExamInDay, param, commandType: CommandType.StoredProcedure);
        //    if (result == null)
        //    {
        //        _dbConnection.Close();
        //        return ErrorCodeMsg.R500;
        //    }
        //    else
        //    {
        //        tb.Columns.Add(tagOrderExam.DoctorExamInDay.DateRegExam);
        //        tb.Columns.Add(tagOrderExam.DoctorExamInDay.DoctorID);
        //        tb.Columns.Add(tagOrderExam.DoctorExamInDay.DoctorName);
        //        foreach (var item in result)
        //        {
        //            DataRow row = tb.NewRow();
        //            row[tagOrderExam.DoctorExamInDay.DateRegExam] = item.DateRegExam.ToString();
        //            row[tagOrderExam.DoctorExamInDay.DoctorID] = item.DoctorID;
        //            row[tagOrderExam.DoctorExamInDay.DoctorName] = item.DoctorName;
        //            tb.Rows.Add(row);
        //        }
        //        _dbConnection.Close();
        //        return ErrorCodeMsg.R000;
        //    }
        //}
    }
}
