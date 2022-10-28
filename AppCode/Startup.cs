using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Text;

namespace AppCode
{
    public class Startup
    {
        // todo configure DI and add controller end points.
        
        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app
                .UseRouting()
                .UseEndpoints(endPoints => { endPoints.MapControllers(); });
        }
    }
}
