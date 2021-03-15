using System.Collections.Generic;
using System.Threading.Tasks;
using Bak.Report.Common.Base;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Bak.Report.Application.Contracts.Reports
{
    public interface IReportInfoService : IApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ServiceResult<ReportInfoDto>> GetAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> CreateAsync(ReportCreateUpdateInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> UpdateAsync(ReportCreateUpdateInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ServiceResult> DeleteAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult<PagedResultDto<ReportInfoDto>>> GetListAsync(PagedAndSortedResultRequestDto input);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ServiceResult<IEnumerable<ReportInfoDto>>> GetListAsync(int categoryId = -1);
    }
}