using Bak.Report.Common.Base;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Bak.Report.Application.Contracts.Reports
{
    public interface IReportImageService : IApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> BulkInsertAsync(IEnumerable<ReportImageDto> input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> DeleteAsync(int id);
    }
}