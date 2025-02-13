using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.AskedQuestion.Queries
{
    public class GetAskedQuestionQueryHandler : IRequestHandler<GetAskedQuestionQuery, List<AskedQuestionsViewModel>>
    {
        private readonly IAskedQuestionRepository _AskedQuestionRepository; 
        public GetAskedQuestionQueryHandler(IAskedQuestionRepository AskedQuestionRepository)
        {
            _AskedQuestionRepository = AskedQuestionRepository;
        }
        public async Task<List<AskedQuestionsViewModel>> Handle(GetAskedQuestionQuery request, CancellationToken cancellationToken)
        {
            return await _AskedQuestionRepository.GetAskedQuestionAsync();
        }
    }
}
