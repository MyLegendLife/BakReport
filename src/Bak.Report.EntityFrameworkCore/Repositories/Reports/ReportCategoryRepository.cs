using Bak.Report.Domain.Reports;
using Bak.Report.Domain.Reports.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Reports
{
    public class ReportCategoryRepository : EfCoreRepository<ReportDbContext, ReportCategory, int>, IReportCategoryRepository
    {
        public ReportCategoryRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}