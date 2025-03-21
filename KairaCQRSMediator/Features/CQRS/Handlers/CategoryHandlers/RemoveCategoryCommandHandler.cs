using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler(IRepository<Category> _repository)
    {
        public async Task Handle(RemoveCategoryCommand command)
        {
            await _repository.DeleteAsync(command.Id);
        }        
    }
}
