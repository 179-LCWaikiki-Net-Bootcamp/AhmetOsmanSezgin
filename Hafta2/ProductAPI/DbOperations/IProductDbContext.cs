using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.DbOperations
{
    public interface IProductDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }

        int SaveChanges();
    }
}
