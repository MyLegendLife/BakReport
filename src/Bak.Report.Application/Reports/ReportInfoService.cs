using Bak.Report.Application.Contracts.Reports;
using Bak.Report.Common.Base;
using Bak.Report.Domain.Reports;
using Bak.Report.Domain.Reports.Repositories;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Bak.Report.Application.Reports
{
    public class ReportInfoService : ApplicationService, IReportInfoService
    {
        private readonly IReportInfoRepository _reportInfoRepository;
        private readonly IReportImageRepository _reportImageRepository;

        public ReportInfoService(IReportInfoRepository reportInfoRepository, IReportImageRepository reportImageRepository)
        {
            _reportInfoRepository = reportInfoRepository;
            _reportImageRepository = reportImageRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ServiceResult<ReportInfoDto>> GetAsync(int id)
        {
            var result = new ServiceResult<ReportInfoDto>();

            var report = await _reportInfoRepository.GetAsync(id);

            var dto = ObjectMapper.Map<ReportInfo, ReportInfoDto>(report);

            result.IsSuccess(dto);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult> CreateAsync(ReportCreateUpdateInput input)
        {
            var result = new ServiceResult<string>();

            var entity = ObjectMapper.Map<ReportCreateUpdateInput, ReportInfo>(input);

            await _reportInfoRepository.InsertAsync(entity);
            //await _reportImageRepository.BulkInsertAsync(entity.Images);

            result.IsSuccess();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult> UpdateAsync(ReportCreateUpdateInput input)
        {
            var result = new ServiceResult<string>();

            var entity = ObjectMapper.Map<ReportCreateUpdateInput, ReportInfo>(input);

            await _reportInfoRepository.UpdateAsync(entity);

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
            var result = new ServiceResult<string>();

            await _reportInfoRepository.DeleteAsync(id);

            result.IsSuccess();

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult<PagedResultDto<ReportInfoDto>>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var result = new ServiceResult<PagedResultDto<ReportInfoDto>>();

            var count = await _reportInfoRepository.GetCountAsync();

            //var dfd = await _reportInfoRepository.GetListAsync();

            var list = await _reportInfoRepository.GetPagedListAsync(input.SkipCount, input.MaxResultCount, input.Sorting);

            result.IsSuccess(new PagedResultDto<ReportInfoDto>
            {
                TotalCount = count,
                Items = ObjectMapper.Map<List<ReportInfo>, List<ReportInfoDto>>(list)
            });

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult<IEnumerable<ReportInfoDto>>> GetListAsync()
        {
            var result = new ServiceResult<IEnumerable<ReportInfoDto>>();

            var list = await _reportInfoRepository.GetListAsync();

            var dtos = ObjectMapper.Map<IEnumerable<ReportInfo>, IEnumerable<ReportInfoDto>>(list);

            result.IsSuccess(dtos);

            return result;
        }
    }
}