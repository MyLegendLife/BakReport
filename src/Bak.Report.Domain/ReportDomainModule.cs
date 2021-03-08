using Bak.Report.Domain.Shared;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Bak.Report.Domain
{
    [DependsOn(
        typeof(AbpIdentityDomainModule),
        typeof(ReportDomainSharedModule)
    )]
    public class ReportDomainModule : AbpModule
    {
        
    }
}
