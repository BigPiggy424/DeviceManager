using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DeviceManagement.Configuration.Dto;

namespace DeviceManagement.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DeviceManagementAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
