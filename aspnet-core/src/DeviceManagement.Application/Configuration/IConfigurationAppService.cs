using System.Threading.Tasks;
using DeviceManagement.Configuration.Dto;

namespace DeviceManagement.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
