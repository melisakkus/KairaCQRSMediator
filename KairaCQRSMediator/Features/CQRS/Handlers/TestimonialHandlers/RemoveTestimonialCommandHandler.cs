using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler(IRepository<Testimonial> _repository)
    {
        public async Task Handle(RemoveServiceCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }
    }
}
