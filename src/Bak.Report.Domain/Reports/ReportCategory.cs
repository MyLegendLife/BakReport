using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Bak.Report.Domain.Reports
{
    public class ReportCategory : Entity<int>
    {
        public virtual string Name { get; set; }

        public virtual ICollection<ReportInfo> ReportInfos { get; set; } = new List<ReportInfo>();
    }
}