using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IAboutRepository : IAsyncRepository<AboutViewModel>
    {
        Task<List<AboutViewModel>> GetAboutAsync();
    }
}
