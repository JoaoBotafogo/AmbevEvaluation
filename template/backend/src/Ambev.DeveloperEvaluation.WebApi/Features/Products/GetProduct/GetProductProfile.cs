using AutoMapper;
using Domain.Entities;

namespace WebApi.Features.Products.GetProduct;

public class GetProductProfile : Profile
{
    public GetProductProfile()
    {
        CreateMap<Product, GetProductResponse>();
    }
}