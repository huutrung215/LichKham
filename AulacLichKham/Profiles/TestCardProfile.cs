using AulacLichKham.DTO.RegExamFrombDoctor;
using AulacLichKham.DTO.TestCardDTO;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class TestCardProfile : Profile
    {
        public TestCardProfile()
        {
            CreateMap<TestCard, TestCardDTO>();
        }
    }
}
