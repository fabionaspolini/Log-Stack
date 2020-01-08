using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Abstractions;
using NLog.Extensions.Logging;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var services = new ServiceCollection();
            services.AddLogging();
            var provider = services.BuildServiceProvider();
            
            var factory = provider.GetService<ILoggerFactory>();
            factory.AddNLog();
            factory.ConfigureNLog("NLog.config");

            var logger = provider.GetService<ILogger<Program>>();
            logger.LogWarning("hello nlog warn");
            logger.LogInformation("hello nlog info");
            logger.LogError("hello nlog error");
            
            Console.WriteLine("Finish");
        }
    }
}