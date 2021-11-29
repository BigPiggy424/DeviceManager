using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DeviceManagement.EntityFrameworkCore
{
    public static class DeviceManagementDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DeviceManagementDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DeviceManagementDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
