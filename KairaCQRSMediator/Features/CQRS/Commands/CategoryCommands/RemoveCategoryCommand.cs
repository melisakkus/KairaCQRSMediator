namespace KairaCQRSMediator.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand(int id)
    {
        public int Id { get; set; } = id;
    }
}
