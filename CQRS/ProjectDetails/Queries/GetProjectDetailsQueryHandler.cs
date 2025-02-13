using AutoMapper;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.ProjectDetails.Queries
{
    public class GetProjectDetailsQueryHandler : IRequestHandler<GetProjectDetailsQuery, GetProjectDetailsViewModel>
    {
        private readonly IProjectDetailsService _projectDetailsService;
        private readonly IMapper _mapper;

        public GetProjectDetailsQueryHandler(IProjectDetailsService projectDetailsService, IMapper mapper)
        {
            _projectDetailsService = projectDetailsService;
            _mapper = mapper;
        }
        public async Task<GetProjectDetailsViewModel> Handle(GetProjectDetailsQuery request, CancellationToken cancellationToken)
        {
            var (projectDetails, projectImages) = await _projectDetailsService.GetProjectDetailsAndImagesAsync(request.Id);
            var viewModel = _mapper.Map<GetProjectDetailsViewModel>(projectDetails); 
            viewModel.ProjectImages = _mapper.Map<List<ImageViewModel>>(projectImages);
            return viewModel;
        }
    }
    
}
