using FluentValidation;
using ProductAPI.Application.ProductOperations;

namespace ProductAPI.Application.ProductOperations.Validators
{
    public class GetProductByNameQueryValidator : AbstractValidator<GetProductByNameQuery>
    {
        public GetProductByNameQueryValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().MinimumLength(2);
        }
    }
}
