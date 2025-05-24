using AutoMapper;
using KairaCQRSMediator.DataAccess.Entities;
using KairaCQRSMediator.Features.Mediator.Commands.GalleryCommands;
using KairaCQRSMediator.Features.Mediator.Handlers.GalleryHandlers;
using KairaCQRSMediator.Features.Mediator.Results.GalleryResults;

namespace KairaCQRSMediator.Mappings
{
    public class GalleryMapping : Profile
    {
        public GalleryMapping() 
        {
            CreateMap<PhotoGallery,GetGalleryQueryResult>().ReverseMap();
            CreateMap<PhotoGallery,GetGalleryByIdQueryResult>().ReverseMap();
            CreateMap<PhotoGallery,UpdateGalleryCommand>().ReverseMap();
            CreateMap<PhotoGallery,CreateGalleryCommand>().ReverseMap();
        }
    }
}
