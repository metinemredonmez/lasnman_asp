using Abp.Application.Services;
using Abp.Application.Services.Dto;
using lansman.Category.Dto;
using System.Threading.Tasks;

namespace lansman.Category
{
    public interface ICategoryAppService : IApplicationService
    {
        Task<GetCategoryDto> GetByIdWithProducts(EntityDto<int> input);
    }
}
