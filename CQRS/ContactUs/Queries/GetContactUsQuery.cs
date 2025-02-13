using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.ContactUs.Queries
{
    public class GetContactUsQuery : IRequest<ContactUsViewModel>
    {
    }
}
