using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IAskedQuestionRepository:IAsyncRepository<AskedQuestionsViewModel>
    {
        Task<List<AskedQuestionsViewModel>> GetAskedQuestionAsync();
    }
}
