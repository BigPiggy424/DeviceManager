using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace DeviceManagement.Devices
{
    [Table("Devices")]
    public class Device : Entity, IHasCreationTime
    {
        public const int MaxNameLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; }

        public int Value { get; set; }

        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public DeviceState State { get; set; }


        public Device()
        {
            CreationTime = Clock.Now;
            State = DeviceState.Enable;
        }

        public Device(string name, int value, string description = null)
            : this()
        {
            Name = name;
            Value = value;
            Description = description;
        }
    }

    public enum DeviceState : byte
    {
        Enable = 0,
        Unable = 1
    }
}