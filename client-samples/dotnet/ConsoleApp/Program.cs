using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Abstractions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // ILoggerFactory loggerFactory = new LoggerFactory()
            //     .AddProvider(new ConsoleLoggerProvider())
            //     .AddConsole()
            //     .AddDebug();
            // ILogger logger = loggerFactory.CreateLogger<Program>();
            // logger.LogInformation(
            //     "This is a test of the emergency broadcast system.");
        }
    }
}