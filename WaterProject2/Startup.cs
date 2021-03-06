using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
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

            services.AddDbContext<AppIdentityDBContext>(options =>

            {
                options.UseSqlite(Configuration["ConnectionStrings:IdentityConnection"]);
            });

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDBContext>();

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

            //middleware
            app.UseAuthentication();
            app.UseAuthorization();

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

            IdentitySeedData.EnsurePopulated(app);
        }
    }
}

// install core.identity.frameworkcore package
// 3.1.22

// add new class to models folder

// In appsettings.json add new connection string

// in startup.cs add:
//services.AddDbContext<AppIdentityDBContext>(options =>

//{
//    options.UseSqlite(Configuration["ConnectionStrings:IdentityConnection"]);
//});

//services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<AppIdentityDBContext>();

// and also
////middleware
//app.UseAuthentication();
//app.UseAuthorization();

//migrations
//dotnet ef migrations add IdentitySetup --context AppIdentityDbContext --project 'WaterProject2'
//dotnet ef database update --context AppIdentityDbContext --project 'WaterProject2'

// add new class in models
//IdentitySeedData.cs

// add IdentitySeedData.EnsurePopulated(app); to the end

// create model in viewmodels folder called LoginModel

// create new "ACCOUNT" folder in the views folder
// --- inside create new razor view called login.cshtml

// add controller in the controllers folder called AccountController.cs

// to the index.cshtml page inside admin folder of pages add
//@using Microsoft.AspNetCore.Authorization
//@attribute[Authorize]

// to adminlayout, update nav bar with
//< div class= "bg-info text-white p-2" >
 
//     < div class= "container-fluid" >
  

//          < div class= "col" >
   
//               < span class= "navbar-brand m-lg-2" > Water Project Administration</span>
//               </div>

//        <div class= "col-2 text-right" >
//            < a class= "btn tbn-sm btn-primary" href = "/account/logout" > Log Out </ a >
      

//              </ div >
      
//          </ div >
//      </ div >