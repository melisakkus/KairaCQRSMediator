using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GalleryController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetGalleriesQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _mediator.Send(new GetGalleryByIdQuery(id));
            var updateValue = new UpdateGalleryCommand
            {
                Url = value.Url,
                PhotoGalleryId = value.PhotoGalleryId
            };
            return View(updateValue);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateGalleryCommand command)
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
        public async Task<IActionResult> Create(CreateGalleryCommand command)
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
            await _mediator.Send(new RemoveGalleryCommand(id));
            return RedirectToAction("Index");
        }

    }
}
