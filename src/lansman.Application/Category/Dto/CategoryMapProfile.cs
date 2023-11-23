using AutoMapper;

namespace lansman.Category.Dto
{
    public class CategoryMapProfile : Profile
    {
        public CategoryMapProfile()
        {
            CreateMap<CreateCategoryDto, Category>()
            .ReverseMap();

            CreateMap<Category, GetCategoryDto>();
        }
    }
}
