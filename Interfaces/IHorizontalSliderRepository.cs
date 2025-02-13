using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IHorizontalSliderRepository:IAsyncRepository<HorizontalSliderViewModel>
    {
        Task<List<HorizontalSliderViewModel>> GetHorizontalSliderAsync();
    }
}
