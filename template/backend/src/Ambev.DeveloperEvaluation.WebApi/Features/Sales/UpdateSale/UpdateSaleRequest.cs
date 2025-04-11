using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Request payload for updating a sale
/// </summary>
public class UpdateSaleRequest
{
    /// <summary>
    /// Sale identifier
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// New sale number
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// New branch
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Updated status
    /// </summary>
    public SaleStatus Status { get; set; }
}