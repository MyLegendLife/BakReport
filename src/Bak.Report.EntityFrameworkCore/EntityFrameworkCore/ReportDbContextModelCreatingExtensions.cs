using Bak.Report.Domain.Reports;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Bak.Report.EntityFrameworkCore.EntityFrameworkCore
{
    public static class ReportDbContextModelCreatingExtensions
    {
        public static void ConfigureReport(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<ReportInfo>(b =>
            {
                b.ToTable("T_ReportInfo");
                b.HasKey(x => x.Id);
                b.Property(x => x.Name).IsRequired().HasMaxLength(40);
                b.Property(x => x.Introduction).IsRequired().HasMaxLength(500);
                b.Property(x => x.Description).HasColumnType("text");
                b.HasMany(x => x.Images).WithOne(x => x.ReportInfo).HasForeignKey(x => x.ReportInfoId);
                b.HasOne(x => x.Category).WithMany(x=>x.ReportInfos).HasForeignKey(x=>x.CategoryId);
            });

            builder.Entity<ReportCategory>(b =>
            {
                b.ToTable("T_ReportCategory");
                b.HasKey(x => x.Id);
                b.Property(x => x.Name).IsRequired().HasMaxLength(40);
                b.HasMany(x => x.ReportInfos).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
            });

            builder.Entity<ReportImage>(b =>
            {
                b.ToTable("T_ReportImage");
                b.HasKey(x => x.Id);
                b.Property(x => x.Uri).IsRequired().HasMaxLength(200);
                //b.Property(x => x.ReportInfoId);
                b.HasOne(x => x.ReportInfo).WithMany(x => x.Images).HasForeignKey(x => x.ReportInfoId);
            });

            //builder.Entity<Factor>(b =>
            //{
            //    b.ToTable(ReportConsts.DbTablePrefix + "Factors");
            //    b.HasKey(x => x.Id);
            //});

            //builder.Entity<Authorizer>(b =>
            //{
            //    b.ToTable(ReportConsts.DbTablePrefix + "Authorizers");
            //    b.HasKey(x => x.Id);
            //});

            //builder.Entity<MiniProgramRecord>(b =>
            //{
            //    b.ToTable(ReportConsts.DbTablePrefix + "MiniProgramRecords");
            //    b.HasKey(x => x.Id);
            //});


            //builder.Entity<Merchan>(b =>
            //{
            //    b.ToTable(ReportConsts.DbTablePrefix + "SmallProgramMerchanInfo");
            //    b.HasKey(x => new { x.ThirdAppID, x.AppID });
            //});

            //builder.Entity<Order>(b =>
            //{
            //    b.ToTable(ReportConsts.DbTablePrefix + nameof(Order) + ReportConsts.DbTableSuffix);
            //    b.HasKey(x => x.Id);
            //    b.ConfigureByConvention(); 
            //    b.Property(x => x.UserNo).HasMaxLength(20).IsRequired();
            //    b.Property(x => x.OrderNo).IsRequired();
            //    b.Property(x => x.Type).IsRequired();
            //    b.Property(x => x.CreationTime).IsRequired();
            //});

            //builder.Entity<OrderLine>(b =>
            //{
            //    b.ToTable(ReportConsts.DbTablePrefix + nameof(OrderLine) + ReportConsts.DbTableSuffix);
            //    b.HasKey(x => new{x.OrderId, x.ProductNo});
            //    b.ConfigureByConvention();
            //    b.Property(x => x.ProductNo).HasMaxLength(200);
            //    b.Property(x => x.ProductName).HasMaxLength(200);
            //});
        }
    }
}