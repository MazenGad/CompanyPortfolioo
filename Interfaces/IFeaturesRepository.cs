using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IFeaturesRepository:IAsyncRepository<PricingViewModel>
    {
        Task<List<PricingViewModel>> GetFeaturesAsync();
    }
}
