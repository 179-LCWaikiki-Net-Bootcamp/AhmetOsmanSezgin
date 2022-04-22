using AutoMapper;
using ProductAPI.DbOperations;
using ProductAPI.Models;
using ProductAPI.Utilities;
using System.Linq;

namespace ProductAPI.Application.ProductOperations
{
    public class CreateProductCommand
    {
        private readonly IProductDbContext _context;

        private readonly IMapper _mapper;

        public CreateProductModel Model { get; set; }

        public CreateProductCommand(IProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IResult Handle()
        {
            var product = _context.Products.SingleOrDefault(x => x.Name.ToLower() == Model.Name.ToLower());
            if (product is not null)
            {
                return new ErrorResult("Eklenecek olan urun zaten mevcut.");
            }

            product = _mapper.Map<Product>(Model);

            _context.Products.Add(product);
            _context.SaveChanges();

            return new SuccessResult("Urun ekleme islemi basarili.");
        }
    }
}
