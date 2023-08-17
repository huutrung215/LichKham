using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class FuncExamProfile : Profile
    {
        public FuncExamProfile()
        {
            CreateMap<FuncExam, FuncExamDTO>();
        }
    }
}
