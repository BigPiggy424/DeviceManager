using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DeviceManagement.Authorization.Roles;
using DeviceManagement.Authorization.Users;
using DeviceManagement.MultiTenancy;
using DeviceManagement.Devices;

namespace DeviceManagement.EntityFrameworkCore
{
    public class DeviceManagementDbContext : AbpZeroDbContext<Tenant, Role, User, DeviceManagementDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Device> Devices { get; set; }
        public DeviceManagementDbContext(DbContextOptions<DeviceManagementDbContext> options)
            : base(options)
        {
        }
    }
}
