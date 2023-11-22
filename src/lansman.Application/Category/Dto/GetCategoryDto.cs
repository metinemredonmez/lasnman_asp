using Abp.Application.Services.Dto;
using lansman.Product.Dto;
using System.Collections.Generic;

namespace lansman.Category.Dto
{
    public class GetCategoryDto : EntityDto
    {
        public GetCategoryDto()
        {
            Products = new List<GetProductDto>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImageUrl { get; set; }
        public List<GetProductDto> Products { get; set; }

    }
}
