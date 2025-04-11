using AutoMapper;
using Domain.Entities;

namespace WebApi.Features.Products.GetAllProducts;

public class GetAllProductsProfile : Profile
{
    public GetAllProductsProfile()
    {
        CreateMap<Product, GetAllProductsResponse>();
    }
}