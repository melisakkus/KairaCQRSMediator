using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SocialMediaCommands;
using KairaCQRSMediator.Repositories;
using MediatR;
using NuGet.Protocol.Plugins;

namespace KairaCQRSMediator.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler(IRepository<SocialMedia> _repository, IMapper _mapper) : IRequestHandler<UpdateSocialMediaCommand>
    {
        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<SocialMedia>(request);
            await _repository.UpdateAsync(value);
        }
    }
}
