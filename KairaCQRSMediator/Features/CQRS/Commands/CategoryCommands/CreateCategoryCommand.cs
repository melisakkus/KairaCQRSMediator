using KairaCQRSMediator.DataAccess.Entities;

namespace KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
