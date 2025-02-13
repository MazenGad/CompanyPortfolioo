using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.AboutUs.Queries
{
    public class GetAboutQuery : IRequest<List<AboutViewModel>>
    {
    }
}
