using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using lansman.EntityFrameworkCore;
using lansman.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace lansman.Web.Tests
{
    [DependsOn(
        typeof(lansmanWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class lansmanWebTestModule : AbpModule
    {
        public lansmanWebTestModule(lansmanEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(lansmanWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(lansmanWebMvcModule).Assembly);
        }
    }
}