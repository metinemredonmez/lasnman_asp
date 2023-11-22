using Abp.Application.Services;
using Abp.Application.Services.Dto;
using lansman.Product.Dto;
using System.Threading.Tasks;

namespace lansman.Product
{
    public interface IProductAppService : IApplicationService
    {
        Task<PagedResultDto<GetAllProductWithImageDto>> GetAllWithImagesAsync(PagedAndSortedResultRequestDto input);
        Task<PagedResultDto<GetAllProductWithImagesAndCommentDto>> GetAllWithImagesAndCommentsAsync(PagedAndSortedResultRequestDto input);
        Task<GetAllProductWithImagesAndCommentDto> GetByIdWithImagesAndCommentsAsync(EntityDto<int> input);
    }
}
