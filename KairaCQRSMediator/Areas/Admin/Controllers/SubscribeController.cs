using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;
using KairaCQRSMediator.Features.Mediator.Queries.SubscribeQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscribeController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetSubscribeQuery());
            return View(values);
        }

        public async Task<IActionResult> Update(int id)
        {
            var value = await _mediator.Send(new GetSubscribeByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateSubscribeCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSubscribeCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Remove(int id)
        {
            await _mediator.Send(new RemoveSubscribeCommand(id));
            return RedirectToAction("Index");
        }


    }
}
