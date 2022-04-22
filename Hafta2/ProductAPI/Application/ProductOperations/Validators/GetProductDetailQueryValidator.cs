using FluentValidation;

namespace ProductAPI.Application.ProductOperations
{
    public class GetProductDetailQueryValidator : AbstractValidator<GetProductDetailQuery>
    {
        public GetProductDetailQueryValidator()
        {
            RuleFor(x => x.ProductId).GreaterThan(0);
        }
    }
}
