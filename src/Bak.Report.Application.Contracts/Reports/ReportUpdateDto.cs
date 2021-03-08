using System.Collections.Generic;
using Bak.Report.Domain.Reports;
using Volo.Abp.Application.Dtos;

namespace Bak.Report.Application.Contracts.Reports
{
    public class ReportUpdateDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }

        public string Introduction { get; set; }

        public string Description { get; set; }

        public string DocUri { get; set; }

        public List<ReportImage> Images { get; set; }
    }
}
