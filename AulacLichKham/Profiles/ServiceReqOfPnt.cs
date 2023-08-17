using AulacLichKham.DTO.FuncExam;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class ServiceReqOfPnt : Profile
    {
        public ServiceReqOfPnt()
        {
            CreateMap<ServiceReqOfPnt, ServiceReqOfPntDTO>();
        }
    }
}
