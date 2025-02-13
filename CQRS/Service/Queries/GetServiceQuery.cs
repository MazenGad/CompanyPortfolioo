using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Service.Queries
{
    public class GetServiceQuery : IRequest<List<ServicesViewModel>>
    {
    }
}
