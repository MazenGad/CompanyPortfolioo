using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
}
public class TestimonialRepository : BaseRepository<TestimonialViewModel>,ITestimonialRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public TestimonialRepository(ApplicationDbContext context,IMapper mapper):base(context)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<List<TestimonialViewModel>> GetTestimonialAsync()
    {
      var testimonials = await _context.Testimonials.ToListAsync();
        return _mapper.Map<List<TestimonialViewModel>>(testimonials);

    }
}
