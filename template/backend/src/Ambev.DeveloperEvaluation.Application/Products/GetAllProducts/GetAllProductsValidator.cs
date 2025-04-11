using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

public class GetAllProductsValidator : AbstractValidator<GetAllProductsQuery>
{
    public GetAllProductsValidator()
    {
        // Nenhuma regra específica por enquanto
    }
}