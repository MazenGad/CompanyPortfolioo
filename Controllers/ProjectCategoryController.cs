using CompanyPortfolioo.CQRS.AboutUs.Queries;
using CompanyPortfolioo.CQRS.ProjectCategory.Queries;
using CompanyPortfolioo.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPortfolioo.Controllers
{
    public class ProjectCategoryController : Controller
    {
        
        private readonly IMediator _mediator;

        public ProjectCategoryController( IMediator mediator)
        {
            _mediator = mediator;
        
        
        }
        public async Task<IActionResult> Index()
        {
            var categoryList = await _mediator.Send(new GetProjectCategoryQuery());
            ViewBag.CategoryNames = categoryList.Select
                (p => new
                {
                    p.Id,
                    p.CategoryName
                }).Distinct()
                .ToList();
            return View(categoryList);
        }
        public IActionResult GetProjectCategory()
        {

            return View();

        }
    }
}