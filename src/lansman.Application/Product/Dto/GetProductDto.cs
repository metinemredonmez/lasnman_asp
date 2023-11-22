using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace lansman.Product.Dto
{
    public class GetProductDto : EntityDto
    {
        public GetProductDto()
        {
            ProductImages = new List<CreateProductImageDto>();
        }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsDiscount { get; set; }
        public List<CreateProductImageDto> ProductImages { get; set; }
    }
}
