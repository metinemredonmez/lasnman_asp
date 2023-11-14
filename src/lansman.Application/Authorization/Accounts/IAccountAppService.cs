using System.Threading.Tasks;
using Abp.Application.Services;
using lansman.Authorization.Accounts.Dto;

namespace lansman.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
