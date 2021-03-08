using Bak.Report.Domain;
using Microsoft.AspNetCore.Builder;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace Bak.Report.Swagger
{
    [DependsOn(typeof(ReportDomainModule))]
    public class ReportSwaggerModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();

            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
