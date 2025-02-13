using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface ITeamRepository:IAsyncRepository<TeamViewModel>
    {
        Task<List<TeamViewModel>> GetTeamAsync();
    }
}
