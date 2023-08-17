using AulacLichKham.DTO.Vch;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class VchOfElectronic : Profile
    {
        public VchOfElectronic()
        {
            CreateMap<VchOfElectronic, VchOfElectronicDTO>();
        }
    }
}
