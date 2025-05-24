using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.ContactInfoCommands;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.ContactInfoHandlers
{
    public class UpdateContactInfoCommandHandler(IRepository<ContactInfo> _repository, IMapper _mapper) : IRequestHandler<UpdateContactInfoCommand>
    {
        public async Task Handle(UpdateContactInfoCommand request, CancellationToken cancellationToken)
        {
           var value = _mapper.Map<ContactInfo>(request);
            await _repository.UpdateAsync(value);
        }
    }
}
