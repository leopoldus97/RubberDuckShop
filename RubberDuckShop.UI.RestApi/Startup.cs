using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RubberDuckShop.Core.ApplicationService;
using RubberDuckShop.Core.ApplicationService.Services;
using RubberDuckShop.Core.DomainService;
using RubberDuckShop.Infrastructure;
using RubberDuckShop.Infrastructure.Repositories;

namespace RubberDuckShop.UI.RestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Environment = env;

        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
                options.AddPolicy("AnyOrigin", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod())
            );
            if (Environment.IsDevelopment())
            {
                services.AddDbContext<RubberDuckShopContext>(opt => opt.UseSqlite("Data source=rubberDuckApp.db"));
            }
            else
            {
                // Azure SQL database:
                services.AddDbContext<RubberDuckShopContext>(opt =>
                    opt.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            }

            services.AddScoped<IRubberDuckRepository, RubberDuckRepository>();
            services.AddScoped<IRubberDuckService, RubberDuckService>();
            services.AddScoped<IDuckColorRepository, DuckColorRepository>();
            services.AddScoped<IDuckColorService, DuckColorService>();
            services.AddScoped<IDuckCostumeRepository, DuckCostumeRepository>();
            services.AddScoped<IDuckCostumeService, DuckCostumeService>();
            services.AddScoped<IDuckPatternRepository, DuckPatternRepository>();
            services.AddScoped<IDuckPatternService, DuckPatternService>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            //services.AddMvc().AddJsonOptions(options =>
            //{
            //    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //    options.SerializerSettings.MaxDepth = 3;
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<RubberDuckShopContext>();
                    //ctx.Database.EnsureDeleted();
                    ctx.Database.EnsureCreated();
                    DbInitializer.Seed(ctx);
                }
                app.UseDeveloperExceptionPage();
            }
            else
            {
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var ctx = scope.ServiceProvider.GetService<RubberDuckShopContext>();
                    //ctx.Database.EnsureDeleted();
                    ctx.Database.EnsureCreated();
                    DbInitializer.Seed(ctx);
                }
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("AnyOrigin");
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoint => {
                endpoint.MapControllers();
            });
        }
    }
}
