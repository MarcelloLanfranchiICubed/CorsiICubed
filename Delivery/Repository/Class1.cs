using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<string> MyProperty { get; set; }
    }
}
