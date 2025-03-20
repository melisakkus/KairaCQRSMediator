using KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController(GetCategoryQueryHandler _getCategoryQueryHandler) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return View(values);
        }
    }
}
