using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Validator for UpdateSaleCommand
/// </summary>
public class UpdateSaleValidator : AbstractValidator<UpdateSaleCommand>
{
    public UpdateSaleValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Sale ID is required");

        RuleFor(x => x.SaleNumber)
            .NotEmpty()
            .WithMessage("Sale number is required");

        RuleFor(x => x.Branch)
            .NotEmpty()
            .WithMessage("Branch is required");

        RuleFor(x => x.Status)
            .IsInEnum()
            .WithMessage("Status must be a valid value");
    }
}