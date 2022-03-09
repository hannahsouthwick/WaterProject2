using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WaterProject2.Models;

namespace WaterProject2
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration temp)
        {
            Configuration = temp;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // tells asp.net to use the controller views setup and use the MVC pattern
            services.AddControllersWithViews();
            services.AddDbContext<WaterProjectContext>(options =>

           {
               options.UseSqlite(Configuration["ConnectionStrings:WaterDBConnection"]);
           });

            services.AddScoped<IWaterProjectRepository, EFWaterProjectRepository>();
            services.AddScoped<IDonationRepository, EFDonationRepository>();

            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Corresponds to the wwroot
            app.UseStaticFiles();

            // session store, int, string, byte
            app.UseSession();
            app.UseRouting();

            app.UseRouting();

            // changes here
            // endpoints run from top to bottom like if statements
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("typepage",
                    "{projectType}/Page{pageNum}",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("Paging",
                    // interpretting what comes in and creating what comes out, literal "P"
                    "Page{pageNum}",
                    new { Controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapControllerRoute("type",
                    "{projectType}",
                    new { Controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();

                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
            });
        }
    }
}

// All Admin Pages new in Admin Folder
// To Add:
// 1-----
// Add admin folder to Pages and add projects.razor and donations.razor
//
// 2----
// Add " services.AddServerSideBlazor(); " to startup.cs
// and  endpoints.MapBlazorHub();
//      endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");

// 3-----
// Add Index.cshtml with page model to admin

// 4-----
// Add new razor component called routed
// add new razor component called _Imports.razor

// 5-----
// Add new razor component called AdminLayout.razor
// Add new razor componenet called DonationTable.razor

//6-----
// add  to donations.cs model       [BindNever]
// public bool DonationReceived { get; set; }

//7---- run migrations
// dotnet ef migrations add AddReceived field
// dotnet ef database update

//8 -----
// to IWaterProjectRepository add in interface
//public void SaveProject(Project p);
//public void CreateProject(Project p);
//public void DeleteProject(Project p);

//9 -------
// to EFWaterProjectRepository,
// implement interface on error of IWaterProjectRepository
// update public voids for save, update, and delete

// 10------
// Add new razor component called details.razor