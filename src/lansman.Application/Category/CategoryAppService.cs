using Abp.Application.Services;
using lansman.Product.Dto;
using Abp.Domain.Repositories;
using lansman.Category.Dto;

namespace lansman.Category
{
    public class CategoryAppService : AsyncCrudAppService<Category, CreateCategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }
    }
}
