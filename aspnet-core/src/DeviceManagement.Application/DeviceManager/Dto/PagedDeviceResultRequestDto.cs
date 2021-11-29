using DeviceManagement.Devices;

namespace DeviceManagement.DeviceManager.Dto
{
    public class PagedDeviceResultRequestDto
    {
        public string Keyword { get; set; }

        public DeviceState? State { get; set; }
    }
}
