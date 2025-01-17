using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Products1> Products { get; set; }
        public DbSet<Products_Details> Products_Details { get; set; }

    }
}

