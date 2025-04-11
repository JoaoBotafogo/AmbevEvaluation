using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Domain.Entities;
using MediatR;

namespace WebApi.Features.Products.CreateProduct;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    private readonly IProductRepository _repository;

    public CreateProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product
        {
            Id = Guid.NewGuid(),
            Code = request.Code,
            Name = request.Name,
            Description = request.Description,
            Price = request.Price
        };

        var result = await _repository.CreateAsync(entity, cancellationToken);

        return new CreateProductResult
        {
            Id = result.Id,
            Code = result.Code,
            Name = result.Name,
            Description = result.Description,
            Price = result.Price
        };
    }
}