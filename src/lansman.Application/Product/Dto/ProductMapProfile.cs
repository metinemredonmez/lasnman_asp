﻿using AutoMapper;
using System.Collections.Generic;

namespace lansman.Product.Dto
{
    public class CategoryMapProfile : Profile
    {
        public CategoryMapProfile()
        {

            CreateMap<CreateProductDto, Product>()
            .ForMember(dest => dest.ProductImages, opt => opt.MapFrom(src => src.ProductImagesDto))
            .ReverseMap();

            CreateMap<Product, CreateProductDto>()
            .ForMember(dest => dest.ProductImagesDto, opt => opt.MapFrom(src => src.ProductImages))
            .ReverseMap();

            CreateMap<CreateProductImageDto, ProductImage>()
                .ReverseMap();
        }
    }
}
