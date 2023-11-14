using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using lansman.Authorization;

namespace lansman
{
    [DependsOn(
        typeof(lansmanCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class lansmanApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<lansmanAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(lansmanApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
