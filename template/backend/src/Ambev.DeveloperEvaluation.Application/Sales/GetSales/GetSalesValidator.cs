using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales;

/// <summary>
/// Validator for GetSalesCommand
/// </summary>
public class GetSalesValidator : AbstractValidator<GetSalesCommand>
{
    /// <summary>
    /// Initializes validation rules for GetSalesCommand
    /// </summary>
    public GetSalesValidator()
    {
        // Sem regras no momento, mas mantemos a estrutura
    }
}