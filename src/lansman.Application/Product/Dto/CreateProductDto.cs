using Abp.Application.Services.Dto;
using Abp.AutoMapper;
namespace lansman.Product.Dto
{
    [AutoMap(typeof(Product))]
    public class CreateProductDto : EntityDto
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsDiscount { get; set; }
    }
}
