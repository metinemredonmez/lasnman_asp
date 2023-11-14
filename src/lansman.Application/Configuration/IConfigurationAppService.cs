using System.Threading.Tasks;
using lansman.Configuration.Dto;

namespace lansman.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
