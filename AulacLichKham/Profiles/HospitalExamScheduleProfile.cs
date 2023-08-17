using AulacLichKham.DTO.HospitalExamSchedule;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class HospitalExamScheduleProfile : Profile
    {
        public HospitalExamScheduleProfile() 
        {
            CreateMap<HospitalExamSchedule, HospitalExamScheduleDTO>();
            CreateMap<LoginESResponse, LoginESResponseDTO>();
        }
    }
}
