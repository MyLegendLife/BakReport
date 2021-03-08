using System.Collections.Generic;
using Bak.Report.Common.Base;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Bak.Report.Application.Contracts.Reports
{
    public interface IReportCategoryService : IApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ServiceResult<ReportCategoryDto>> GetAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> CreateAsync(ReportCategoryDto input);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<ServiceResult> UpdateAsync(ReportCategoryDto input);

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
        Task<ServiceResult<IEnumerable<ReportCategoryDto>>> GetListAsync();
    }
}