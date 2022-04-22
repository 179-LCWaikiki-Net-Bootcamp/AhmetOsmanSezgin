using AutoMapper;
using ProductAPI.Models;

namespace ProductAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<Product, ProductDetailViewModel>();
            CreateMap<CreateProductModel, Product>();
        }
    }
}
