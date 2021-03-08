using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Bak.Report.Application
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ReportApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                //options.AddMaps<ReportApplicationModule>(validate:true);
                //options.AddProfile<ReportApplicationAutoMapperProfile>(validate: true);
                options.AddMaps<ReportApplicationModule>();
                options.AddProfile<ReportApplicationAutoMapperProfile>();
            });
        }
    }
}
