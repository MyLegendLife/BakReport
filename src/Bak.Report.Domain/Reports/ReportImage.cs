using System.Text.Json.Serialization;
using Volo.Abp.Domain.Entities;

namespace Bak.Report.Domain.Reports
{
    public class ReportImage : Entity<int>
    {
        public virtual int Sort { get; set; }

        public virtual string Uri { get; set; }

        [JsonIgnore]
        public virtual ReportInfo ReportInfo { get; set; }

        public virtual int ReportInfoId { get; set; }
    }
}