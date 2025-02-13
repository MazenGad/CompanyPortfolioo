using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.ProjectCategory.Queries
{
    public class GetProjectCategoryQuery : IRequest<List<ProjectCategoryViewModel>>
    {
    }
}
