using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface IContactUsRepository : IAsyncRepository<ContactUsViewModel>
    {
        Task<ContactUsViewModel> GetContactUsAsync();
    }
}
