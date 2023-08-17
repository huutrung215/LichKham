using AulacLichKham.DTO.SexTypes;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class SexTypesProfile : Profile
    {
        public SexTypesProfile()
        {
            CreateMap<SexTypes, SexTypesDTO>();
        }
    }
}
