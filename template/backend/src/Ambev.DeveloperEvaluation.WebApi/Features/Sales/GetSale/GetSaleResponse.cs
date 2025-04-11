namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales;

/// <summary>
/// API response model for GetSales operation
/// </summary>
public class GetSaleResponse
{
    /// <summary>
    /// The unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The unique sale number
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Customer name
    /// </summary>
    public string Customer { get; set; } = string.Empty;

    /// <summary>
    /// Branch where the sale occurred
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Total sale amount
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Sale status - true if cancelled
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// Date and time when the sale was created
    /// </summary>
    public DateTime CreatedAt { get; set; }
}