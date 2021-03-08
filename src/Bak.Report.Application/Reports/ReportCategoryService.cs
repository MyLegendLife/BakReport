using Bak.Report.Application.Contracts.Reports;
using Bak.Report.Common.Base;
using Bak.Report.Domain.Reports;
using Bak.Report.Domain.Reports.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Bak.Report.Application.Reports
{
    public class ReportCategoryService : ApplicationService, IReportCategoryService
    {
        private readonly IReportCategoryRepository _reportCategoryRepository;
        private readonly IReportInfoRepository _reportInfoRepository;

        public ReportCategoryService(IReportCategoryRepository reportCategoryRepository, IReportInfoRepository reportInfoRepository)
        {
            _reportCategoryRepository = reportCategoryRepository;
            _reportInfoRepository = reportInfoRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResult<ReportCategoryDto>> GetAsync(int id)
        {
            var result = new ServiceResult<ReportCategoryDto>();

            var entity = await _reportCategoryRepository.GetAsync(id);

            var dto = ObjectMapper.Map<ReportCategory, ReportCategoryDto>(entity);

            result.IsSuccess(dto);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult> CreateAsync(ReportCategoryDto input)
        {
            var result = new ServiceResult<string>();

            var entity = ObjectMapper.Map<ReportCategoryDto, ReportCategory>(input);

            await _reportCategoryRepository.InsertAsync(entity);

            result.IsSuccess();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult> UpdateAsync(ReportCategoryDto input)
        {
            var result = new ServiceResult<string>();

            var entity = ObjectMapper.Map<ReportCategoryDto, ReportCategory>(input);

            await _reportCategoryRepository.UpdateAsync(entity);

            result.IsSuccess();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResult> DeleteAsync(int id)
        {
            var result = new ServiceResult();

            if (_reportInfoRepository.Count(x => x.CategoryId == id) > 0)
            {
                result.IsFailed("该类别下有报表，无法删除");

                return result;
            }

            await _reportCategoryRepository.DeleteAsync(id);

            result.IsSuccess();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult<IEnumerable<ReportCategoryDto>>> GetListAsync()
        {
            var result = new ServiceResult<IEnumerable<ReportCategoryDto>>();

            var list = await _reportCategoryRepository.GetListAsync();

            var dtos = ObjectMapper.Map<IEnumerable<ReportCategory>, IEnumerable<ReportCategoryDto>>(list);

            result.IsSuccess(dtos);

            return result;
        }
    }
}