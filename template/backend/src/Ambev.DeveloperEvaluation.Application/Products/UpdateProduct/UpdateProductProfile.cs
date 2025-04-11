using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

public class UpdateProductProfile : Profile
{
    public UpdateProductProfile()
    {
        CreateMap<Product, UpdateProductResult>();
    }
}