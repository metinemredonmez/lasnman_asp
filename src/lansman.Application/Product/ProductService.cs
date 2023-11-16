using Abp.Application.Services;
using Abp.Domain.Repositories;
using lansman.Product.Dto;

namespace lansman.Product
{
    public class ProductService : AsyncCrudAppService<Product, CreateProductDto>, IProductService
    {
        public ProductService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}
