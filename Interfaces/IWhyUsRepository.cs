using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IWhyUsRepository:IAsyncRepository<WhyUsViewModel>
    {
        Task<List<WhyUsViewModel>> GetWhyUsAsync();
    }
}
