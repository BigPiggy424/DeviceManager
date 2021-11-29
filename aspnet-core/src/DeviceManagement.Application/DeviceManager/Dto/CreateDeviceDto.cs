using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using DeviceManagement.Devices;

namespace DeviceManagement.DeviceManager.Dto
{
    [AutoMapTo(typeof(Device))]
    public class CreateDeviceDto : EntityDto, IHasCreationTime
    {
        [Required]
        [StringLength(Device.MaxNameLength)]
        public string Name { get; set; }

        public int Value { get; set; }

        [StringLength(Device.MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public DeviceState State { get; set; }
    }
}
