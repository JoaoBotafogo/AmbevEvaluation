using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales;

/// <summary>
/// Profile for mapping GetSales feature requests to commands
/// </summary>
public class GetSalesProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetSales feature
    /// </summary>
    public GetSalesProfile()
    {
        CreateMap<object, Application.Sales.GetSales.GetSalesCommand>()
            .ConstructUsing(_ => new Application.Sales.GetSales.GetSalesCommand());
    }
}