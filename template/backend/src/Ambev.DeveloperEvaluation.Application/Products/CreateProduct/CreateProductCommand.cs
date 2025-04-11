using MediatR;

namespace WebApi.Features.Products.CreateProduct;

public class CreateProductCommand : IRequest<CreateProductResult>
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}