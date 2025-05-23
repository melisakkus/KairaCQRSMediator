using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Features.CQRS.Handlers.BrandHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController(GetBrandQueryHandler _getBrandQueryHandler,
                                 GetBrandByIdQueryHandler _getBrandByIdQueryHandler,
                                 UpdateBrandCommandHandler _updateBrandCommandHandler,
                                 CreateBrandCommandHandler _createBrandCommandHandler,
                                 RemoveBrandCommandHandler _removeBrandCommandHandler) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _getBrandQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var values = await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }

    }
}
