using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.DbMigrations.EntityFrameworkCore
{
    public class ReportMigrationsDbContext : AbpDbContext<ReportMigrationsDbContext>
    {
        public ReportMigrationsDbContext(DbContextOptions<ReportMigrationsDbContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureReport();
        }
    }
}