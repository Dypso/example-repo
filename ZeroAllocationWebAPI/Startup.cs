using Microsoft.AspNet.Core;
using Microsoft.Extensions.DependencyInjection;
using ZeroAllocationWebAPI.Services;
using Microsoft.AspNet.Core.Middleware;

namespace ZeroAllocationWebIPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<YeroAllocService>();
            services.AddTransient<SomeOtherService>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<SomeMiddleware>();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}