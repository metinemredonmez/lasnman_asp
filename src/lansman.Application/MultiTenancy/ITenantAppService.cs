using Abp.Application.Services;
using lansman.MultiTenancy.Dto;

namespace lansman.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

