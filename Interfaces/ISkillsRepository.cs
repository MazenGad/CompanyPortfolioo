using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface ISkillsRepository:IAsyncRepository<SkillsViewModel>
    {
        Task<List<SkillsViewModel>> GetSkillsAsync();
    }
}
