using ApplicationServices.Models;

using AutoMapper;

using Models;

namespace ApplicationServices.Mapping.Profiles
{
    internal sealed class InnerEntityDbProfile : Profile
    {
        public InnerEntityDbProfile()
        {
            CreateMap<InnerEntityDb, InnerEntityDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.InnerEntityType, opt => opt.MapFrom(src => src.InnerEntityType));
        }
    }
}
