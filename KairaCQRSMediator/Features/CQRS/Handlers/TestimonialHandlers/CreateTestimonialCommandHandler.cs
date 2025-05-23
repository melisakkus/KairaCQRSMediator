using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler(IRepository<Testimonial> _repository, IMapper _mapper)
    {
        public async Task Handle(CreateTestimonialCommand createTestimonialCommand)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialCommand);
            await _repository.CreateAsync(value);
        }
    }
}
