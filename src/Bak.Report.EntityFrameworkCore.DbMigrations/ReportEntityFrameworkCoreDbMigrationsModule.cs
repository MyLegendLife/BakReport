using Bak.Report.EntityFrameworkCore.DbMigrations.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Bak.Report.EntityFrameworkCore.DbMigrations
{
    [DependsOn(
        typeof(ReportEntityFrameworkCoreModule)
        )]
    public class ReportEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ReportMigrationsDbContext>();
        }
    }
}
