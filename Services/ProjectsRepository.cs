using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{

    public class ProjectsRepository : BaseRepository<ProjectViewModel>, IProjectsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProjectsRepository(ApplicationDbContext context, IMapper mapper):base(context) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ProjectViewModel>> GetProjectsAsync()
        {
            var projects = await _context.Projects.Include(p => p.ProjectCategory).ToListAsync();
            return _mapper.Map<List<ProjectViewModel>>(projects);
        }
    }
}

