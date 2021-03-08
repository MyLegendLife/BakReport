using Bak.Report.Domain.Auths;
using Bak.Report.Domain.Base;
using Bak.Report.Domain.MiniPrograms;
using Bak.Report.Domain.Reports;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class ReportDbContext : AbpDbContext<ReportDbContext>
    {
        public DbSet<ReportInfo> ReportInfo { get; set; }
        public DbSet<ReportCategory> ReportCategory { get; set; }
        public DbSet<ReportImage> ReportImage { get; set; }

        public ReportDbContext(DbContextOptions<ReportDbContext> options)
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
