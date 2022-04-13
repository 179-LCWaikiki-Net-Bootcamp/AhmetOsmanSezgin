using AutoMapper;
using ProductAPI.DbOperations;
using ProductAPI.Models;
using ProductAPI.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Application.ProductOperations
{
    public class GetProductsQuery
    {
        private readonly IProductDbContext _context;

        private readonly IMapper _mapper;

        public GetProductsQuery(IProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IDataResult<List<ProductViewModel>> Handle()
        {
            var products = _context.Products.Where(x => x.IsActive).OrderBy(x => x.Id);

            List<ProductViewModel> productViewModels = _mapper.Map<List<ProductViewModel>>(products);

            return new SuccessDataResult<List<ProductViewModel>>(productViewModels, "Urunleri listeleme islemi basarili");
        }
    }
}
