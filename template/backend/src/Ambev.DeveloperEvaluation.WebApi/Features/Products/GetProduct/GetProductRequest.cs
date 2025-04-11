using MediatR;

namespace WebApi.Features.Products.GetProduct;

public class GetProductRequest : IRequest<GetProductResponse>
{
    public Guid Id { get; set; }
}