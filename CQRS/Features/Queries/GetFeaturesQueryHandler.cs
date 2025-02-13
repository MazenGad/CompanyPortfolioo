using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Features.Queries
{
    public class GetFeaturesQueryHandler : IRequestHandler<GetFeaturesQuery, List<PricingViewModel>>
    {
        private readonly IFeaturesRepository _featuresRepository; 
        public GetFeaturesQueryHandler(IFeaturesRepository featuresRepository)
        {
            _featuresRepository = featuresRepository;
        }
        public async Task<List<PricingViewModel>> Handle(GetFeaturesQuery request, CancellationToken cancellationToken)
        {
            return await _featuresRepository.GetFeaturesAsync();
        }
    }
}
