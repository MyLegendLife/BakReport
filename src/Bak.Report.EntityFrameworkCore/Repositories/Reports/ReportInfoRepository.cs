using System.Collections.Generic;
using System.Linq;
using Bak.Report.Domain.Reports;
using Bak.Report.Domain.Reports.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Reports
{
    public class ReportInfoRepository : EfCoreRepository<ReportDbContext, ReportInfo, int>, IReportInfoRepository
    {
        public ReportInfoRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ReportInfo> GetAsync(int id)
        {
            return await DbContext.Set<ReportInfo>().Include(x => x.Images).FirstOrDefaultAsync(x => x.Id == id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ReportInfo>> GetListAsync(int categoryId = -1)
        {
            if (categoryId == -1)
            {
                return await DbContext.Set<ReportInfo>().Include(x => x.Category).ToListAsync();
            }
            else
            {
                return await DbContext.Set<ReportInfo>().Include(x => x.Category).Where(x => x.CategoryId == categoryId).ToListAsync();
            }
        }
    }
}