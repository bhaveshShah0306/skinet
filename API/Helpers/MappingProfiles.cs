using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(dest => dest.Brand, src => src.MapFrom(copyFrom => copyFrom.Brand.Name))
            .ForMember(dest => dest.ProductType, src => src.MapFrom(copyFrom => copyFrom.ProductType.Name))
            .ForMember(dest => dest.PictureUrl, src => src.MapFrom<ProductUrlResolver>());
        }
    }
}