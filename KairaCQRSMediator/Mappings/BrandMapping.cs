using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.CQRS.Commands.BrandCommands;
using KairaCQRSMediator.Features.CQRS.Results.BrandResults;

namespace KairaCQRSMediator.Mappings
{
    public class BrandMapping : Profile
    {
        public BrandMapping()
        {
            CreateMap<Brand, GetBrandQueryResult>().ReverseMap();
            CreateMap<Brand, GetBrandByIdQueryResult>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        }
    }
}
