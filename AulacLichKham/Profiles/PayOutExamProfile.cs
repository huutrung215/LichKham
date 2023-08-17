using AulacLichKham.DTO.PayOutExam;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class PayOutExamProfile : Profile
    {
        public PayOutExamProfile() 
        {
            CreateMap<PayOutExam, PayOutExamDTO>();
        }
    }
}
