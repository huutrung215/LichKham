using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO.TownWard;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class TownWardProfile : Profile
    {
        public TownWardProfile()
        {
            CreateMap<TownWard, TownWardDTO>();
        }
    }
}
