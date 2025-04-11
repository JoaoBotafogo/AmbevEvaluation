namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Result returned after a successful sale creation.
/// </summary>
public class CreateSaleResult
{
    /// <summary>
    /// The unique identifier of the created sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The generated sale number.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// The branch where the sale occurred.
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// The total amount for the sale.
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// The list of items in the sale.
    /// </summary>
    public List<CreateSaleItemResult> Items { get; set; } = [];
    
    /// <summary>
    /// The creation date of the sale.
    /// </summary>
    public DateTime CreatedAt { get; set; }
}

/// <summary>
/// Represents a single item in the sale result.
/// </summary>
public class CreateSaleItemResult
{
    /// <summary>
    /// The unique identifier of the product sold.
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// The quantity of the product sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// The discount applied to the item (in %).
    /// </summary>
    public decimal DiscountPercentage { get; set; }

    /// <summary>
    /// The discount amount (absolute value).
    /// </summary>
    public decimal DiscountAmount { get; set; }

    /// <summary>
    /// The final price after discount.
    /// </summary>
    public decimal FinalPrice { get; set; }
}