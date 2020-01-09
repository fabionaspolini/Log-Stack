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
            services.AddLogging(builder => { builder.AddNLog("NLog.config"); });
            var provider = services.BuildServiceProvider();

            var logger = provider.GetService<ILogger<Program>>();
            logger.LogWarning("hello nlog warn");
            logger.LogInformation("hello nlog info");
            logger.LogError("hello nlog error");
            
            Console.WriteLine("Finish");
        }
    }
}