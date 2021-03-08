using System;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Bak.Report.Domain.Reports
{
    public class ReportInfo : Entity<int>, IHasCreationTime, IHasModificationTime
    {
        public virtual string Name { get; set; }

        public virtual ReportCategory Category { get; set; }

        public virtual int CategoryId { get; set; }

        public virtual string Introduction { get; set; }

        public virtual string Description { get; set; }

        public virtual string DocUri { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public virtual ICollection<ReportImage> Images { get; set; } = new List<ReportImage>();
    }
}