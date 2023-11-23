using Abp.Application.Services;
using lansman.Product.Dto;
using Abp.Domain.Repositories;
using lansman.Category.Dto;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace lansman.Category
{
    public class CategoryAppService : AsyncCrudAppService<Category, CreateCategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }

        public async Task<GetCategoryDto> GetByIdWithProducts(EntityDto<int> input)
        {
            CheckGetPermission();

            var entity = await Repository
                                .GetAll()
                                .Include(r => r.Products)
                                .ThenInclude(x => x.ProductImages)
                                .AsQueryable()
                                .FirstOrDefaultAsync(p => p.Id == input.Id);

            return ObjectMapper.Map<GetCategoryDto>(entity);
        }
    }
}
