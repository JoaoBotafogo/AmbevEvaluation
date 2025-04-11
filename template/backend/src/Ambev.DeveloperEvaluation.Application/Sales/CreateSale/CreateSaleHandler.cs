using AutoMapper;
using MediatR;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Handler for processing CreateSaleCommand requests.
/// </summary>
public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of CreateSaleHandler.
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CreateSaleHandler(ISaleRepository saleRepository, IMapper mapper)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateSaleCommand request.
    /// </summary>
    /// <param name="command">The CreateSale command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created sale details</returns>
    public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
    {
        var validator = new CreateSaleCommandValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var sale = new Sale
        {
            Id = Guid.NewGuid(),
            SaleNumber = command.SaleNumber,
            Branch = command.Branch,
            CreatedAt = DateTime.UtcNow,
            Items = new List<SaleItem>()
        };

        foreach (var item in command.Items)
        {
            if (item.Quantity > 20)
                throw new Exception($"Produto {item.ProductId} excede o limite de 20 unidades por venda.");

            decimal basePrice = 100m; // Valor fixo, pode ser ajustado depois

            decimal discountPercentage = 0;
            if (item.Quantity >= 4 && item.Quantity < 10)
                discountPercentage = 10;
            else if (item.Quantity >= 10 && item.Quantity <= 20)
                discountPercentage = 20;

            decimal discountAmount = basePrice * item.Quantity * (discountPercentage / 100);
            decimal finalPrice = basePrice * item.Quantity - discountAmount;

            sale.Items.Add(new SaleItem
            {
                Id = Guid.NewGuid(),
                ProductId = item.ProductId,
                Quantity = item.Quantity,
                DiscountPercentage = discountPercentage,
                DiscountAmount = discountAmount,
                FinalPrice = finalPrice
            });
        }

        var createdSale = await _saleRepository.CreateAsync(sale, cancellationToken);
        var result = _mapper.Map<CreateSaleResult>(createdSale);
        return result;
    }
}