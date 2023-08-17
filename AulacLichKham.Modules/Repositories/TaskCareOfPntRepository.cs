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
    public class TaskCareOfPntRepository : BaseRepository<TaskCareOfPnt>, ITaskCareOfPntRepository
    {
        public TaskCareOfPntRepository(IDbConnection dbConnection) : base(dbConnection) 
        {
        }
        public IEnumerable<TaskCareOfPnt> Gets_ListTaskCareTreamentOfPnt(TaskCareOfPntRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<TaskCareOfPnt>(StoredProcedure.TaskCareOfPnt.SP_GetListTaskCareTreatmentOfPnt, param, commandType: CommandType.StoredProcedure);
        }
        public TaskCareOfPnt Get_InfoTaskCareTreamentOfPnt(InfoTaskCareTreamentOfPntRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.QueryFirstOrDefault<TaskCareOfPnt>(StoredProcedure.TaskCareOfPnt.SP_GetInfoTaskCareTreatmentOfPnt, param, commandType: CommandType.StoredProcedure);
        }
        public bool Set_TaskCareTreamentOfPnt(SetTaskCareOfPntRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            if (_dbConnection.Execute(StoredProcedure.TaskCareOfPnt.SP_SetTaskCareTreatmentOfPnt, param, commandType: CommandType.StoredProcedure) == 0)
            {
                return false;
            }
            return true;
        }
        public bool Delete_TaskCareTreamentOfPnt(InfoTaskCareTreamentOfPntRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            if (_dbConnection.Execute(StoredProcedure.TaskCareOfPnt.SP_DeleteTaskCareTreatmentOfPnt, param, commandType: CommandType.StoredProcedure) == 0)
            {
                return false;
            }
            return true;
        }
        public IEnumerable<VchPttPnt> Gets_InfoVchPttPnt(TaskCareOfPntRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<VchPttPnt>(StoredProcedure.TaskCareOfPnt.SP_GetListTaskCareTreatmentOfPnt, param, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<MdnItems> Gets_MdnItems(MdnItemsRequest request)
        {
            var param = ParamHelper.GetParamOnlyTable(request);
            return _dbConnection.Query<MdnItems>(StoredProcedure.MdnItems.SP_GetMdnItems, param, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<ItemsSubType> Gets_ItemsSubType()
        {
            return _dbConnection.Query<ItemsSubType>(StoredProcedure.ItemsSubType.SP_GetItemSubType, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<DeptPfmCls> Gets_DeptPfmCls()
        {
            return _dbConnection.Query<DeptPfmCls>(StoredProcedure.TaskCareOfPnt.SP_GetListDeptPfmCls, commandType: CommandType.StoredProcedure);
        }
    }
}
