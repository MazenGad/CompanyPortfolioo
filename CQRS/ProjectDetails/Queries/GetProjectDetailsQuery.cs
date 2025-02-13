using MediatR;

namespace CompanyPortfolioo.CQRS.ProjectDetails.Queries
{
    public class GetProjectDetailsQuery : IRequest<GetProjectDetailsViewModel>
    {
        public int Id { get; set; }

    }
}
