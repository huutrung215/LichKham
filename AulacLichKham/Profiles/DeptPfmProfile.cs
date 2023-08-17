using AulacLichKham.DTO.DeptPfm;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class DeptPfmProfile : Profile
    {
        public DeptPfmProfile() 
        {
            CreateMap<DeptPfm, DeptPfmDTO>();
        }
    }
}
