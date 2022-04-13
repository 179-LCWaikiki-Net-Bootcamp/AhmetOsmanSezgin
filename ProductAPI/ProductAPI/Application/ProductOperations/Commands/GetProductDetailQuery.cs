using AutoMapper;
using ProductAPI.DbOperations;
using ProductAPI.Models;
using ProductAPI.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Application.ProductOperations
{
    public class GetProductDetailQuery
    {
        private readonly IProductDbContext _context;
        private readonly IMapper _mapper;
        public int ProductId { get; set; }

        public GetProductDetailQuery(IProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IDataResult<ProductDetailViewModel> Handle()
        {
            var product = _context.Products.SingleOrDefault(x => x.IsActive && x.Id == ProductId);

            if(product is null)
            {
                return new ErrorDataResult<ProductDetailViewModel>("Aranan urun bulunamadi");
            }

            var result = _mapper.Map<ProductDetailViewModel>(product);

            return new SuccessDataResult<ProductDetailViewModel>(result, "Urunu getirme islemi basarili.");
        }
    }
}
