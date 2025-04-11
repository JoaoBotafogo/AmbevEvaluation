using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Relacionamentos
    public ICollection<SaleItem>? SaleItems { get; set; }
}