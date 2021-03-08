using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Bak.Report.Domain.Shared
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule)
        )]
    public class ReportDomainSharedModule : AbpModule
    {
        
    }
}
