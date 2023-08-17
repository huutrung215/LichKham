using AulacLichKham.DTO.Check;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class InsCardFastMachine : Profile
    {
        public InsCardFastMachine() 
        {
            CreateMap<InsCardFastMachine, InsCardFastMachineDTO>();        
        }
    }
}
