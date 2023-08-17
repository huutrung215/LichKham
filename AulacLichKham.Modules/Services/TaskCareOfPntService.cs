using AulacLichKham.Modules.Entities;
using AulacLichKham.Modules.Interfaces.Repositories;
using AulacLichKham.Modules.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Services
{
    public class TaskCareOfPntService : BaseService<TaskCareOfPnt>, ITaskCareOfPntService
    {
        private readonly ITaskCareOfPntRepository _repo;
        public TaskCareOfPntService(ITaskCareOfPntRepository repo) : base(repo)
        {
            _repo = repo;
        }
        public IEnumerable<TaskCareOfPnt> Gets_ListTaskCareTreamentOfPnt(TaskCareOfPntRequest request)
        {
            return _repo.Gets_ListTaskCareTreamentOfPnt(request);
        }
        public TaskCareOfPnt Get_InfoTaskCareTreamentOfPnt(InfoTaskCareTreamentOfPntRequest request)
        {
            return _repo.Get_InfoTaskCareTreamentOfPnt(request);
        }
        public bool Set_TaskCareTreamentOfPnt(SetTaskCareOfPntRequest request)
        {
            return _repo.Set_TaskCareTreamentOfPnt(request);
        }
        public bool Delete_TaskCareTreamentOfPnt(InfoTaskCareTreamentOfPntRequest request)
        {
            return _repo.Delete_TaskCareTreamentOfPnt(request);
        }
        public IEnumerable<VchPttPnt> Gets_InfoVchPttPnt(TaskCareOfPntRequest request)
        {
            return _repo.Gets_InfoVchPttPnt(request);
        }
        public IEnumerable<MdnItems> Gets_MdnItems(MdnItemsRequest request)
        {
            return _repo.Gets_MdnItems(request);
        }
        public IEnumerable<ItemsSubType> Gets_ItemsSubType()
        {
            return _repo.Gets_ItemsSubType();
        }
        public IEnumerable<DeptPfmCls> Gets_DeptPfmCls()
        {
            return _repo.Gets_DeptPfmCls();
        }
    }
}
