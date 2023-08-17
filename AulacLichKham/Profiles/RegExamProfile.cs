using AulacLichKham.DTO.RegExamFrombDoctor;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class RegExamProfile : Profile
    {
        public RegExamProfile()
        {
            CreateMap<RegExam, RegExamFrombDoctorDTO>();

            CreateMap<RegExamResponse, RegExamResponseDTO>();
        }
    }

    public class DoctorExamInDayProfile : Profile
    {

        public DoctorExamInDayProfile()
        {
            CreateMap<DoctorExamInDay, DoctorExamResponse>();
        }
    }

    public class ExamFrombDoctorProfile : Profile
    {

        public ExamFrombDoctorProfile()
        {
            CreateMap<ExamFrombDoctor, DoctorExamResponse>();
        }
    }

    public class QuantityPntInDayProfile : Profile
    {

        public QuantityPntInDayProfile()
        {
            CreateMap<QuantityPntInDay, QuantityPntInDayResponse>();
        }
    }
}
