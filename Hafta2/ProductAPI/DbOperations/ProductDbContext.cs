using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductAPI.Models;

namespace ProductAPI.DbOperations
{
    public class ProductDbContext : DbContext, IProductDbContext
    {
    //    protected readonly IConfiguration Configuration;

    //     public ProductDbContext(IConfiguration configuration)
    //     {
    //         Configuration = configuration;
    //     }

        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     options.UseSqlServer(Configuration.GetConnectionString("ProductDb"));
        // }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        // public override int SaveChanges() => base.SaveChanges();
    }
}
