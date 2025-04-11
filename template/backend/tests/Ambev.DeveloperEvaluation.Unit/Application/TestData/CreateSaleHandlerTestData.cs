using Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

public static class CreateSaleHandlerTestData
{
    public static CreateSaleCommand GenerateValidCommand()
    {
        return new CreateSaleCommand
        {
            SaleNumber = "SALE-001",
            Branch = "São Paulo",
            Items = new List<CreateSaleItemDto>
            {
                new CreateSaleItemDto
                {
                    ProductId = Guid.NewGuid(),
                    Quantity = 2,
                    DiscountPercentage = 0
                },
                new CreateSaleItemDto
                {
                    ProductId = Guid.NewGuid(),
                    Quantity = 1,
                    DiscountPercentage = 10
                }
            }
        };
    }
}