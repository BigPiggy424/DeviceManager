using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DeviceManagement.Configuration;

namespace DeviceManagement.Web.Host.Startup
{
    [DependsOn(
       typeof(DeviceManagementWebCoreModule))]
    public class DeviceManagementWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DeviceManagementWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DeviceManagementWebHostModule).GetAssembly());
        }
    }
}
