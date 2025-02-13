using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class HorizontalSliderRepository : BaseRepository<HorizontalSliderViewModel>, IHorizontalSliderRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HorizontalSliderRepository(ApplicationDbContext context, IMapper mapper):base(context)
        { _context = context;
            _mapper = mapper;
        }
        public async Task<List<HorizontalSliderViewModel>> GetHorizontalSliderAsync()
        {
            var horizontalSliders= await _context.HorizontalSliders.ToListAsync();
            return _mapper.Map<List<HorizontalSliderViewModel>>(horizontalSliders);

        }
    }
}
