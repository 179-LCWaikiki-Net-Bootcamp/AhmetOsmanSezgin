using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductAPI.Models;
using System;
using System.Linq;

namespace ProductAPI.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ProductDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProductDbContext>>());

            if (context.Products.Any())
            {
                return;
            }

            context.Products.AddRange(
                new Product { Name = "Product 1", Price = 100, Stock = 10, Description = "desc 1" },
                new Product { Name = "Product 2", Price = 200, Stock = 20, Description = "desc 2" },
                new Product { Name = "Product 3", Price = 300, Stock = 30, Description = "desc 3" },
                new Product { Name = "Product 4", Price = 400, Stock = 40, Description = "desc 4" },
                new Product { Name = "deneme", Price = 500, Stock = 50, Description = "desc 5" }
            );

            context.SaveChanges();
        }
    }
}
