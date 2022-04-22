using AutoMapper;
using ProductAPI.DbOperations;
using ProductAPI.Models;
using ProductAPI.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Application.ProductOperations
{
    public class GetProductByNameQuery
    {
        private readonly IProductDbContext _context;
        private readonly IMapper _mapper;
        public string ProductName { get; set; }

        public GetProductByNameQuery(IProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IDataResult<List<ProductDetailViewModel>> Handle()
        {
            var products = _context.Products.Where(x => x.IsActive && x.Name.ToLower().Contains(ProductName.ToLower().Trim()));

            if (products.Count() == 0)
            {
                return new ErrorDataResult<List<ProductDetailViewModel>>("Aranan urun bulunamadi");
            }

            var result = _mapper.Map<List<ProductDetailViewModel>>(products);

            return new SuccessDataResult<List<ProductDetailViewModel>>(result, "Urunu getirme islemi basarili.");
        }

    }
}
