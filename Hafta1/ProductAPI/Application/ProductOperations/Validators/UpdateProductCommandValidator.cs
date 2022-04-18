using FluentValidation;

namespace ProductAPI.Application.ProductOperations
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.ProductId).GreaterThan(0);
            RuleFor(x => x.Model.Name).MinimumLength(2).MaximumLength(30).When(y => y.Model.Name.Trim() != string.Empty);
            RuleFor(x => x.Model.Price).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Model.Stock).GreaterThanOrEqualTo(0).LessThanOrEqualTo(999);
            RuleFor(x => x.Model.Description).MinimumLength(2).MaximumLength(100).When(y => y.Model.Description.Trim() != string.Empty);
        }
    }
}
