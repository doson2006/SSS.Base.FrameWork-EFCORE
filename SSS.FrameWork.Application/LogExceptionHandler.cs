using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DependencyInjection;
using Furion.FriendlyException;
using Furion.Logging.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using SSS.Util.Log;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace SSS.FrameWork.Application
{
    /// <summary>
    /// 全局异常日志
    /// </summary>
    public class LogExceptionHandler : IGlobalExceptionHandler, ISingleton
    {

        public Task OnExceptionAsync(ExceptionContext context)
        {
            // 写日志
            var error = context.Exception;

            string errorMsg = error.InnerException != null && string.IsNullOrEmpty(error.InnerException.ToString())
                ? error.Message
                : $"[{error.InnerException?.Message}]{error.Message}";
            //判断是否自定义异常
            if (context.Exception is AppFriendlyException exp)
            {
            }


            var logMessage = new LogMessage
            {
                ExceptionInfo = errorMsg,
                ExceptionSource = error.Source,
                ExceptionRemark = error.StackTrace,
                OperationTime = DateTime.Now,
                Url = null,
                UserName = null
            };

            var strMsg = LogFormat.ExceptionFormat(logMessage);

            // 配置 Serilog 
            Log.Logger = new LoggerConfiguration()
                    // 最小的日志输出级别
                    .MinimumLevel.Error()
                    .Enrich.FromLogContext()
                    // 配置日志输出到控制台
                    .WriteTo.Console(
                        outputTemplate:
                        "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}")
                    // 配置日志输出到文件，文件输出到当前项目的 logs 目录下
                    // 日记的生成周期为每天
                    .WriteTo.File(Path.Combine("logs", DateTime.Now.ToString("d"), @"log-error.txt"),
                        Serilog.Events.LogEventLevel.Error, rollingInterval: RollingInterval.Day,
                        rollOnFileSizeLimit: true)
                    // 创建 logger
                    .CreateLogger();
            Log.Logger.Error(strMsg);
            return Task.CompletedTask;
        }
    }
}
