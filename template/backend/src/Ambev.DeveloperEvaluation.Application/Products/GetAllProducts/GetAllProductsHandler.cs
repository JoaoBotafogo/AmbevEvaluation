using AutoMapper;
using FluentValidation;
using MediatR;
using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.Application.Products.GetAllProducts;

/// <summary>
/// Handler for retrieving all products
/// </summary>
public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<GetAllProductsResult>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetAllProductsHandler
    /// </summary>
    public GetAllProductsHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetAllProductsQuery request
    /// </summary>
    public async Task<List<GetAllProductsResult>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetAllProductsValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var products = await _productRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<GetAllProductsResult>>(products);
    }
}