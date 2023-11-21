using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using lansman.Product.Dto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace lansman.Product
{
    public class ProductAppService : AsyncCrudAppService<Product, CreateProductDto>, IProductAppService
    {
        public ProductAppService(IRepository<Product, int> repository) : base(repository)
        {
        }

        public override Task<PagedResultDto<CreateProductDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            CheckGetAllPermission();

            var list = new List<Product>();
            var query = Repository.GetAllIncluding(x => x.ProductImages);

            query = ApplySorting(query, input);

            list = query.Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToList();

            var result = new PagedResultDto<CreateProductDto>(query.Count(), ObjectMapper.Map<List<CreateProductDto>>(list));
            return Task.FromResult(result);
        }
    }
}
