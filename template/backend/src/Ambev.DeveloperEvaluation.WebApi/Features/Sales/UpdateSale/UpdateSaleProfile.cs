using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Profile for mapping UpdateSale feature requests and responses
/// </summary>
public class UpdateSaleProfile : Profile
{
    public UpdateSaleProfile()
    {
        CreateMap<UpdateSaleRequest, Application.Sales.UpdateSale.UpdateSaleCommand>();
        CreateMap<Application.Sales.UpdateSale.UpdateSaleResult, UpdateSaleResponse>();
    }
}