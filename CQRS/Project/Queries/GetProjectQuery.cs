using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Project.Queries
{
    public class GetProjectsQuery : IRequest<List<ProjectViewModel>>
    {
    }
}
