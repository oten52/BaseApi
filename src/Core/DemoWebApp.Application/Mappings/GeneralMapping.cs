using AutoMapper;
using DemoWebApp.Application.Dtos;
using DemoWebApp.Domain.Entities;

namespace DemoWebApp.Application.Mappings
{
    public class GeneralMapping : Profile
    {

        public GeneralMapping()
        {
            CreateMap<t_AlertEvents, TestViewDto>().ReverseMap();

            // CreateMap<tTest, TestViewDto>()
            //.ForMember(dest => dest.AdSoyad, opt => opt.MapFrom(src => $"{src.Ad} {src.Soyad}"))
            //.ReverseMap()
            //.ForPath(dest => dest.Ad, opt => opt.MapFrom(src => GetFirstName(src.AdSoyad)))
            //.ForPath(dest => dest.Soyad, opt => opt.MapFrom(src => GetLastName(src.AdSoyad)));
        }
    }
}
