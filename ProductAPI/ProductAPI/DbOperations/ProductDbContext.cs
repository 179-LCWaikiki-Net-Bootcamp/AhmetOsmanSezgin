using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.DbOperations
{
    public class ProductDbContext :DbContext, IProductDbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public override int SaveChanges() => base.SaveChanges();
    }
}
