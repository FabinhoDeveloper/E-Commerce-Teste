using Microsoft.EntityFrameworkCore;
using e_commerce_api.Source.Models;

namespace e_commerce_api.Source.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Product> Products { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Order> Orders { get; set;}
    }
}