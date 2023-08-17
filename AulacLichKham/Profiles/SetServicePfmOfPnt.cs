using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class SetServicePfmOfPnt : Profile
    {
        public SetServicePfmOfPnt() 
        {
            CreateMap<SetServicePfmOfPnt, ServicePfmOfPntDTO>();
        }
    }
}
