using ApplicationServices.Models;

using AutoMapper;

using Models;

using System;

namespace ApplicationServices.Mapping.Profiles
{
    internal sealed class InnerEntityTypeProfile : Profile
    {
        public InnerEntityTypeProfile()
        {
            CreateMap<InnerEntityType, InnerEntityDtoType>()
                .ConvertUsing(Convert);
        }

        private static InnerEntityDtoType Convert(InnerEntityType innerEntityType, InnerEntityDtoType innerEntityDtoType)
        {
            return innerEntityType switch
            {
                InnerEntityType.Type1 => InnerEntityDtoType.Type1,
                InnerEntityType.Type2 => InnerEntityDtoType.Type2,
                _ => throw new ArgumentOutOfRangeException(nameof(innerEntityType)),
            };
        }
    }
}
