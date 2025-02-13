using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.HorizontalSlider.Queries
{
    public class GetHorizontalSliderQueryHandler : IRequestHandler<GetHorizontalSliderQuery, List<HorizontalSliderViewModel>>
    {
        private readonly IHorizontalSliderRepository _horizontalSliderRepository; 
        public GetHorizontalSliderQueryHandler(IHorizontalSliderRepository horizontalSliderRepository)
        {
            _horizontalSliderRepository = horizontalSliderRepository;
        }
        public async Task<List<HorizontalSliderViewModel>> Handle(GetHorizontalSliderQuery request, CancellationToken cancellationToken)
        {
            return await _horizontalSliderRepository.GetHorizontalSliderAsync();
        }
    }
}
