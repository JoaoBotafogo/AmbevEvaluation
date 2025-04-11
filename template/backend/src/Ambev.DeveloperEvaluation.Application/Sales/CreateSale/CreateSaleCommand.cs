using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Command for creating a new sale.
/// </summary>
/// <remarks>
/// This command is used to capture data required for creating a sale, 
/// including the sale number, branch, and a list of sale items. 
/// It implements <see cref="IRequest{TResponse}"/> and uses 
/// <see cref="CreateSaleValidator"/> for validation.
/// </remarks>
public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    /// <summary>
    /// Gets or sets the sale number (unique identifier for display).
    /// </summary>
    public string SaleNumber { get; set; } = default!;

    /// <summary>
    /// Gets or sets the branch where the sale occurred.
    /// </summary>
    public string Branch { get; set; } = default!;

    /// <summary>
    /// Gets or sets the list of items included in the sale.
    /// </summary>
    public List<CreateSaleItemDto> Items { get; set; } = new();

    /// <summary>
    /// Validates the current command instance.
    /// </summary>
    /// <returns>A <see cref="ValidationResultDetail"/> with validation info.</returns>
    public ValidationResultDetail Validate()
    {
        var validator = new CreateSaleCommandValidator();
        var result = validator.Validate(this);
        return new ValidationResultDetail
        {
            IsValid = result.IsValid,
            Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        };
    }
}

/// <summary>
/// DTO for an item in a sale.
/// </summary>
public class CreateSaleItemDto
{
    /// <summary>
    /// Gets or sets the product ID for the item.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Gets or sets the quantity of the product being sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the discount percentage to be applied.
    /// </summary>
    public decimal DiscountPercentage { get; set; }
}