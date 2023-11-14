using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using lansman.Configuration.Dto;

namespace lansman.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : lansmanAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
