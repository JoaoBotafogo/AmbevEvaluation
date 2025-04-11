using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales;

/// <summary>
/// Response model for a single sale in the list
/// </summary>
public class GetSalesResponse
{
    /// <summary>
    /// Unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Sale number for tracking
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Customer name
    /// </summary>
    public string Customer { get; set; } = string.Empty;

    /// <summary>
    /// Branch name
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Date of the sale
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Total amount of the sale
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// Indicates if the sale is cancelled
    /// </summary>
    public SaleStatus Status { get; set; }
}