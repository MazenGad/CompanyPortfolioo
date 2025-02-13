using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.WhyUs.Queries
{
    public class GetWhyUsQuery : IRequest<List<WhyUsViewModel>>
    {
    }
}
