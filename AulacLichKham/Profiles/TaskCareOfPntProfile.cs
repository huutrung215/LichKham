using AulacLichKham.DTO.TaskCareOfPnt;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class TaskCareOfPntProfile : Profile
    {
        public TaskCareOfPntProfile()
        {
            CreateMap<TaskCareOfPnt, TaskCareOfPntDTO>();
            CreateMap<VchPttPnt, VchPttPntDTO>();
            CreateMap<MdnItems, MdnItemsDTO>();
            CreateMap<ItemsSubType, ItemsSubTypeDTO>();
            CreateMap<DeptPfmCls, DeptPfmClsDTO>();
        }
    }
}
