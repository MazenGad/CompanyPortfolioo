using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Services
{
    public class AskedQuestionRepository : BaseRepository<AskedQuestionsViewModel>, IAskedQuestionRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AskedQuestionRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

     

        public async Task<List<AskedQuestionsViewModel>> GetAskedQuestionAsync()
        {

            var AskedQuestionUs = await _context.AskedQuestions.ToListAsync();

            return _mapper.Map<List<AskedQuestionsViewModel>>(AskedQuestionUs);
        }
    }
}
