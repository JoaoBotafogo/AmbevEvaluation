using MediatR;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Command for updating a sale
/// </summary>
public record UpdateSaleCommand(
    Guid Id,
    string SaleNumber,
    string Branch,
    SaleStatus Status
) : IRequest<UpdateSaleResult>;