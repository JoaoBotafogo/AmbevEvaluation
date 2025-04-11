using FluentValidation;

namespace WebApi.Features.Products.GetProduct;

public class GetProductValidator : AbstractValidator<GetProductRequest>
{
    public GetProductValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}