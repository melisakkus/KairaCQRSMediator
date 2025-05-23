using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler(IRepository<Testimonial> _repository, IMapper _mapper)
    {
        public async Task Handle(UpdateTestimonialCommand command)
        {
            var value = _mapper.Map<Testimonial>(command);  
            await _repository.UpdateAsync(value);
        }
    }
}
