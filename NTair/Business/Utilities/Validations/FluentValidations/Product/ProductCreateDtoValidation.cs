namespace Business.Utilities.Validations.FluentValidations.Product;

public class ProductCreateDtoValidation:AbstractValidator<ProductCreateDto>
{
	public ProductCreateDtoValidation()
	{
		RuleFor(p=>p.Name).NotEmpty().NotNull().MinimumLength(2).MaximumLength(255);
		RuleFor(p => p.Price).NotEmpty().NotNull().LessThan(10000).GreaterThan(100);
		RuleFor(p=>p.Count).NotEmpty().NotNull().LessThan(1500).GreaterThan(5);
		RuleFor(p => p.Description).NotEmpty().NotNull();
    }
}
