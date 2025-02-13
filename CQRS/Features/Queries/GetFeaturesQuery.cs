using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Features.Queries
{
    public class GetFeaturesQuery : IRequest<List<PricingViewModel>>
    {
    }
}
