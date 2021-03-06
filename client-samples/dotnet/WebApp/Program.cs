using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder
                    .UseStartup<Startup>()
                    .ConfigureLogging((ctx, builder) =>
                    {
                        builder.AddConfiguration(ctx.Configuration.GetSection("Logging"));
                        builder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                        
                        // Microsoft Logging
                        // if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == Environments.Development)
                        // {
                        //     builder.ClearProviders();
                        //     builder.AddConsole();
                        //     builder.AddDebug();
                        // }
                        
                        // builder.AddFile(o => o.RootPath = ctx.HostingEnvironment.ContentRootPath);
                    })
                    .UseNLog());
    }
}