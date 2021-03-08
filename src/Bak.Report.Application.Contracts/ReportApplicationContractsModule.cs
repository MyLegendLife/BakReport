using Bak.Report.Domain;
using Volo.Abp.Modularity;

namespace Bak.Report.Application.Contracts
{
    [DependsOn(typeof(ReportDomainModule))]
    public class ReportApplicationContractsModule :AbpModule
    {
    }
}
