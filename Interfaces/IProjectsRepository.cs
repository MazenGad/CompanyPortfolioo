using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectsRepository: IAsyncRepository<ProjectViewModel>
    {
        Task<List<ProjectViewModel>> GetProjectsAsync();
    }
}
