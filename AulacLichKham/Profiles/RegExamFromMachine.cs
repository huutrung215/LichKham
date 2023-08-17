using AulacLichKham.DTO.RegExam;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class RegExamFromMachine : Profile
    {
        public RegExamFromMachine()
        {
            CreateMap<RegExamFromMachine, RegExamFromMachineDTO>();
        }
    }
}
