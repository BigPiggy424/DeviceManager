using Abp.Application.Services;
using DeviceManagement.MultiTenancy.Dto;

namespace DeviceManagement.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

