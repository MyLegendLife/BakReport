using Volo.Abp.Application.Dtos;

namespace Bak.Report.Application.Contracts.Reports
{
    public class ReportCategoryDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
