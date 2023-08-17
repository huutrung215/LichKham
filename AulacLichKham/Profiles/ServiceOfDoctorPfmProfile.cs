using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO.Province;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class ServiceOfDoctorPfmProfile : Profile
    {
        public ServiceOfDoctorPfmProfile()
        {
            CreateMap<ServiceOfDoctorPfm, ServiceOfDoctorPfmDTO>();
        }
    }
}
