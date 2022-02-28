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

                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });
        }
    }
}


// To Add:
// 1-----
// To the Basket.cs class
//public virtual void RemoveItem(Project proj)
//{
//    Items.RemoveAll(x => x.Project.ProjectId == proj.ProjectId);
//}

//public virtual void ClearBasket()
//{
//    Items.Clear();
//}
//2----
//Add "Virtual" to AddItem

//3----
//Create new class called SessionBasket that inherits Basket
//All new content in SessionBasket

//4-----
//Add to startup in services ->
//services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
//services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//5-----
//Delete the session lines of code from Donate.cshtml.cs

//6------
// in Donate.cshtml add the button in the tr
//< td class= "text-center" >

//        < form method = "post" asp-page-handler="Remove">

//            < input type = "hidden" name = "projectId" value = "@i.Project.ProjectId" />

//                < input type = "hidden" name = "returnUrl" value = "@Model.ReturnUrl" />

//                    < button type = "submit" class= "btn btn-sm btn-danger" > Remove </ button >

//                    </ form >

//                </ td >

//7------
// In Donate.cshtml.cs
// add Basket b and basket = b; to the DonateModel
// and
//public IActionResult OnPostRemove(int projectId, string returnUrl)
//{
//    basket.RemoveItem(basket.Items.First(x => x.Project.ProjectId == projectId).Project);

//    return RedirectToPage(new { ReturnUrl = returnUrl });
//}

//8------
//update currency on donate.cshtml
// .ToString("#,##0.00")

//9------
//Add checkout button to donate.cshtml

//10------
// add new model to models called donation.cs

//11-----
// to WaterProjectContext add this line at the end
// ->         public DbSet<Donation> Donations { get; set; }
// and add [Key] to Basket.cs

//12---- Run migrations
// if needed, delete the project migrations that creates the project table

//13----- Create new Razor View Checkout.cshtml and place in Checkout Views Folder

//14---- Create new Controller class in controller folder

//15-----
//Add repository models

//16-----
// to startup.cs add another service
// -> services.AddScoped<IDonationRepository, EFDonationRepository>();
