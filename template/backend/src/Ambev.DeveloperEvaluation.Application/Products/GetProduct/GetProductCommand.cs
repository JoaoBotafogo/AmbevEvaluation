using MediatR;
using System;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProduct;

public class GetProductCommand : IRequest<GetProductResult>
{
    public Guid Id { get; set; }

    public GetProductCommand(Guid id)
    {
        Id = id;
    }
}