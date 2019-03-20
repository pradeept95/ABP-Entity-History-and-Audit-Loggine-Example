using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AuditDemo.EntityFrameworkCore
{
    public static class AuditDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AuditDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AuditDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
