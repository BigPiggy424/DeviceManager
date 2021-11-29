using Abp.Application.Services;
using DeviceManagement.DeviceManager.Dto;

namespace DeviceManagement.DeviceManager
{
    public interface IDeviceManager : IAsyncCrudAppService<DeviceDto, int, PagedDeviceResultRequestDto, CreateDeviceDto, DeviceDto>
    {
    }
}
