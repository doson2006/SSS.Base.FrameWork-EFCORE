using Furion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SSS.FrameWork.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>(null,
                    optionsBuilder =>
                    {
                        //设置oracle使用的版本
                        optionsBuilder.UseOracle(App.Configuration["ConnectionStrings:OracleConnectionString"], b =>
                        {
                            b.UseOracleSQLCompatibility("11");
                        });
                    },
                    //注册拦截器
                    interceptors: new Microsoft.EntityFrameworkCore.Diagnostics.IInterceptor[]
                    {
                        new SqlCommandAuditInterceptor()
                    });
            }, "SSS.FrameWork.Database.Migrations");

            //使用EF的分析工具
            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
        }
    }
}