﻿using Bak.Report.Common.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace Bak.Report.HttpApi.Host
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                      .UseLog4Net()
                      .ConfigureWebHostDefaults(builder =>
                      {
                          builder.UseIISIntegration()
                                 .ConfigureKestrel(options =>
                                 {
                                     options.AddServerHeader = false;
                                 })
                                 .UseUrls($"http://*:44362")
                                 .UseStartup<Startup>();
                      }).UseAutofac().Build().RunAsync();
        }
    }
}
