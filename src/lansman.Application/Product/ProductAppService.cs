using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
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
        public async Task<PagedResultDto<GetAllProductWithImageDto>> GetAllWithImagesAsync(PagedAndSortedResultRequestDto input)
        {
            CheckGetAllPermission();

            var list = new List<Product>();
            var query = Repository.GetAllIncluding(x => x.ProductImages);

            query = ApplySorting(query, input);

            list = await query.Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToListAsync();

            var result = new PagedResultDto<GetAllProductWithImageDto>(query.Count(), ObjectMapper.Map<List<GetAllProductWithImageDto>>(list));

            return Task.FromResult(result).Result;
        }

        public async Task<PagedResultDto<GetAllProductWithImagesAndCommentDto>> GetAllWithImagesAndCommentsAsync(PagedAndSortedResultRequestDto input)
        {
            CheckGetAllPermission();

            var list = new List<Product>();
            var query = Repository
                                .GetAll()
                                .Include(r => r.ProductImages)
                                .Include(i => i.Comments)
                                .ThenInclude(x => x.CommentImages)
                                .AsQueryable();

            query = ApplySorting(query, input);

            list = await query.Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToListAsync();

            var result = new PagedResultDto<GetAllProductWithImagesAndCommentDto>(query.Count(), ObjectMapper.Map<List<GetAllProductWithImagesAndCommentDto>>(list));

            return Task.FromResult(result).Result;
        }

        public async Task<GetAllProductWithImagesAndCommentDto> GetByIdWithImagesAndCommentsAsync(EntityDto<int> input)
        {
            CheckGetPermission();

            var entity = await Repository
                                .GetAll()
                                .Include(r => r.ProductImages)
                                .Include(i => i.Comments)
                                .ThenInclude(x => x.CommentImages)
                                .AsQueryable()
                                .FirstOrDefaultAsync(p => p.Id == input.Id);

            return ObjectMapper.Map<GetAllProductWithImagesAndCommentDto>(entity);
        }
    }
}
