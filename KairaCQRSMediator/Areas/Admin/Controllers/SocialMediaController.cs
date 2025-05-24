using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;
using KairaCQRSMediator.Features.Mediator.Queries.GalleryQueries;
using KairaCQRSMediator.Features.Mediator.Queries.SocialMediaQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController(IMediator _mediator) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetSocialMediaQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _mediator.Send(new GetSocialMediaByIdQuery(id));
            var updateCommand = new UpdateSocialMediaCommand
            {
                SocialMediaId = value.SocialMediaId,
                Name = value.Name,
                Icon = value.Icon,
                Url = value.Url
            };

            return View(updateCommand);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateSocialMediaCommand command)
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
        public async Task<IActionResult> Create(CreateSocialMediaCommand command)
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
            await _mediator.Send(new RemoveSocialMediaCommand(id));
            return RedirectToAction("Index");
        }
    }
}
