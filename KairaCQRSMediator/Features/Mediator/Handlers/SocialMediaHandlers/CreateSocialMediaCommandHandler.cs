using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler(IRepository<SocialMedia> _repository, IMapper _mapper) : IRequestHandler<CreateSocialMediaCommand>
    {
        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<SocialMedia>(request);
            await _repository.CreateAsync(value);
        }
    }
}
