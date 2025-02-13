using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IServicesRepository: IAsyncRepository<ServicesViewModel>
    {
        Task<List<ServicesViewModel>> GetServicesAsync();
    }
}
