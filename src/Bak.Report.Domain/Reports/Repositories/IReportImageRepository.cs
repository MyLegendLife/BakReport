using JetBrains.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Bak.Report.Domain.Reports.Repositories
{
    public interface IReportImageRepository : IRepository<ReportImage, int>
    {
        Task BulkInsertAsync([NotNull] IEnumerable<ReportImage> images);
    }
}