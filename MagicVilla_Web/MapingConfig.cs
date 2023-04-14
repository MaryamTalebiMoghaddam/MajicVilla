
using AutoMapper;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Models.DTO;

namespace MagicVilla_Web
{
    public class MapingConfig : Profile
    {
        public MapingConfig()
        {
                      
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();


            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
