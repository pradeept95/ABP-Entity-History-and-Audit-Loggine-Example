using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AuditDemo.Configuration;
using AuditDemo.Web;

namespace AuditDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AuditDemoDbContextFactory : IDesignTimeDbContextFactory<AuditDemoDbContext>
    {
        public AuditDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AuditDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AuditDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AuditDemoConsts.ConnectionStringName));

            return new AuditDemoDbContext(builder.Options);
        }
    }
}
