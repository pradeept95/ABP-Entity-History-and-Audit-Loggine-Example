using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuditDemo.Configuration;

namespace AuditDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(AuditDemoWebCoreModule))]
    public class AuditDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AuditDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuditDemoWebHostModule).GetAssembly());
        }
    }
}
