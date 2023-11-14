using System.Threading.Tasks;
using Abp.Application.Services;
using lansman.Sessions.Dto;

namespace lansman.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
