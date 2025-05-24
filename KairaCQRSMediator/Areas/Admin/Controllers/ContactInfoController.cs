using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Features.Mediator.Queries.ContactInfoQueries;
using KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactInfoController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetContactInfosQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _mediator.Send(new GetContactInfoByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateContactInfoCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateContactInfoCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _mediator.Send(new RemoveContactInfoCommand(id));
            return RedirectToAction("Index");
        }

    }
}

