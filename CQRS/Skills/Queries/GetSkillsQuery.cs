using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Skills.Queries
{
    public class GetSkillsQuery : IRequest<List<SkillsViewModel>>
    {
    }
}
