using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DeviceManagement.Devices;

namespace DeviceManagement.DeviceManager.Dto
{
    [AutoMapFrom(typeof(Device))]
    public class DeviceDto : EntityDto
    {
        [Required]
        [StringLength(Device.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(Device.MaxDescriptionLength)]
        public string Description { get; set; }

        public DeviceState State { get; set; }
    }
}
