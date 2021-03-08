using Bak.Report.Application.Contracts;
using Bak.Report.Domain;
using Bak.Report.Domain.Settings;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Bak.Report.Application.Caching
{
    [DependsOn(
        typeof(AbpCachingModule),
        typeof(ReportDomainModule),
        typeof(ReportApplicationContractsModule)
        )]
    public class ReportApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            if (AppSettings.Caching.IsOpen)
            {
                context.Services.AddStackExchangeRedisCache(options =>
                {
                    options.Configuration = AppSettings.Caching.RedisConnectionString;
                });

                var csredis = new CSRedis.CSRedisClient(AppSettings.Caching.RedisConnectionString);
                RedisHelper.Initialization(csredis);

                context.Services.AddSingleton<IDistributedCache>(new CSRedisCache(RedisHelper.Instance));
            }
        }
    }
}
