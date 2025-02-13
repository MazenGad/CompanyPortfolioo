using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class SkillsRepository : BaseRepository<SkillsViewModel>,ISkillsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SkillsRepository(ApplicationDbContext context,IMapper mapper):base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<SkillsViewModel>> GetSkillsAsync()
        {
          var skills= await _context.Skills.ToListAsync();
            return _mapper.Map<List<SkillsViewModel>>(skills);

        }
    }
}
