using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectDetailsService:IAsyncRepository<ProjectDetailsViewModel>
    {
        Task<(ProjectDetails, List<ProjectImage>)> GetProjectDetailsAndImagesAsync(int id);

    }
}
