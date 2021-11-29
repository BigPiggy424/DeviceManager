using System.Threading.Tasks;
using Abp.Application.Services;
using DeviceManagement.Authorization.Accounts.Dto;

namespace DeviceManagement.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
