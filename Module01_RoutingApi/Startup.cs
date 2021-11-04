using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module01_RoutingApi
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
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region commented out
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    //Changed the endpoint configuration

            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id??}");

            //});
            #endregion

            #region 2nd commend out . new endpoint printing Hello World
            ////All Middleware till here cannot access the Endpoint
            //app.UseRouting();
            ////All middleware from here onwards can access the Endpoint from the HTTP Context
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World");
            //    });
            //    endpoints.MapGet("/hello", async context =>
            //    {
            //        await context.Response.WriteAsync("helloWorld");
            //    });
            //});
            #endregion

            //All middleware till here cannot access the Endpoint
            app.UseRouting();
            app.Use(async (context, next) =>
            {
                var endpoint = context.GetEndpoint();
                if (endpoint != null)
                {
                    await context.Response.WriteAsync("<html> Endpoint :" + endpoint.DisplayName + "<br>");
                    if (endpoint is RouteEndpoint routeEndpoint)
                    {
                        await context.Response.WriteAsync
                        ("RoutePattern :" + routeEndpoint.RoutePattern.RawText + "<br>");
                    }

                    foreach (var metadata in endpoint.Metadata)
                    {
                        await context.Response.WriteAsync
                        ("metadata: " + metadata + " <br>");
                    }
                }
                else
                {
                    await context.Response.WriteAsync("End point in null");
                }
                await context.Response.WriteAsync("</html>");
                await next();
            }
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World");
                });

                endpoints.MapGet("/hello", async context =>
                {
                    await context.Response.WriteAsync("helloworld");
                });
            });

        }
    }
}
