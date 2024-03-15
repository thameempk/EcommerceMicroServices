using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.ProductsDbContext
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        { 

        }

        public DbSet<Products> Products { get; set; }

    }
}
