using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers;
using KairaCQRSMediator.Features.CQRS.Queries.TestimonialQueries;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace KairaCQRSMediator.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(GetTestimonialQueryHandler _getTestimonialQueryHandler,
                                        GetTestimonialByIdQueryHandler _getTestimonialByIdQueryHandler,
                                        CreateTestimonialCommandHandler _createTestimonialCommandHandler,
                                        UpdateTestimonialCommandHandler _updateTestimonialCommandHandler,
                                        RemoveTestimonialCommandHandler _removeTestimonialCommandHandler) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _getTestimonialQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var value = await _getTestimonialByIdQueryHandler.Handle(new GetTestimonialByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _updateTestimonialCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialCommand command)
        {
            if (!ModelState.IsValid)
            {
                return View(command);
            }
            await _createTestimonialCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _removeTestimonialCommandHandler.Handle(new RemoveServiceCommand(id));
            return RedirectToAction("Index");
        }
    }
}
