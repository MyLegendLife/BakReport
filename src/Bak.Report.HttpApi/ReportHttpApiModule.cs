using Bak.Report.Application;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Bak.Report.HttpApi
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(ReportApplicationModule)
        )]
    public class ReportHttpApiModule : AbpModule
    {
        
    }
}
