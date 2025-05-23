using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.SubscribeCommands;
using KairaCQRSMediator.Features.Mediator.Results.SubscribeResults;

namespace KairaCQRSMediator.Mappings
{
    public class SubscribeMapping : Profile
    {
        public SubscribeMapping()
        {
            CreateMap<Subscribe, GetSubscribeQueryResult>().ReverseMap();
            CreateMap<Subscribe, GetSubscribeByIdQueryResult>().ReverseMap();
            CreateMap<Subscribe, CreateSubscribeCommand>().ReverseMap();
            CreateMap<Subscribe, UpdateSubscribeCommand>().ReverseMap();
        }
    }
}
