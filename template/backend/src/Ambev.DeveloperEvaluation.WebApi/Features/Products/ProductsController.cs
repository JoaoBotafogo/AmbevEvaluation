using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Features.Products.CreateProduct;
using WebApi.Features.Products.DeleteProduct;
using WebApi.Features.Products.GetAllProducts;
using WebApi.Features.Products.GetProduct;
using WebApi.Features.Products.UpdateProduct;

namespace WebApi.Features.Products;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest request) =>
        Ok(await _mediator.Send(request));

    [HttpGet]
    public async Task<IActionResult> GetAll() =>
        Ok(await _mediator.Send(new GetAllProductsRequest()));

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id) =>
        Ok(await _mediator.Send(new GetProductRequest { Id = id }));

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateProductRequest request)
    {
        if (id != request.Id) return BadRequest();
        return Ok(await _mediator.Send(request));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id) =>
        Ok(await _mediator.Send(new DeleteProductRequest { Id = id }));
}