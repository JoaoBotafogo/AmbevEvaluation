using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using NSubstitute;
using Xunit;

public class CreateSaleHandlerTests
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;
    private readonly CreateSaleHandler _handler;

    public CreateSaleHandlerTests()
    {
        _saleRepository = Substitute.For<ISaleRepository>();
        _mapper = Substitute.For<IMapper>();

        _handler = new CreateSaleHandler(_saleRepository, _mapper);
    }

    [Fact]
    public async Task Handle_Should_Create_Sale_With_ValidData()
    {
        // Arrange
        var command = new CreateSaleCommand
        {
            SaleNumber = "SALE-001",
            Branch = "São Paulo",
            Items = new List<CreateSaleItemDto>
            {
                new CreateSaleItemDto
                {
                    ProductId = Guid.NewGuid(),
                    Quantity = 2,
                    DiscountPercentage = 10
                },
                new CreateSaleItemDto
                {
                    ProductId = Guid.NewGuid(),
                    Quantity = 1,
                    DiscountPercentage = 0
                }
            }
        };

        var fakeSaleResult = new CreateSaleResult
        {
            Id = Guid.NewGuid()
        };

        _mapper.Map<CreateSaleResult>(Arg.Any<Sale>())
               .Returns(fakeSaleResult);

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        await _saleRepository.CreateAsync(Arg.Any<Sale>());
        Assert.Equal(fakeSaleResult.Id, result.Id);
    }
}