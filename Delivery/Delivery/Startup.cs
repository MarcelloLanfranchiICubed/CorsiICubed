using Delivery.Contexts;
using Delivery.Models;
using Delivery.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Delivery
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
            services.AddDbContext<DeliveryContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:deliveryDb"]));
            services.AddScoped<ICommonRepository<Recipe>, RecipeRepo>();
            services.AddScoped<ICommonRepository<DeliveryMan>, DeliveryManRepo>();
            services.AddScoped<ICommonRepository<SingleOrder>, SingleOrderRepo>();
            services.AddScoped<ICommonRepository<Order>, OrderRepo>();
            services.AddScoped<ICommonRepository<Restaurant>, RestaurantRepo>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
