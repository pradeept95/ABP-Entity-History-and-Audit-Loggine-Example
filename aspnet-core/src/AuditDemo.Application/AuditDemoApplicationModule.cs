using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuditDemo.Authorization;

namespace AuditDemo
{
    [DependsOn(
        typeof(AuditDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AuditDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AuditDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AuditDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
