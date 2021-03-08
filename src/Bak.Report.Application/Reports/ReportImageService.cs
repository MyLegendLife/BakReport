using Bak.Report.Application.Contracts.Reports;
using Bak.Report.Common.Base;
using Bak.Report.Domain.Reports;
using Bak.Report.Domain.Reports.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Bak.Report.Application.Reports
{
    public class ReportImageService : ApplicationService, IReportImageService
    {
        private readonly IReportImageRepository _reportImageRepository;

        public ReportImageService(IReportImageRepository reportImageRepository)
        {
            _reportImageRepository = reportImageRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<ServiceResult> BulkInsertAsync(IEnumerable<ReportImageDto> input)
        {
            var result = new ServiceResult<string>();

            var entities = ObjectMapper.Map<IEnumerable<ReportImageDto>, IEnumerable<ReportImage>>(input);

            await _reportImageRepository.BulkInsertAsync(entities);

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

            await _reportImageRepository.DeleteAsync(x => x.ReportInfoId == id);

            result.IsSuccess();

            return result;
        }
    }
}