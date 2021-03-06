using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;

namespace server
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
            services.Configure<StripeOptions>(options =>
            {
                options.PublishableKey = Environment.GetEnvironmentVariable("STRIPE_PUBLISHABLE_KEY");
                options.SecretKey = Environment.GetEnvironmentVariable("STRIPE_SECRET_KEY");
                options.WebhookSecret = Environment.GetEnvironmentVariable("STRIPE_WEBHOOK_SECRET");
                options.BasicPrice = Environment.GetEnvironmentVariable("BASIC_PRICE_ID");
                options.MediumPrice = Environment.GetEnvironmentVariable("MEDIUM_PRICE_ID");
                options.ProPrice = Environment.GetEnvironmentVariable("PRO_PRICE_ID");
                options.SocialBasicPrice = Environment.GetEnvironmentVariable("SOCIAL_BASIC_PRICE_ID");
                options.SocialMediumPrice = Environment.GetEnvironmentVariable("SOCIAL_MEDIUM_PRICE_ID");
                options.SocialProPrice = Environment.GetEnvironmentVariable("SOCIAL_PRO_PRICE_ID");
                options.ExpoBasicPrice = Environment.GetEnvironmentVariable("EXPO_BASIC_PRICE_ID");
                options.ExpoMediumPrice = Environment.GetEnvironmentVariable("EXPO_MEDIUM_PRICE_ID");
                options.ExpoProPrice = Environment.GetEnvironmentVariable("EXPO_PRO_PRICE_ID");
                options.MarketBasicPrice = Environment.GetEnvironmentVariable("MARKET_BASIC_PRICE_ID");
                options.MarketMediumPrice = Environment.GetEnvironmentVariable("MARKET_MEDIUM_PRICE_ID");
                options.MarketProPrice = Environment.GetEnvironmentVariable("MARKET_PRO_PRICE_ID");
                options.Domain = Environment.GetEnvironmentVariable("DOMAIN");
            });

            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new SnakeCaseNamingStrategy(),
                };
            });
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseHttpsRedirection();
            app.UseFileServer();
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
