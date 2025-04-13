using Microsoft.EntityFrameworkCore;
using WhiskAwayAPI.Model;

namespace WhiskAwayAPI
{
    public class ApplicationDbConnect : DbContext
    {
        public ApplicationDbConnect(DbContextOptions<ApplicationDbConnect> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
