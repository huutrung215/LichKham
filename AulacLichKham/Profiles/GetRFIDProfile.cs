using AulacLichKham.DTO.GetRFID;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class GetRFIDProfile : Profile
    {
        public GetRFIDProfile()
        {
            CreateMap<GetRFID, GetRFIDPDTO>();
        }
    }

    public class GetRFID2Profile : Profile
    {
        public GetRFID2Profile()
        {
            CreateMap<GetRFID2, GetRFIDPDTO>();
        }
    }
}
