using AulacLichKham.DTO.Province;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class DistrictProfile : Profile
    {
        public DistrictProfile()
        {
            CreateMap<District, DistrictDTO>();
        }
    }
}
