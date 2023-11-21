using AutoMapper;
using System.Collections.Generic;

namespace lansman.Product.Dto
{
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {

            CreateMap<CreateProductDto, Product>()
            .ForMember(dest => dest.ProductImages, opt => opt.MapFrom(src => src.ProductImages))
            .ReverseMap();

            CreateMap<Product, CreateProductDto>()
            .ForMember(dest => dest.ProductImages, opt => opt.MapFrom(src => src.ProductImages))
            .ReverseMap();

            CreateMap<CreateProductImageDto, ProductImage>()
                .ReverseMap();
        }
    }
}
