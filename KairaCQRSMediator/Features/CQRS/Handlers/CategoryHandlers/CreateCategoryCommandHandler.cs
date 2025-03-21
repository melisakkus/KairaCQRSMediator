using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands;
using KairaCQRSMediator.Repositories;

namespace KairaCQRSMediator.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler(IRepository<Category> _repository)
    {        
        public async Task Handle(CreateCategoryCommand command)
        {
            var category = new Category
            {
                CategoryName = command.CategoryName,
                ImageUrl = command.ImageUrl,
            };
            await _repository.CreateAsync(category);
        }
    }
}
