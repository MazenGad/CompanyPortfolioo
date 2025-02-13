using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.Interfaces
{
    public interface ITestimonialRepository:IAsyncRepository<TestimonialViewModel>
    {
        Task<List<TestimonialViewModel>> GetTestimonialAsync();
    }
}
