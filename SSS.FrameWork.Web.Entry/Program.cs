using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace SSS.FrameWork.Web.Entry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.Inject()
                                     .UseStartup<Startup>();
                })
                .UseSerilogDefault(config =>
                {
                    config
                        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}")
                        //.WriteTo.File(Path.Combine("logs", DateTime.Now.ToString("d"), "log-info.txt"),restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information, rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                        //.WriteTo.File(Path.Combine("logs", DateTime.Now.ToString("d"), "log-error.txt"), restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error, rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                        ;
                });
    }
}