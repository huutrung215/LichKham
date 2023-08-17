using AulacLichKham.Modules.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Interfaces.Repositories
{
    public interface ITaskCareOfPntRepository : IBaseRepository<TaskCareOfPnt>
    {
        public IEnumerable<TaskCareOfPnt> Gets_ListTaskCareTreamentOfPnt(TaskCareOfPntRequest request);
        public TaskCareOfPnt Get_InfoTaskCareTreamentOfPnt(InfoTaskCareTreamentOfPntRequest request);
        public bool Set_TaskCareTreamentOfPnt(SetTaskCareOfPntRequest request);
        public bool Delete_TaskCareTreamentOfPnt(InfoTaskCareTreamentOfPntRequest request);
        public IEnumerable<VchPttPnt> Gets_InfoVchPttPnt(TaskCareOfPntRequest request);
        public IEnumerable<MdnItems> Gets_MdnItems(MdnItemsRequest request);
        public IEnumerable<ItemsSubType> Gets_ItemsSubType();
        public IEnumerable<DeptPfmCls> Gets_DeptPfmCls();

    }
}
