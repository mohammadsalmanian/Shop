using AngularEshop.Core.Services.Implementations;
using AngularEshop.Core.Services.Interfaces;
using AngularEshop.Core.Utilities.Extensions.Connection;
using AngularEshop.DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.WebApi
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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(
                new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile($"appsettings.json")
                    .Build()
            );

            #region AddDbContext
            services.AddApplicationDbContext(Configuration);

            /*services.AddDbContext<AngularEshopDbContext>(options =>
            {
                var connectionString = "ConnectionStrings:AngularEshopConnection:Development";
                options.UseSqlServer(Configuration[connectionString]);
            });*/

            //services.AddScoped به ازای هر درخواست یک اینستنت ساخته میشود
            //services.AddTransient  به ازای هر درخواست اگر توی هر کلاس یا کانست رکتوری نیاز به یک آیتم باش به ازای هر نیاز یک اینستنت ساخته میشود

            //در این روش میگوییم اگر آی جنریک ریپوزیتوری یوزر بود جنریک ریپوزیتوری یوزر را بده
            //services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
            //روش بالا برای هر نوع باید یک خط بنویسیم مثلا یوزر و هتل و 

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            #endregion

            #region Application Services
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISliderService,SliderService>();
            services.AddScoped<IProductService, ProductService>();  
            #endregion
            //services.AddMvc(option => option.EnableEndpointRouting = false) ;
            services.AddMvc(option => option.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
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
            app.UseStaticFiles();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "{controller=Users}/{action=Users}/{id?}");
            //});

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Users}/{action=Users}/{id?}"
                );
            });
        }
    }
}