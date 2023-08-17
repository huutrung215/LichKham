using AulacLichKham.DTO.FuncExam;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class InfoPntCureInDept : Profile
    {
        public InfoPntCureInDept()
        {
            CreateMap<InfoPntCureInDept, InfoPntCureInDeptDTO>();
        }
    }
}
