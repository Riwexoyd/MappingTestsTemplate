using ApplicationServices.Models;

using AutoMapper;

using Models;

namespace ApplicationServices.Mapping.Profiles
{
    internal sealed class EntityDbProfile : Profile
    {
        public EntityDbProfile() 
        {
            CreateMap<EntityDb, EntityDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.InnerEntity, opt => opt.MapFrom(src => src.InnerEntity));
        }
    }
}
