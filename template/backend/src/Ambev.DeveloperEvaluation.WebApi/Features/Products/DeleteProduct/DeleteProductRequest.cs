using MediatR;

namespace WebApi.Features.Products.DeleteProduct;

public class DeleteProductRequest : IRequest<bool>
{
    public Guid Id { get; set; }
}