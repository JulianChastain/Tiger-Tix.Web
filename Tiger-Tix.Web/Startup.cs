using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tiger_Tix.Web.Services;

namespace Tiger_Tix.Web
{
    public class Startup
    {
        /*
         * Here we do dependency injection to ensure that our services are available to the controller
         */
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //When the AppController class is instantiated, this services will be passed implicitly
            services.AddDbContext<LoginService>(
                cfg => { cfg.UseSqlServer();}
            );
            services.AddDbContext<EventRepository>(
                cfg => { cfg.UseSqlServer();}
            );
            services.AddSingleton<ILoginService, LoginService>();
            services.AddSingleton<IEventRepository, EventRepository>();
            services.AddRazorPages();
        }

        /*
         * Configures HTTP request pipeline. this will rarely be changed
         */
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    "Default",
                    "/{controller}/{action}/{id?}",
                    new {controller = "App", action = "Index"}
                );
            });
        }
    }
}