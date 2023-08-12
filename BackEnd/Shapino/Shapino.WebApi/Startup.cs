using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shapino.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }
        public IConfiguration Configuration { get; }
        public Microsoft.AspNetCore.Hosting.IHostingEnvironment HostingEnvironment { get; }
        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices0(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()
                ).AddJsonFile($"appsettings.json").Build());            

            //services.AddApplicationDbContext(Configuration);

            /*services.AddDbContext<AngularEshopDbContext>(options =>
            {
                var connectionString = "ConnectionStrings:AngularEshopConnection:Development";
                options.UseSqlServer(Configuration[connectionString]);
            });*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}