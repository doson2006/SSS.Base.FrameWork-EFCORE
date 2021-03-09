using Furion;
using Furion.UnifyResult;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SSS.FrameWork.Application;

namespace SSS.FrameWork.Web.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddJwt<JwtHandler>();

            services.AddCorsAccessor();

            services.AddControllers()
                    .AddInjectWithUnifyResult<Application.RESTfulResultProvider>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCorsAccessor();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseInject(string.Empty);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}