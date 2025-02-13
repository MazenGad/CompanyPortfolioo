using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class ProjectCategoryService :BaseRepository<ProjectCategoryViewModel> ,IProjectCategoryService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;
        public ProjectCategoryService(IMapper mapper, ApplicationDbContext context):base(context)
        {

            _mapper = mapper;
            _context = context;
        }
        public async Task<List<ProjectCategoryViewModel>> GetProjectCategoriesAsync()
        {
            var projectCategoryList = await _context.ProjectCategories.Include(pc => pc.Projects).ToListAsync();
            var projectCategoryViewModelList = _mapper.Map<List<ProjectCategoryViewModel>>(projectCategoryList);
            return projectCategoryViewModelList;
        }
    }
}
