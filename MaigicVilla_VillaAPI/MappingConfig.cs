using AutoMapper;
using MaigicVilla_VillaAPI.Models;
using MaigicVilla_VillaAPI.Models.Dto;

namespace MaigicVilla_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }

    }
}
