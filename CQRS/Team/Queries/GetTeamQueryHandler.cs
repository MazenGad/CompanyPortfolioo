using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.Team.Queries
{
    public class GetTeamQueryHandler : IRequestHandler<GetTeamQuery, List<TeamViewModel>>
    {
        private readonly ITeamRepository _teamRepository;
        public GetTeamQueryHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public async Task<List<TeamViewModel>> Handle(GetTeamQuery request, CancellationToken cancellationToken)
        {
            return await _teamRepository.GetTeamAsync();
        }
    }
}
