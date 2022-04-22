using ProductAPI.DbOperations;
using ProductAPI.Models;
using ProductAPI.Utilities;
using System.Linq;

namespace ProductAPI.Application.ProductOperations
{
    public class UpdateProductCommand
    {
        private readonly IProductDbContext _context;
        public int ProductId { get; set; }
        public UpdateProductModel Model { get; set; }

        public UpdateProductCommand(IProductDbContext context)
        {
            _context = context;
        }

        public IResult Handle()
        {
            var product = _context.Products.SingleOrDefault(x => x.Id == ProductId);

            if(product is null)
            {
                return new ErrorResult("Guncellenecek urun bulunamadi.");
            }

            product.Name = string.IsNullOrEmpty(Model.Name.Trim()) ? product.Name : Model.Name;
            product.Description = string.IsNullOrEmpty(Model.Description.Trim()) ? product.Description : Model.Description;
            product.Price = Model.Price > 0 ? Model.Price : 0;
            product.Stock = Model.Stock > 0 ? Model.Price : 0;
            _context.SaveChanges();

            return new SuccessResult("Urun guncelleme islemi basarili.");
        }
    }
}
