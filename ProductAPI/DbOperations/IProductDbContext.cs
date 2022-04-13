using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;

namespace ProductAPI.DbOperations
{
    public interface IProductDbContext
    {
        DbSet<Product> Products { get; set; }

        int SaveChanges();
    }
}
