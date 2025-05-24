using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Repositories;
using MediatR;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class CreateContactInfoCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<CreateContactInfoCommand>
    {
        public async Task Handle(CreateContactInfoCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<ContactInfo>(request);
            await _repository.CreateAsync(value);
        }
    }
}
