namespace KairaCQRSMediator.Features.CQRS.Commands.TestimonialCommands
{
    public class UpdateTestimonialCommand
    {
        public int TestimonialId { get; set; }
        public string? Description { get; set; }
        public string? ByName { get; set; }
    }
}
