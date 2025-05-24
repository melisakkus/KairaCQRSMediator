using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.Controllers
{
    [Area("Layouts")]
    public class AdminLayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
