using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;

namespace lansman.Product.Dto
{
    [AutoMapTo(typeof(Product))]
    public class CreateProductDto : EntityDto
    {
        public CreateProductDto()
        {
            ProductImagesDto = new List<CreateProductImageDto>();
        }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsDiscount { get; set; }
        public List<CreateProductImageDto> ProductImagesDto { get; set; }
    }
}
