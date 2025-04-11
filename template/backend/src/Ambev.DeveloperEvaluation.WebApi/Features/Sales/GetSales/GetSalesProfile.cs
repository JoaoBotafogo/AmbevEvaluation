using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales;

/// <summary>
/// Profile for mapping GetSales feature requests to commands and results to responses
/// </summary>
public class GetSalesProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetSales feature
    /// </summary>
    public GetSalesProfile()
    {
        // Request -> Command
        CreateMap<GetSalesRequest, Application.Sales.GetSales.GetSalesCommand>();

        // Result -> Response
        CreateMap<Application.Sales.GetSales.GetSalesResult, GetSalesResponse>();
    }
}