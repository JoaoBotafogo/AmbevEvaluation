using MediatR;

namespace WebApi.Features.Products.GetAllProducts;

public class GetAllProductsRequest : IRequest<List<GetAllProductsResponse>>
{
}