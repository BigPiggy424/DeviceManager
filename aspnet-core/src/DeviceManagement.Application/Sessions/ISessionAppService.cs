using System.Threading.Tasks;
using Abp.Application.Services;
using DeviceManagement.Sessions.Dto;

namespace DeviceManagement.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
