using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ait.UnitsCloud.PortalApi.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Ait.UnitsCloud.PortalApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // var x = new DbContextOptionsBuilder<PortalContext>();
            //PortalContext context = null;
            //DbContextOptions options = null;
            //dbContext = new PortalContext(options.UseSqlServer(connectionString));
            //services.AddDbContext<PortalContext>(ctx => ctx.UseSqlServer(connectionString));
            //context = new PortalContext(x.UseSqlServer(connectionString).Options);
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = "{yourAuthorizationServerAddress}";
                options.Audience = "{yourAudience}";
            });
            services.AddAuthentication();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connectionString = Configuration.GetConnectionString("defaultConnection");
            services.AddCors();
            services.AddOptions();
            services.Configure<PortalOptions>(po =>
            {
                po.ConnectionString = connectionString;
            });
            services.AddTransient<IPortalUnitOfWork, PortalUnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseCors(x=> x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseMvc();
        }
    }
}
