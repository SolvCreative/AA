using AA.Facts_Generator;
using AA.NEO_Locator;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AA
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
            services.AddScoped<IDbConnection>((s) =>
            {
                IDbConnection conn1 = new MySqlConnection(Configuration.GetConnectionString("space_facts"));
                conn1.Open();
                return conn1;
            });

            services.AddTransient<IFactsRepo, FactsRepo>();
            services.AddControllersWithViews();


            //services.AddScoped<IDbConnection>((s) =>
            //{
            //    IDbConnection conn2 = new MySqlConnection(Configuration.GetConnectionString("neodb"));
            //    conn2.Open();
            //    return conn2;
            //});

            //services.AddTransient<INeoRepo, NeoRepo>();
            //services.AddControllersWithViews();
            
            services.AddHttpClient("client", c =>
            {
                c.BaseAddress = new Uri("https://api.le-systeme-solaire.net/rest/bodies");
                
            });

        }


        public string id { get; set; }
        public string englishName { get; set; }
        public bool isPlanet { get; set; }
        public Array moons { get; set; }
        public double gravity { get; set; }
        public int meanRadius { get; set; }
        public string discoveryDate { get; set; }

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
