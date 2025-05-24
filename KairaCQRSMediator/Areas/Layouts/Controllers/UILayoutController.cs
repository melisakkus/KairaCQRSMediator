using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.Controllers
{
    [Area("Layouts")]
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
