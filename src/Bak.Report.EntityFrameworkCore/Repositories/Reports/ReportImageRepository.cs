using Bak.Report.Domain.Reports;
using Bak.Report.Domain.Reports.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Reports
{
    public class ReportImageRepository : EfCoreRepository<ReportDbContext, ReportImage, int>, IReportImageRepository
    {
        public ReportImageRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="images"></param>
        /// <returns></returns>
        public async Task BulkInsertAsync(IEnumerable<ReportImage> images)
        {
            await DbContext.Set<ReportImage>().AddRangeAsync(images);
            await DbContext.SaveChangesAsync();
        }
    }
}