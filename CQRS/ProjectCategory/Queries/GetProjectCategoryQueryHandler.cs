using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using MediatR;

namespace CompanyPortfolioo.CQRS.ProjectCategory.Queries
{
    public class GetProjectCategoryQueryHandler : IRequestHandler<GetProjectCategoryQuery, List<ProjectCategoryViewModel>>
    {
        private readonly IProjectCategoryService _projectCategoryRepository; 
        public GetProjectCategoryQueryHandler(IProjectCategoryService projectCategoryRepository)
        {
            _projectCategoryRepository = projectCategoryRepository;
        }
        public async Task<List<ProjectCategoryViewModel>> Handle(GetProjectCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _projectCategoryRepository.GetProjectCategoriesAsync();
        }
    }
}
