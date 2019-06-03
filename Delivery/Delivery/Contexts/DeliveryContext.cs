using Delivery.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Delivery.Contexts
{
    public class DeliveryContext : DbContext
    {
        public DbSet<DeliveryMan> DeliveryMen { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<SingleOrder> SingleOrders { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DeliveryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DeliveryMan>().HasData(new DeliveryMan{
                Id = 1,
                Name = "John",
                Surname = "Jack"
            });
        }

    }
}
