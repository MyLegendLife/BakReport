using System;
using System.Collections.Generic;
using Bak.Report.Domain.Reports;
using Volo.Abp.Application.Dtos;

namespace Bak.Report.Application.Contracts.Reports
{
    public class ReportInfoDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Introduction { get; set; }

        public string Description { get; set; }

        public string DocUri { get; set; }

        public DateTime CreationTime { get; set; }

        public ICollection<ReportImage> Images { get; set; } = new List<ReportImage>();
    }
}
