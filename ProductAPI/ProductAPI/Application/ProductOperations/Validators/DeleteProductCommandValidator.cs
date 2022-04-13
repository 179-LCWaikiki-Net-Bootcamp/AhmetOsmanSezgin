using FluentValidation;

namespace ProductAPI.Application.ProductOperations
{
    public class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
            RuleFor(x => x.ProductId).GreaterThan(0);
        }
    }
}
