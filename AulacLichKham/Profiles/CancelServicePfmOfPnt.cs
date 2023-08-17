using AulacLichKham.DTO.FuncExam;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class CancelServicePfmOfPnt : Profile
    {
        public CancelServicePfmOfPnt()
        {
            CreateMap<CancelServicePfmOfPnt, ServicePfmOfPntDTO>();
        }
    }
}
