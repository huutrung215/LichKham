using AulacLichKham.DTO.DoctorPfm;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class DoctorPfmProfile : Profile
    {
        public DoctorPfmProfile() 
        {
            CreateMap<DoctorPfm, DoctorPfmDTO>();
        }
    }
}
