using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.ContactUs.Queries
{
    public class GetContactUsQueryHandler : IRequestHandler<GetContactUsQuery, ContactUsViewModel>
    {
        private readonly IContactUsRepository _contactUsRepository;
        public GetContactUsQueryHandler(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }
        public async Task<ContactUsViewModel> Handle(GetContactUsQuery request, CancellationToken cancellationToken)
        {
            return await _contactUsRepository.GetContactUsAsync();
        }

    }
}
