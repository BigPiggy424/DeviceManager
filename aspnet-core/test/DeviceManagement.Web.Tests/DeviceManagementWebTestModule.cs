using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DeviceManagement.EntityFrameworkCore;
using DeviceManagement.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DeviceManagement.Web.Tests
{
    [DependsOn(
        typeof(DeviceManagementWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DeviceManagementWebTestModule : AbpModule
    {
        public DeviceManagementWebTestModule(DeviceManagementEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DeviceManagementWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DeviceManagementWebMvcModule).Assembly);
        }
    }
}