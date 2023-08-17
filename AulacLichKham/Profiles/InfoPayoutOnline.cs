using AulacLichKham.DTO.Info;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class InfoPayoutOnline : Profile
    {
        public InfoPayoutOnline()
        {
            CreateMap<InfoPayoutOnline, InfoPayoutOnlineDTO>();
        }
    }
}
