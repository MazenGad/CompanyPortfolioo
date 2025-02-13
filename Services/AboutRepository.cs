using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class AboutRepository :  BaseRepository<AboutViewModel>, IAboutRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AboutRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<AboutViewModel>> GetAboutAsync()
        {

            var aboutUs = await _context.AboutUs.ToListAsync();

            return _mapper.Map<List<AboutViewModel>>(aboutUs);
        }
    }
}