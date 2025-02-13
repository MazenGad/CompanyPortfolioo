using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.AskedQuestion.Queries
{
    public class GetAskedQuestionQuery : IRequest<List<AskedQuestionsViewModel>>
    {
    }
}
