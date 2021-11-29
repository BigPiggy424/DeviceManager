using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using DeviceManagement.Authorization;
using DeviceManagement.DeviceManager.Dto;
using DeviceManagement.Devices;

namespace DeviceManagement.DeviceManager
{
    //[AbpAuthorize(PermissionNames.Pages_Devices)]
    public class DeviceManager : AsyncCrudAppService<Device, DeviceDto, int, PagedDeviceResultRequestDto, CreateDeviceDto, DeviceDto>, IDeviceManager
    {
        public DeviceManager(IRepository<Device, int> repository) : base(repository)
        {
        }
    }
}
