using Aulac.Service.Global;
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
    public class GetQuantityPntInDayRepsitory : BaseRepository<QuantityPntInDay>, IGetQuantityPntInDayReopsitory
    {
        public GetQuantityPntInDayRepsitory(IDbConnection dbConnection) : base(dbConnection, "SP_GetQuantityPntInDay")
        {
        }

        public virtual IEnumerable<QuantityPntInDay> Gets_QuantityPntInDay(RegExamParam entity)
        {
            var param = ParamHelper.GetParamOnlyTable(entity);
            return _dbConnection.Query<QuantityPntInDay>(StoredProcedure.RegExam.SP_GetQuantityPntInDay, param, commandType: CommandType.StoredProcedure);
        }

        //public virtual string? Gets_QuantityPntInDay(RegExamParam entity, ref DataTable tb)
        //{
        //    try
        //    {
        //        var param = ParamHelper.GetParamOnlyTable(entity);

        //        _dbConnection.Open();
        //        var result = _dbConnection.Query<QuantityPntInDay>(StoredProcedure.RegExam.SP_GetQuantityPntInDay, param, commandType: CommandType.StoredProcedure);

        //        if (result == null)
        //        {
        //            _dbConnection.Close();
        //            return ErrorCodeMsg.R500;
        //        }
        //        else
        //        {
        //            tb.Columns.Add(tagOrderExam.QuantityPntInDay.DateTimeReg);
        //            tb.Columns.Add(tagOrderExam.QuantityPntInDay.TimeRegExam);
        //            tb.Columns.Add(tagOrderExam.QuantityPntInDay.Quantity);
        //            tb.Columns.Add(tagOrderExam.QuantityPntInDay.QuantityMax);

        //            foreach (var item in result)
        //            {
        //                DataRow row = tb.NewRow();
        //                row[tagOrderExam.QuantityPntInDay.DateTimeReg] = item.DateTimeReg.ToString();
        //                row[tagOrderExam.QuantityPntInDay.TimeRegExam] = item.TimeRegExam.ToString();
        //                row[tagOrderExam.QuantityPntInDay.Quantity] = item.Quantity.ToString();
        //                row[tagOrderExam.QuantityPntInDay.QuantityMax] = item.QuantityMax.ToString();
        //                tb.Rows.Add(row);
        //            }
        //            _dbConnection.Close();
        //            return ErrorCodeMsg.R000;
        //        }
        //    } 
        //    catch (Exception ex)
        //    {
        //        return ErrorCodeMsg.R500;
        //    }

        //}
    }
}
