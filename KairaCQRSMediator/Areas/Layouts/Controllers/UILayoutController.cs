using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Layouts.Controllers
{
    [Area("Layouts")]
    public class UILayoutController(IMediator _mediator) : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateSubscribeCommand command)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values
                                             .SelectMany(v => v.Errors)
                                             .Select(e => e.ErrorMessage)
                                             .ToList();
                return Json(new { success = false, errors = errors });
            }
            await _mediator.Send(command);
            return Json(new { success = true, message = "Abonelik başarıyla oluşturuldu!" });
        }
    }
}
