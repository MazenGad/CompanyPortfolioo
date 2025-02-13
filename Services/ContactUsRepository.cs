using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;
namespace CompanyPortfolioo.Services
{

    public class ContactUsRepository : BaseRepository<ContactUsViewModel>, IContactUsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ContactUsRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ContactUsViewModel> GetContactUsAsync()
        {
            var contactUs = await _context.ContactUs.FirstOrDefaultAsync();
            return _mapper.Map<ContactUsViewModel>(contactUs);
        }
    }
}
