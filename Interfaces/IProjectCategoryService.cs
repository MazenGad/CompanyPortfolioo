using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IProjectCategoryService : IAsyncRepository<ProjectCategoryViewModel>
    {
        Task<List<ProjectCategoryViewModel>> GetProjectCategoriesAsync();
    }
}
