namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProducts;

public class CreateProductResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}