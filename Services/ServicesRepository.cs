using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{

    public class ServicesRepository : BaseRepository<ServicesViewModel>, IServicesRepository
    {
    
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ServicesRepository(ApplicationDbContext context,IMapper mapper):base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<ServicesViewModel>> GetServicesAsync()
        {
         var services=   await _context.Services.ToListAsync();
            return _mapper.Map<List<ServicesViewModel>>(services);

        }
    }
}

