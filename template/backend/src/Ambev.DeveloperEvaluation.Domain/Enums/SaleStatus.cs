namespace Ambev.DeveloperEvaluation.Domain.Enums;

/// <summary>
/// Represents the current status of a sale
/// </summary>
public enum SaleStatus
{
    /// <summary>
    /// The sale was created but not yet finalized
    /// </summary>
    Pending = 0,

    /// <summary>
    /// The sale has been completed
    /// </summary>
    Completed = 1,

    /// <summary>
    /// The sale has been cancelled
    /// </summary>
    Cancelled = 2
}