using Microsoft.EntityFrameworkCore;
using PaulCRM.Models;

namespace PaulCRM.Data
{
    public class PaulCRMContext : DbContext
    {
        public PaulCRMContext(DbContextOptions<PaulCRMContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => op.OrderProductId);
        }
    }
}
