namespace KairaCQRSMediator.Features.CQRS.Results.ServiceResuts
{
    public class GetServiceByIdQueryResult
    {
        public int ServiceId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
    }
}
