using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AuditDemo.Authorization.Roles;
using AuditDemo.Authorization.Users;
using AuditDemo.MultiTenancy;
using AuditDemo.Migrations;
using AuditDemo.Models;

namespace AuditDemo.EntityFrameworkCore
{
    public class AuditDemoDbContext : AbpZeroDbContext<Tenant, Role, User, AuditDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<AuditTestModel> AuditTestModel { get; set; }
        public AuditDemoDbContext(DbContextOptions<AuditDemoDbContext> options)
            : base(options)
        {
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
