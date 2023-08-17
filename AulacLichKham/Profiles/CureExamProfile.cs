using AulacLichKham.DTO.CureExam;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class CureExamProfile : Profile
    {
        public CureExamProfile() 
        {
            CreateMap<CureExam, CureExamDTO>();
            CreateMap<BedNumOfDept, BedNumOfDeptDTO>();
            //CreateMap<PntCureOfBedNumRequest, PntCureOfBedNumRequestDTO>();
        }
    }
}
