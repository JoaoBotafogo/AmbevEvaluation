﻿using MediatR;

namespace WebApi.Features.Products.UpdateProduct;

public class UpdateProductRequest : IRequest<UpdateProductResponse>
{
    public Guid Id { get; set; }
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public decimal Price { get; set; }
}