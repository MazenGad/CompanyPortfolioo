using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Testimonial.Queries
{
    public class GetTestimonialQuery : IRequest<List<TestimonialViewModel>>
    {
    }
}
