using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using KairaCQRSMediator.Features.Mediator.Commands.ProductCommands;
using KairaCQRSMediator.Features.Mediator.Queries.ProductQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IMediator _mediator, GetCategoryQueryHandler _getCategoryQueryHandler) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var categories = await _getCategoryQueryHandler.Handle();
            ViewBag.Categories = (from x in categories
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList();
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var categories = await _getCategoryQueryHandler.Handle();
            ViewBag.Categories = (from x in categories
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList();
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            return View(product);
        }
    }
}
