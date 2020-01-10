using Microsoft.EntityFrameworkCore;
namespace CustomerSalesApp.Models
{
    public class CustomerSalesDbContext : DbContext
    {

        public CustomerSalesDbContext(DbContextOptions<CustomerSalesDbContext> options):base(options)
        {
            
        }
        public DbSet<Customer> Customers{get;set;}
        public DbSet<Order> Orders{get;set;}
        
    }
}