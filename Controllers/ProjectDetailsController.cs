using CompanyPortfolioo.CQRS.ProjectDetails.Queries;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectDetailsController : Controller
    {
        private readonly IMediator _mediator;
        public ProjectDetailsController(IMediator mediator) 
        {
            _mediator = mediator; 
        }
        public async Task<IActionResult> Index(int id) 
        {
            var query = new GetProjectDetailsQuery { Id = id };
            var projectDetails = await _mediator.Send(query); 
            if (projectDetails == null) 
            
            { 
                return View("NotFound"); 
            
            } 
            ViewBag.ProjectImages = projectDetails.ProjectImages;
            
            return View(projectDetails);
        }
    }
}
