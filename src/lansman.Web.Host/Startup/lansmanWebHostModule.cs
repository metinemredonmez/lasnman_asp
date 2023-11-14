using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using lansman.Configuration;

namespace lansman.Web.Host.Startup
{
    [DependsOn(
       typeof(lansmanWebCoreModule))]
    public class lansmanWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public lansmanWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(lansmanWebHostModule).GetAssembly());
        }
    }
}
