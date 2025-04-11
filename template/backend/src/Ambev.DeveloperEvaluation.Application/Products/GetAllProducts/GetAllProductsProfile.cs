using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

public class GetAllProductsProfile : Profile
{
    public GetAllProductsProfile()
    {
        CreateMap<Product, GetAllProductsResult>();
    }
}