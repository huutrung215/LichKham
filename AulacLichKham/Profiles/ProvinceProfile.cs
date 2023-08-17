using AulacLichKham.DTO.FuncExam;
using AulacLichKham.DTO.Province;
using AulacLichKham.Modules.Entities;
using AutoMapper;

namespace AulacLichKham.Profiles
{
    public class ProvinceProfile:Profile
    {
        public ProvinceProfile()
        {
            CreateMap<Province, ProvinceDTO>();
        }
    }
}
