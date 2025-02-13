using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Team.Queries
{
    public class GetTeamQuery : IRequest<List<TeamViewModel>>
    {
    }
}
