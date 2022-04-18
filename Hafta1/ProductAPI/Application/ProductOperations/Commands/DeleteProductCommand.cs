using ProductAPI.DbOperations;
using ProductAPI.Utilities;
using System.Linq;

namespace ProductAPI.Application.ProductOperations
{
    public class DeleteProductCommand
    {
        private readonly IProductDbContext _context;
        public int ProductId { get; set; }

        public DeleteProductCommand(IProductDbContext context)
        {
            _context = context;
        }

        public IResult Handle()
        {

            var product = _context.Products.FirstOrDefault(x => x.IsActive && x.Id == ProductId);

            if (product is null)
            {
                return new ErrorResult("Silinecek urun bulunamadi.");
            }

            product.IsActive = false; // Silme işlemi yapmadan pasif yaptık
            _context.SaveChanges();

            return new SuccessResult("Urun silme islemi basarili.");
        }
    }
}
