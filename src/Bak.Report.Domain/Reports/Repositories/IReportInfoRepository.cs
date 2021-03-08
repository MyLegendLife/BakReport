using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Bak.Report.Domain.Reports.Repositories
{
    public interface IReportInfoRepository : IRepository<ReportInfo, int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ReportInfo> GetAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Task<IEnumerable<ReportInfo>> GetListAsync(int categoryId = -1);
    }
}