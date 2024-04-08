using Microsoft.EntityFrameworkCore;

namespace DataDashboard.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> ProductCategory {get ;set;} 
        public DbSet<Customer> CustomerDetails {get ;set;} 
        public DbSet<Order> Orders {get ;set;} 
        public DbSet<OrderDetails> OrderDetail {get ;set;} 

    }
}
