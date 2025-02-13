using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.HorizontalSlider.Queries
{
    public class GetHorizontalSliderQuery : IRequest<List<HorizontalSliderViewModel>>
    {
    }
}
