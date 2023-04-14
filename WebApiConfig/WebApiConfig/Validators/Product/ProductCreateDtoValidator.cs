using FluentValidation;
using WebApiConfig.DTOs.Product;

namespace WebApiConfig.Validators.Product
{
    public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotNull().WithMessage("Product Name must not be  null")
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(255)
                .Must(MustStartWithA)
                .WithMessage("Product name must be start 'A'");

            RuleFor(p => p.Price)
            .NotNull()
            .NotEmpty()
            .GreaterThan(10)
            .LessThan(200);

            RuleFor(p => p.Count)
                .NotNull()
                .NotEmpty()
                .GreaterThan(2);

        }
        private bool MustStartWithA(string name)
        {
            return name.StartsWith('A');
        }
    }
}
